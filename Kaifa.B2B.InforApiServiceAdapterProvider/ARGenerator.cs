using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Xml;

namespace Kaifa.B2B.InforApiServiceAdapterProvider
{
    public class ARGenerator
    {
        public string _wmsbatchid;
        public string _warehous;
        public string _connectionstring;
        public string _tagnamespace;
        public ARGenerator(string wmsbatchid, string warehous, string connectionstring, string tagnamespace)
        {
            _wmsbatchid = wmsbatchid;
            _warehous = warehous;
            _connectionstring = connectionstring;
            _tagnamespace = tagnamespace;

            _tagnamespace = "http://Kaifa.B2B.Schemas.WMSAR";
        }

        public XDocument Generator()
        {
            XDocument ordertnd = new XDocument(new XElement("ARReport"));


            IEnumerable<XElement> rows = Group(ArReport().ToList()) ;
            foreach (XElement row in rows)
            {


                ordertnd.Root.Add(row);
            }

            if (!string.IsNullOrEmpty(_tagnamespace))
            {
                XNamespace nsSys = _tagnamespace;
                //asn.Root.Add(new XAttribute(XNamespace.Xmlns, nsSys));
                foreach (XElement el in ordertnd.Descendants())
                {
                    el.Name = nsSys + el.Name.LocalName;
                }
            }
            return ordertnd;

        }
        private IEnumerable<XElement> Group(IEnumerable<XElement> receipts)
        {

            IEnumerable<string> storerkeys = receipts.Select(x => x.Element("CUST_CODE").Value).Distinct();
            foreach (string key in storerkeys)
            {

               
                XElement storerGroup = new XElement("CustARReport");
                storerGroup.Add(new XAttribute("CUSTCODE", key));


                IEnumerable<XElement> vendorreport = receipts.Where(x => x.Element("CUST_CODE").Value == key).ToArray();
                storerGroup.Add(vendorreport);


                yield return storerGroup;

            }



        }


        private IEnumerable<XElement> ArReport()
        {
            string sqlcommandtext = string.Format(@"SELECT AR.ARBATCHID,AR.CUST_CODE,AR.INVOICE_TYPE, CAST(SUM(AR.CHARGE_AMT) AS NUMERIC(15,2)) as COST 
                                                    FROM BILLADMIN.BIC_CHARGE AR
                                                    WHERE AR.ARBATCHID LIKE '{0}_%'
                                                    GROUP BY AR.ARBATCHID,AR.CUST_CODE,AR.INVOICE_TYPE 
                                                    HAVING SUM(AR.CHARGE_AMT)>0 FOR XML AUTO,ELEMENTS", this._wmsbatchid);

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
