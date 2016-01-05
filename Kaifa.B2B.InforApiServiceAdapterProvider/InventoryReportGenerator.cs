using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Xml;

namespace Kaifa.B2B.InforApiServiceAdapterProvider
{
    public class InventoryReportGenerator
    {
        
        private string _fromRole;
        private string _toSTXRole;
        private string _toe2openRole;
        private string _warehous;
        private string _connectionstring;
        private string _tagnamespace;
        private bool _zerogenerate;
        private string _configpath;
        public InventoryReportGenerator(bool zerogenerate,string configpath,  string fromRole, string toSTXRole,string toe2openRole ,string warehous, string connectionstring, string tagnamespace)
        {
           
            _fromRole = fromRole;
            _toSTXRole = toSTXRole;
            _toe2openRole = toe2openRole;
            _connectionstring=connectionstring;
            _warehous = warehous;
            _tagnamespace = tagnamespace;
            _zerogenerate = zerogenerate;
            _configpath = configpath;
        }

        public XDocument Generator()
        {
            XDocument inv = new XDocument(new XElement("InventoryReport"));




            IEnumerable<XElement> reports = Group(GetReport().ToList());
            foreach (XElement report in reports.ToList())
            {


                inv.Root.Add(report);
            }
            //asn.Root.Add(receipts);
            if (!string.IsNullOrEmpty(_tagnamespace))
            {
                XNamespace nsSys = _tagnamespace;
                //asn.Root.Add(new XAttribute(XNamespace.Xmlns, nsSys));
                foreach (XElement el in inv.Descendants())
                {
                    el.Name = nsSys + el.Name.LocalName;
                }
            }
            return inv;
        }


        private IEnumerable<XElement> GetReport() {
            string sqlcommandtext = string.Format("SELECT * FROM [{0}].[INVENTORYREPORT_SGHUB] INVENTORY WHERE LOTTABLE06 <> N'AM' ORDER BY STORERKEY,SKU FOR XML AUTO,ELEMENTS", _warehous);
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

        private IEnumerable<XElement> Group(IEnumerable<XElement> reports)
        {
            IEnumerable<string> storerkeys = reports.Select(x => x.Element("STORERKEY").Value).Distinct();
            foreach (string key in storerkeys)
            {
                string duns = getStorerDuns(key);
                XElement storerGroup = new XElement("VendorInventoryReport");
                storerGroup.Add(new XAttribute("VendorCode", key));
                storerGroup.Add(new XAttribute("VendorDuns", duns));
                XElement fromrole = ConfigHelper.GetRoleElement(_configpath,_fromRole, "fromRole");
                XElement tostxrole = ConfigHelper.GetRoleElement(_configpath,_toSTXRole, "toRole");
                XElement toe2openrole = ConfigHelper.GetRoleElement(_configpath,_toe2openRole, "toRole");
                //XElement hub = ConfigHelper.GetRoleElement(_warehous, "hub");
                XElement config = new XElement("config");
                config.Add(new XElement("fromRole", fromrole.Elements()));
                config.Add(new XElement("tostxRole", tostxrole.Elements()));
                config.Add(new XElement("toe2openRole", toe2openrole.Elements()));
                //config.Add(new XElement("hub", hub.Elements()));
                storerGroup.Add(config);

                IEnumerable<XElement> vendorreport = reports.Where(x => x.Element("STORERKEY").Value == key).ToArray();
                storerGroup.Add(vendorreport);


                yield return storerGroup;
            }
        }
        private string getStorerDuns(string storerkey) {
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                string sql = string.Format("select t3.DUNSID from [{1}].STORER t3 where t3.STORERKEY=N'{0}' and t3.[TYPE]=N'1' ", storerkey,_warehous);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                return cmd.ExecuteScalar().ToString();
            }
         
        }
        private  IEnumerable< XElement> Report() {


            string sqlcommandtext = "";
            if (_zerogenerate)
            {
                sqlcommandtext = string.Format("SELECT * FROM [{0}].[LOTATTRIBUTE] LOTATTRIBUTE, [{0}].[LOTXLOCXID] LOTXLOCXID WHERE LOTXLOCXID.LOT = LOTATTRIBUTE.LOT    FOR  XML AUTO, ELEMENTS", _warehous);
            }
            else
            {
                sqlcommandtext = string.Format("SELECT * FROM [{0}].[LOTATTRIBUTE] LOTATTRIBUTE, [{0}].[LOTXLOCXID] LOTXLOCXID WHERE LOTXLOCXID.LOT = LOTATTRIBUTE.LOT AND LOTXLOCXID.QTY>0   FOR  XML AUTO, ELEMENTS", _warehous);
            }
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
