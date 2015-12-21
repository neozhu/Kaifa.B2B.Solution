using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ScheduledTaskAdapter.TaskComponents;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Kaifa.B2B.InforApiServiceAdapterProvider
{
    public class AdvancedShipNoticeProvider : IScheduledTaskStreamProvider
    {
        public Type GetParameterType()
        {
            return typeof(AdvancedShipNoticeProviderParameters);
        }

        public System.IO.Stream GetStream(object args)
        {
            AdvancedShipNoticeProviderParameters _args = new AdvancedShipNoticeProviderParameters();
            _args = args as AdvancedShipNoticeProviderParameters;
            _args.tagnamespace = "http://kaifa.b2b.schemas/AdvancedShipNotice";
            IEnumerable<string> keys = GetReceiptKeys(_args);
            if (keys.Count() > 0)
            {


                MemoryStream ms = new MemoryStream();
                XmlWriterSettings xws = new XmlWriterSettings();
                xws.OmitXmlDeclaration = true;
                xws.Indent = true;

                using (XmlWriter xw = XmlWriter.Create(ms, xws))
                {
                    AdvancedShipNoticeGenerator report = new AdvancedShipNoticeGenerator(keys.ToArray(), _args.configPath, _args.fromRole, _args.tostxRole, _args.toe2openRole, _args.warehous, _args.connectionstring, _args.tagnamespace);
                    XDocument doc = report.Generator();
                    doc.WriteTo(xw);
                }
                ms.Seek(0, SeekOrigin.Begin);
                System.Diagnostics.Trace.WriteLine("");
               

                UpdateFlag(_args, keys);
                System.Diagnostics.Trace.WriteLine(string.Format("Create AdvancedShipNotice {0}", string.Join(",", keys.Select(t => "" + t + "").ToArray())), "AdvancedShipNoticeProvider");
                return ms;
            }
            else
            {
                System.Diagnostics.Trace.WriteLine(" Null ", "AdvancedShipNoticeProvider");
                MailClient.SendNoHubReceiptNotificationMail(_args.toAddresses);
                return null;
            }

             
        }

        public IEnumerable<string> GetReceiptKeys(AdvancedShipNoticeProviderParameters para) {
            using (SqlConnection conn = new SqlConnection(para.connectionstring))
            {
                conn.Open(); 
                string sqlcmd = string.Format("SELECT T.RECEIPTKEY  FROM  [{0}].[RECEIPT]  T WHERE (T.B2BFLAG=0 OR T.B2BFLAG IS NULL) AND STATUS=N'11' AND T.[TYPE]!=N'30' ", para.warehous);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sqlcmd;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    yield return reader.GetString(0);
                }

            }
            
        }
        public void UpdateFlag(AdvancedShipNoticeProviderParameters para, IEnumerable<string> receiptKeys)
        {
            using (SqlConnection conn = new SqlConnection(para.connectionstring))
            {
                conn.Open();
                string whereexpression = "    WHERE RECEIPTKEY  IN (" + string.Join(",", receiptKeys.Select(t => "'" + t + "'").ToArray()) + ")";
                string sqlcmd = string.Format("UPDATE  [{0}].[RECEIPT]  SET B2BFLAG = 1 {1}", para.warehous, whereexpression);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sqlcmd;
                cmd.ExecuteNonQuery();

            }
        }
    }


    [Serializable()]
    public class AdvancedShipNoticeProviderParameters
    {
        [Description("PIP fromRole"), Category("PIP") ]
        public string fromRole { get; set; }
        [Description("PIP toSTXRole"), Category("PIP") ]
        public string tostxRole { get; set; }
        [Description("PIP toe2openRole"), Category("PIP") ]
        public string toe2openRole { get; set; }

        [Description("Config File Path"), Category("Config") ]
        public string configPath { get; set; }
        [Description("Warehouse Name"), Category("Config") ]
        public string warehous { get; set; }

        [Description("Connection String"), Category("Config") ]
        public string connectionstring { get; set; }
        [Description("Xml targetNamespace"), Category("Config") ]
        public string tagnamespace { get; set; }

        [Description("To Mail Addresses"), Category("Config")]
        public string toAddresses { get; set; }

    }

}
