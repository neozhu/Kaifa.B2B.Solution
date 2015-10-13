using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Xml;

namespace Kaifa.B2B.InforApiServiceAdapterProvider
{
    public class TDN940Generator
    {
        public string _orderKey;
        public string _warehous;
        public string _connectionstring;
        public string _tagnamespace;
        public TDN940Generator(string orderKey, string warehous, string connectionstring, string tagnamespace)
        {
            _orderKey = orderKey;
            _warehous = warehous;
            _connectionstring = connectionstring;
            _tagnamespace = tagnamespace;

            _tagnamespace = "http://Kaifa.B2B.Schemas.OrderTDN940";
        }

        public XDocument Generator()
        {
            XDocument ordertnd = new XDocument(new XElement("OrderTDN940"));


            IEnumerable<XElement> rows = OrderTND();
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



        private IEnumerable<XElement> OrderTND()
        {
            string sqlcommandtext = string.Format(@"SELECT * FROM [{0}].[CM_TDN_940] as CM_TDN_940  WHERE ORDERKEY = N'{1}'
		            FOR XML AUTO,ELEMENTS", this._warehous, this._orderKey);

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
