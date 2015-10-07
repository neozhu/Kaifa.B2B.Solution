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
    public class InventoryReportProvider : IScheduledTaskStreamProvider
    {
        public Type GetParameterType()
        {
            return typeof(InventoryReportProviderParameters);
        }

        public System.IO.Stream GetStream(object args)
        {
            InventoryReportProviderParameters _args = new InventoryReportProviderParameters();
            _args = args as InventoryReportProviderParameters;
            if (string.IsNullOrEmpty(_args.connectionstring) || string.IsNullOrEmpty(_args.warehous))
            {
                throw new NullReferenceException();
            }
            if (getCount(_args) > 0)
            {

                MemoryStream ms = new MemoryStream();
                XmlWriterSettings xws = new XmlWriterSettings();
                xws.OmitXmlDeclaration = true;
                xws.Indent = true;
                _args.tagnamespace = "http://kaifa.b2b.schemas/InventoryReport";
                using (XmlWriter xw = XmlWriter.Create(ms, xws))
                {
                    InventoryReportGenerator report = new InventoryReportGenerator(false, _args.configPath, _args.fromRole, _args.tostxRole, _args.toe2openRole, _args.warehous, _args.connectionstring, _args.tagnamespace);
                    XDocument doc = report.Generator();
                    doc.WriteTo(xw);
                }
                ms.Seek(0, SeekOrigin.Begin);
                System.Diagnostics.Trace.WriteLine("Create Inventory Report ", "InventoryReportProvider");
                return ms;
            }
            else
            {
                return null;
            }

        }

        private int getCount(InventoryReportProviderParameters _args) {
            using (SqlConnection conn = new SqlConnection(_args.connectionstring))
            {
                conn.Open();
                string sqlcmd = string.Format(@"SELECT COUNT(*) FROM [{0}].[INVENTORYREPORT_SGHUB]
                                        ", _args.warehous);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sqlcmd;
                object result = cmd.ExecuteScalar();
                return (result == null ? 0 : Convert.ToInt32(result.ToString()));

            }
        
        }
    }


    [Serializable()]
    public class InventoryReportProviderParameters
    {
        [Description("PIP fromRole"), Category("PIP") ]
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
