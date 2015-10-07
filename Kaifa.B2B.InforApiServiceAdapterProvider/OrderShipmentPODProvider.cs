using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ScheduledTaskAdapter.TaskComponents;
using System.ComponentModel;
using System.Data.SqlClient;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace Kaifa.B2B.InforApiServiceAdapterProvider
{
    public class OrderShipmentPODProvider : IScheduledTaskStreamProvider
    {
        public Type GetParameterType()
        {
            return typeof(OrderShipmentPODProviderParameters);
        }




        #region IScheduledTaskStreamProvider Members


        public System.IO.Stream GetStream(object args)
        {
            OrderShipmentPODProviderParameters _args = new OrderShipmentPODProviderParameters();
            _args = args as OrderShipmentPODProviderParameters;
            _args.tagnamespace = "http://kaifa.b2b.schemas/OrderShipmentPOD";
            IEnumerable<string> orderkeys = GetOrderKeys(_args);
            if (orderkeys.Count() > 0)
            {

                MemoryStream ms = new MemoryStream();
                XmlWriterSettings xws = new XmlWriterSettings();
                xws.OmitXmlDeclaration = true;
                xws.Indent = true;

                using (XmlWriter xw = XmlWriter.Create(ms, xws))
                {
                    OrderShipmentPODGenerator report = new OrderShipmentPODGenerator(orderkeys.ToArray(), _args.configPath, _args.fromRole, _args.tostxRole, _args.toe2openRole, _args.warehous, _args.connectionstring, _args.tagnamespace);
                    XDocument doc = report.Generator();
                    doc.WriteTo(xw);
                }
                ms.Seek(0, SeekOrigin.Begin);
                //System.Diagnostics.Trace.WriteLine("");


                UpdateFlag(_args, orderkeys.ToArray());
                System.Diagnostics.Trace.WriteLine(string.Format("Create OrderShipmentPOD {0}", orderkeys), "OrderShipmentPODProvider");
                return ms;


                
            }
            else
            {
                return null;
            }
        }

        private IEnumerable<string> GetOrderKeys(OrderShipmentPODProviderParameters _args)
        {
            using (SqlConnection conn = new SqlConnection(_args.connectionstring))
            {
                conn.Open();
                string sqlcmd = string.Format(@"SELECT T.ORDERKEY  FROM  [{0}].[ORDERS]  T WHERE (T.B2BFLAG2=0 OR T.B2BFLAG2 IS NULL) AND STATUS=N'95' 
                                               AND  EXISTS (SELECT ORDERKEY FROM [{0}].[ORDER_POD] T1 WHERE T.ORDERKEY = T1.ORDERKEY )
                                        ", _args.warehous);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sqlcmd;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    yield return reader.GetString(0);
                }

            }
        }
        private void UpdateFlag(OrderShipmentPODProviderParameters _args, string[] orderkeys) {
            using (SqlConnection conn = new SqlConnection(_args.connectionstring))
            {
                conn.Open();
                string whereexpression = "    WHERE ORDERKEY  IN (" + string.Join(",", orderkeys.Select(t => "'" + t + "'").ToArray()) + ")";
                string sqlcmd = string.Format("UPDATE  [{0}].[ORDERS]  SET B2BFLAG2 = 1 {1}", _args.warehous, whereexpression);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sqlcmd;
                cmd.ExecuteNonQuery();

            }
        }

        #endregion
    }

    [Serializable()]
    public class OrderShipmentPODProviderParameters
    {
        [Description("PIP fromRole"), Category("PIP")]
        public string fromRole { get; set; }
        [Description("PIP toSTXRole"), Category("PIP")]
        public string tostxRole { get; set; }
        [Description("PIP toe2openRole"), Category("PIP")]
        public string toe2openRole { get; set; }

        [Description("Config File Path"), Category("Config")]
        public string configPath { get; set; }
        [Description("Warehouse Name"), Category("Config")]
        public string warehous { get; set; }

        [Description("Connection String"), Category("Config")]
        public string connectionstring { get; set; }
        [Description("Xml targetNamespace"), Category("Config")]
        public string tagnamespace { get; set; }
    }

}
