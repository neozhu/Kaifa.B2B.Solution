using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Data.SqlClient;
using System.Xml;
namespace Kaifa.B2B.InforApiServiceAdapterProvider
{
    public class AdvancedShipNoticeGenerator 
    {
        private string[] _receiptkeys;
        private string _fromRole;
        private string _toSTXRole;
        private string _toe2openRole;
        private string _warehous;
        private string _connectionstring;
        private string _tagnamespace;
        private string _configpath;
        public AdvancedShipNoticeGenerator(string[] receiptkeys, string configpath, string fromRole, string tostxRole, string toe2openRole, string warehous, string connectionstring, string tagnamespace)
        {
            _receiptkeys = receiptkeys;
            _fromRole = fromRole;
            _toSTXRole = tostxRole;
            _toe2openRole = toe2openRole;
            _connectionstring=connectionstring;
            _warehous = warehous;
            _tagnamespace = tagnamespace;
            _configpath = configpath;
        }

        public XDocument Generator() {
            XDocument asn = new XDocument(new XElement("AdvancedShipNotice"));

            IEnumerable<XElement> receipts = Group(Receipt().ToList());
            foreach (XElement receipt in receipts.ToList())
            {


                asn.Root.Add(receipt);
            }
            //XElement fromrole = ConfigHelper.GetRoleElement(_fromRole, "fromRole");
            //XElement torole = ConfigHelper.GetRoleElement(_toRole, "toRole");
            //XElement config = new XElement("config");
            //config.Add(new XElement("fromRole", fromrole.Elements()));
            //config.Add(new XElement("toRole", torole.Elements()));
            //asn.Root.Add(config);

            //IEnumerable<XElement> receipts = Receipt();
            //foreach (XElement receipt in receipts) { 
            //       //string receiptkey= receipt.Element("RECEIPTKEY").Value;
            //       //IEnumerable<XElement> details = ReceiptDetail(receiptkey);
            //       //receipt.LastNode.AddAfterSelf(details);
            //       asn.Root.Add(receipt);
            //}
            //asn.Root.Add(receipts);
            if (!string.IsNullOrEmpty(_tagnamespace))
            {
                XNamespace nsSys = _tagnamespace;
                //asn.Root.Add(new XAttribute(XNamespace.Xmlns, nsSys));
                foreach (XElement el in asn.Descendants())
                {
                    el.Name = nsSys + el.Name.LocalName;
                }
            }
            return asn;
        }
        private IEnumerable<XElement> Group (IEnumerable<XElement> receipts){

            IEnumerable<string> storerkeys = receipts.Select(x => x.Element("STORERKEY").Value).Distinct();
            foreach (string key in storerkeys) {

                string duns = getStorerDuns(key);
                XElement storerGroup = new XElement("VendorReceiptReport");
                storerGroup.Add(new XAttribute("VendorCode", key));
                storerGroup.Add(new XAttribute("VendorDuns", duns));
                XElement fromrole = ConfigHelper.GetRoleElement(_configpath, _fromRole, "fromRole");
                XElement tostxrole = ConfigHelper.GetRoleElement(_configpath, _toSTXRole, "toRole");
                XElement toe2openrole = ConfigHelper.GetRoleElement(_configpath, _toe2openRole, "toRole");
                //XElement hub = ConfigHelper.GetRoleElement(_warehous, "hub");
                XElement config = new XElement("config");
                config.Add(new XElement("fromRole", fromrole.Elements()));
                config.Add(new XElement("tostxRole", tostxrole.Elements()));
                config.Add(new XElement("toe2openRole", toe2openrole.Elements()));
                //config.Add(new XElement("hub", hub.Elements()));
                storerGroup.Add(config);

                IEnumerable<XElement> vendorreport = receipts.Where(x => x.Element("STORERKEY").Value == key).ToArray();
                storerGroup.Add(vendorreport);


                yield return storerGroup;
            
            }


         
        }

