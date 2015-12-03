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
    public class OrderShipmentProvider : IScheduledTaskStreamProvider
    {
        public Type GetParameterType()
        {
            return typeof(OrderShipmentProviderParameters);
        }




        #region IScheduledTaskStreamProvider Members


        public System.IO.Stream GetStream(object args)
        {
            OrderShipmentProviderParameters _args = new OrderShipmentProviderParameters();
            _args = args as OrderShipmentProviderParameters;
            _args.tagnamespace = "http://kaifa.b2b.schemas/OrderShipment";
            string orderkey = GetOrderKey(_args);
            if (!string.IsNullOrEmpty(orderkey))
            {

                MemoryStream ms = new MemoryStream();
                XmlWriterSettings xws = new XmlWriterSettings();
                xws.OmitXmlDeclaration = true;
                xws.Indent = true;

                using (XmlWriter xw = XmlWriter.Create(ms, xws))
                {
                    OrderShipmentGenerator report = new OrderShipmentGenerator(orderkey, _args.configPath, _args.fromRole, _args.tostxRole, _args.toe2openRole, _args.warehous, _args.connectionstring, _args.tagnamespace);
                    XDocument doc = report.Generator();
                    doc.WriteTo(xw);
                }
                ms.Seek(0, SeekOrigin.Begin);
                //System.Diagnostics.Trace.WriteLine("");


                UpdateFlag(_args, orderkey);
                System.Diagnostics.Trace.WriteLine(string.Format("Create OrderShipment {0}", orderkey), "OrderShipmentProvider");
                return ms;


                
            }
            else
            {
                return null;
            }
        }

        private string GetOrderKey(OrderShipmentProviderParameters _args)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_args.connectionstring))
                {
                    conn.Open();
                    string sqlcmd = string.Format(@"SELECT TOP 1 T.ORDERKEY  FROM  [{0}].[ORDERS]  T WHERE (T.B2BFLAG1=0 OR T.B2BFLAG1 IS NULL) AND STATUS=N'88'  
                                               AND  EXISTS (SELECT ORDERKEY FROM [{0}].[ASN_SG3B2] T1 WHERE T.ORDERKEY = T1.ORDERKEY )
                                        ", _args.warehous);
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = sqlcmd;
                    object result = cmd.ExecuteScalar();
                    conn.Close();
                    return (result == null ? string.Empty : result.ToString());

                }
            }
            catch {
                return string.Empty;
            }
        }
        private void UpdateFlag(OrderShipmentProviderParameters _args, string orderkey) {
            using (SqlConnection conn = new SqlConnection(_args.connectionstring))
            {
                conn.Open();
                //string whereexpression = "    WHERE RECEIPTKEY  IN (" + string.Join(",", receiptKeys.Select(t => "'" + t + "'").ToArray()) + ")";
                string sqlcmd = string.Format("UPDATE  [{0}].[ORDERS]  SET B2BFLAG1 = 1 where ORDERKEY = N'{1}'", _args.warehous, orderkey);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sqlcmd;
                cmd.ExecuteNonQuery();

            }
        }

        #endregion
    }

    [Serializable()]
    public class OrderShipmentProviderParameters
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
