using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Xml;

namespace Kaifa.B2B.InforApiServiceAdapterProvider
{
    public class OrderShipmentGenerator
    {
        private string _orderKey;
        private string _fromRole;
        private string _toSTXRole;
        private string _toe2openRole;
        private string _warehous;
        private string _connectionstring;
        private string _tagnamespace;
        private string _configpath;
        public OrderShipmentGenerator(string orderkey, string configpath, string fromRole, string tostxRole, string toe2openRole, string warehous, string connectionstring, string tagnamespace)
        {
            _orderKey = orderkey;
            _fromRole = fromRole;
            _toSTXRole = tostxRole;
            _toe2openRole = toe2openRole;
            _connectionstring=connectionstring;
            _warehous = warehous;
            _tagnamespace = tagnamespace;
            _configpath = configpath;
        }
        public XDocument Generator()
        {
            XDocument order = new XDocument(new XElement("OrderShipment"));

            IEnumerable<XElement> vendorreports = Group(OrderShipment());
            foreach (XElement report in vendorreports)
            {


                order.Root.Add(report);
            }

            order.Root.Add(ASIC(OrderShipment()));
            if (!string.IsNullOrEmpty(_tagnamespace))
            {
                XNamespace nsSys = _tagnamespace;
                //asn.Root.Add(new XAttribute(XNamespace.Xmlns, nsSys));
                foreach (XElement el in order.Descendants())
                {
                    el.Name = nsSys + el.Name.LocalName;
                }
            }
            return order;
        }
        private  XElement ASIC(IEnumerable<XElement> rows) {
            bool hasASIC = rows.Where(x => x.Element("COMMODITYCLASS").Value == "ASIC").Any();
               if (hasASIC)
               {
                   XElement asic = new XElement("ASIC");
                   IEnumerable<string> orderkeys = rows.Where(x => x.Element("COMMODITYCLASS").Value == "ASIC").Select(x => x.Element("ORDERKEY").Value).Distinct();
                   foreach (string orderkey in orderkeys)
                   {
                       //表头/表体分组
                       XElement orderel = new XElement("ORDER");
                       orderel.Add(new XElement("ORDERKEY", orderkey));
                       string externorderkey = rows.Where(x =>
                           x.Element("ORDERKEY").Value == orderkey &&
                           x.Element("COMMODITYCLASS").Value == "ASIC").Select(x => x.Element("EXTERNORDERKEY").Value).First();
                       orderel.Add(new XElement("EXTERNORDERKEY", externorderkey));
                       string comcode = rows.Where(x =>
                           x.Element("ORDERKEY").Value == orderkey &&
                           x.Element("COMMODITYCLASS").Value == "ASIC").Select(x => x.Element("COMCODE").Value).First();
                       orderel.Add(new XElement("COMCODE", comcode));
                       XElement orderdetail = new XElement("ORDERDETAIL");
                       IEnumerable<XElement> detail = rows.Where(x =>
                           x.Element("ORDERKEY").Value == orderkey &&
                           x.Element("COMMODITYCLASS").Value == "ASIC").ToArray();
                       //orderdetail.Add(detail);
                       orderel.Add(detail);
                       asic.Add(orderel);

                   }
                   return asic;

               }
               else {
                   return null;
               }
        }
       