        private string getStorerDuns(string storerkey)
        {
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                string sql = string.Format("select t3.DUNSID from [wmwhse1].STORER t3 where t3.STORERKEY=N'{0}' and t3.[TYPE]=N'1' ", storerkey);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                return cmd.ExecuteScalar().ToString();
            }

        }
        private  IEnumerable<XElement> Receipt()
        {
            string whereexpression = "    AND RECEIPT.RECEIPTKEY  IN (" + string.Join(",", _receiptkeys.Select(t => "'" + t + "'").ToArray()) + ")";
            string sqlcommandtext = string.Format(@"SELECT RECEIPT.WHSEID,RECEIPT.RECEIPTKEY,RECEIPT.STORERKEY,RECEIPT.[TYPE],
		                                            RECEIPTDETAIL.SKU,RECEIPTDETAIL.LOTTABLE02,
		                                            RECEIPTDETAIL.LOTTABLE03,RECEIPTDETAIL.LOTTABLE06,
		                                            CAST(SUM(RECEIPTDETAIL.QTYRECEIVED) AS INT) QTYRECEIVED,
		                                            '' DOREMARK
                                                    FROM [{0}].[RECEIPT] RECEIPT ,[{0}].[RECEIPTDETAIL] RECEIPTDETAIL
                                                    WHERE RECEIPT.RECEIPTKEY = RECEIPTDETAIL.RECEIPTKEY {1}
                                                    GROUP BY RECEIPT.WHSEID,RECEIPT.RECEIPTKEY,RECEIPT.STORERKEY,RECEIPT.[TYPE],RECEIPTDETAIL.SKU,
                                                    RECEIPTDETAIL.LOTTABLE02,RECEIPTDETAIL.LOTTABLE03,
                                                    RECEIPTDETAIL.LOTTABLE06 FOR XML AUTO,ELEMENTS", _warehous, whereexpression);
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandText = sqlcommandtext;
                XmlReader reader = command.ExecuteXmlReader();
                reader.Read();
                while (!reader.EOF)
                {
                    string row = reader.ReadOuterXml();
                    if (string.IsNullOrEmpty(row))
                        continue;
                    XElement el = XElement.Parse(row);
                    yield return el;
                }
                reader.Close();
                conn.Close();

            }
   

            #region //
            //string whereexpression = " WHERE RECEIPTKEY  IN (" + string.Join(",", _receiptkeys.Select(t => "'" + t + "'").ToArray()) + ")";
            //string sqlcommandtext = string.Format("SELECT * FROM  [{0}].[RECEIPT] AS RECEIPT {1}  FOR  XML AUTO, ELEMENTS", _warehous, whereexpression);
            //using (SqlConnection conn = new SqlConnection(_connectionstring)) {
            //    conn.Open();
            //    SqlCommand command = conn.CreateCommand();
            //    command.CommandText = sqlcommandtext;
            //    XmlReader reader = command.ExecuteXmlReader();
            //    reader.Read();
            //    while (!reader.EOF) { 
            //        string row= reader.ReadOuterXml();
            //        if (string.IsNullOrEmpty(row))
            //            continue;
            //        XElement el = XElement.Parse(row);
            //        yield return el;
            //    }
            //    reader.Close();
            //    conn.Close();

            //}
            //return null;
            #endregion
        }
        private IEnumerable<XElement> ReceiptDetail(string receiptkey) { 
            string sqlcommandtext = string.Format("SELECT * FROM [{0}].[RECEIPTDETAIL] AS RECEIPTDETAIL WHERE  RECEIPTDETAIL.[RECEIPTKEY]='{1}' FOR  XML AUTO, ELEMENTS",_warehous ,receiptkey);
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandText = sqlcommandtext;
                XmlReader reader = command.ExecuteXmlReader();
                reader.Read();
                while (!reader.EOF)
                {
                    string row = reader.ReadOuterXml();
                    if (string.IsNullOrEmpty(row))
                        continue;
                    XElement el = XElement.Parse(row);
                    yield return el;
                }
                reader.Close();
                conn.Close();

            }
        
        }

         
    }
}