        private IEnumerable<XElement> Group(IEnumerable<XElement> rows)
        {
            IEnumerable<string> storerkeys = rows.Select(x => x.Element("STORERKEY").Value).Distinct();
            foreach (string key in storerkeys)
            {

                string duns = getStorerDuns(key);
                XElement storerGroup = new XElement("VendorShipmentReport");
                storerGroup.Add(new XAttribute("VendorCode", key));
                storerGroup.Add(new XAttribute("VendorDuns", duns));
                string cmcode = rows.Where(x => x.Element("STORERKEY").Value == key).Select(x => x.Element("CONSIGNEEKEY").Value).First();
                string cmduns = rows.Where(x => x.Element("STORERKEY").Value == key).Select(x => x.Element("CMDUNS").Value).First();
                storerGroup.Add(new XAttribute("CMCode", cmcode));
                storerGroup.Add(new XAttribute("CMDuns", cmduns));


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
                //添加所有物流/分ASIC/NOASIC
                IEnumerable<XElement> vendorreport = rows.Where(x => x.Element("STORERKEY").Value == key).ToArray();
                XElement all = new XElement("ALL");
                IEnumerable<string> orderkeys = rows.Where(x => x.Element("STORERKEY").Value == key).Select(x => x.Element("ORDERKEY").Value).Distinct();
                foreach (string orderkey in orderkeys)
                {
                    //表头/表体分组
                    XElement orderel = new XElement("ORDER");
                    orderel.Add(new XElement("ORDERKEY", orderkey));
                    string externorderkey = rows.Where(x => x.Element("STORERKEY").Value == key && x.Element("ORDERKEY").Value == orderkey).Select(x => x.Element("EXTERNORDERKEY").Value).First();
                    orderel.Add(new XElement("EXTERNORDERKEY", externorderkey));
                    string comcode = rows.Where(x => x.Element("STORERKEY").Value == key && x.Element("ORDERKEY").Value == orderkey).Select(x => x.Element("COMCODE").Value).First();
                    orderel.Add(new XElement("COMCODE", comcode));
                    XElement orderdetail = new XElement("ORDERDETAIL");
                    IEnumerable<XElement> detail =  rows.Where(x => x.Element("STORERKEY").Value == key &&　x.Element("ORDERKEY").Value == orderkey　).ToArray();
                    //orderdetail.Add(detail);
                    orderel.Add(detail);
                    all.Add(orderel);
                
                }


               
                storerGroup.Add(all);

                bool hasASIC = rows.Where(x => x.Element("STORERKEY").Value == key && x.Element("COMMODITYCLASS").Value == "ASIC").Any();
                if (hasASIC)
                {
                    XElement asic = new XElement("ASIC");
                    orderkeys = rows.Where(x => x.Element("STORERKEY").Value == key && x.Element("COMMODITYCLASS").Value == "ASIC").Select(x => x.Element("ORDERKEY").Value).Distinct();
                    foreach (string orderkey in orderkeys)
                    {
                        //表头/表体分组
                        XElement orderel = new XElement("ORDER");
                        orderel.Add(new XElement("ORDERKEY", orderkey));
                        string externorderkey = rows.Where(x => x.Element("STORERKEY").Value == key &&
                            x.Element("ORDERKEY").Value == orderkey &&
                            x.Element("COMMODITYCLASS").Value == "ASIC").Select(x => x.Element("EXTERNORDERKEY").Value).First();
                        orderel.Add(new XElement("EXTERNORDERKEY", externorderkey));
                        string comcode = rows.Where(x => x.Element("STORERKEY").Value == key && 
                            x.Element("ORDERKEY").Value == orderkey &&
                            x.Element("COMMODITYCLASS").Value == "ASIC").Select(x => x.Element("COMCODE").Value).First();
                        orderel.Add(new XElement("COMCODE", comcode));
                        XElement orderdetail = new XElement("ORDERDETAIL");
                        IEnumerable<XElement> detail = rows.Where(x => x.Element("STORERKEY").Value == key &&
                            x.Element("ORDERKEY").Value == orderkey &&
                            x.Element("COMMODITYCLASS").Value == "ASIC").ToArray();
                        //orderdetail.Add(detail);
                        orderel.Add(detail);
                        asic.Add(orderel);

                    }
                    storerGroup.Add(asic);
                }

                yield return storerGroup;

            }
        }
        private string getStorerDuns(string storerkey)
        {
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                string sql = string.Format("select t3.DUNSID from [{1}].STORER t3 where t3.STORERKEY=N'{0}' and t3.[TYPE]=N'1' ", storerkey,_warehous);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                return cmd.ExecuteScalar().ToString();
            }

        }

        private IEnumerable<XElement> OrderShipment()
        {
            string sqlcommandtext = string.Format(@"SELECT  STORERKEY,
		ORDERKEY,
		EXTERNORDERKEY,
		COMCODE,
        CONSIGNEEKEY,
		CMDUNS,
		TRANSACTIONDATE,
		SKU,
		SKUGROUP,
		COMMODITYCLASS,
		LOTTABLE02,
		LOTTABLE03,
		LOTTABLE06,
		LOTTABLE07,
		LOTTABLE08,
        SPREMARK,
		CAST(SUM(QTY) as int) AS QTY
FROM [{0}].[ASN_SG3B2] as [ORDERDETAIL]  where ORDERKEY = N'{1}'
GROUP BY 
		STORERKEY,ORDERKEY,EXTERNORDERKEY,COMCODE,
        CONSIGNEEKEY,CMDUNS,TRANSACTIONDATE,SKU,SKUGROUP,COMMODITYCLASS,
		LOTTABLE02,LOTTABLE03,LOTTABLE06,LOTTABLE07,LOTTABLE08,SPREMARK   FOR XML AUTO,ELEMENTS", this._warehous, this._orderKey);

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
