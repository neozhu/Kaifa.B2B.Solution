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
    public class ARProvider : IScheduledTaskStreamProvider
    {
        public Type GetParameterType()
        {
            return typeof(ARProviderParameters);
        }




        #region IScheduledTaskStreamProvider Members


        public System.IO.Stream GetStream(object args)
        {
            ARProviderParameters _args = new ARProviderParameters();
            _args = args as ARProviderParameters;
            _args.tagnamespace = "http://Kaifa.B2B.Schemas.WMSAR";
            string batchid = GetBatchId(_args);
            return null;
            //if (!string.IsNullOrEmpty(batchid))
            //{

            //    MemoryStream ms = new MemoryStream();
            //    XmlWriterSettings xws = new XmlWriterSettings();
            //    xws.OmitXmlDeclaration = true;
            //    xws.Indent = true;

            //    using (XmlWriter xw = XmlWriter.Create(ms, xws))
            //    {
            //        ARGenerator tdn = new ARGenerator(batchid, _args.warehous, _args.connectionstring, _args.tagnamespace);
            //        XDocument doc = tdn.Generator();
            //        doc.WriteTo(xw);
            //    }
            //    ms.Seek(0, SeekOrigin.Begin);
            //    //System.Diagnostics.Trace.WriteLine("");


            //    //UpdateFlag(_args, orderkey);
            //    System.Diagnostics.Trace.WriteLine(string.Format("Create AR {0}", batchid), "ARProvider");
            //    return ms;


                
            //}
            //else
            //{
            //    return null;
            //}
        }
//1.	结账日期为： 上月的21日0：00至 当月20日24：00；
//2.	进出口部每月必须在20日之前上传关务费用至WMS系统；
//3.	当月21日客服人员发出账单给到各个货主（客户）进行费用核对及确认，在当月月末的前三天完成核对及系统中异常项修正处理； 
//      跨月异常项则由财务在SAP中手动修正并备注说明。
//4.	WMS在每月月末的倒数第三天24：00自动触发账单上传至SAP系统；SAP产生会计凭证
        private string GetBatchId(ARProviderParameters _args)
        {
            DateTime date = DateTime.Now;
            DateTime firstOfNextMonth = new DateTime(date.Year, date.Month, 1).AddMonths(1);
            DateTime lastOfThisMonth = firstOfNextMonth.AddDays(-1);
            int lastscday = lastOfThisMonth.Day - 1;
            string batchId = "";
            if (date.Day == lastscday)
            {
               
                DateTime sdt = new DateTime(date.Year, (date.Month - 1), 21);
                DateTime edt = new DateTime(date.Year, date.Month, 21);

                batchId = sdt.ToString("yyyyMMdd") + edt.ToString("yyyyMMdd");
                using (SqlConnection conn = new SqlConnection(_args.connectionstring))
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = string.Format("select count(*) from BILLADMIN.BIC_CHARGE  where CHARGE_DATE>='{0}' AND CHARGE_DATE<='{1}' AND ARBATCHID IS NULL", 
                       sdt.ToString("yyyy-MM-dd HH:mm:ss"), edt.ToString("yyyy-MM-dd HH:mm:ss"));
                    object res = cmd.ExecuteScalar();
                    int count = Convert.ToInt32(res);
                    if (count > 0)
                    {
                        string sqlcmd = string.Format(@" update BILLADMIN.BIC_CHARGE set ARBATCHID = '{0}_'+ CUST_CODE,INVOICE_STATUS='C',ARSAPDT=getdate() where CHARGE_DATE>='{1}' AND CHARGE_DATE<='{2}' AND ARBATCHID IS NULL
                                        ", batchId, sdt.ToString("yyyy-MM-dd HH:mm:ss"), edt.ToString("yyyy-MM-dd HH:mm:ss"));

                        cmd.CommandText = sqlcmd;
                        cmd.ExecuteNonQuery();

                        
                        return batchId;
                    }
                    else
                        return string.Empty;

                }

            }
            else
            {
                if (_args.Immediately)
                {
                    //batchId = date.ToString("yyyyMMdd");
                    DateTime sdt = new DateTime(date.Year, (date.Month - 1), 21);
                    DateTime edt = new DateTime(date.Year, date.Month, 21);
                    batchId = sdt.ToString("yyyyMMdd") + edt.ToString("yyyyMMdd");
                    using (SqlConnection conn = new SqlConnection(_args.connectionstring))
                    {
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = string.Format("select count(*) from BILLADMIN.BIC_CHARGE where CHARGE_DATE>='{0}' AND CHARGE_DATE<='{1}' AND ARBATCHID IS NULL",
                             sdt.ToString("yyyy-MM-dd HH:mm:ss"), edt.ToString("yyyy-MM-dd HH:mm:ss"));
                        object res = cmd.ExecuteScalar();
                        int count = Convert.ToInt32(res);
                        if (count > 0)
                        {
                            string sqlcmd = string.Format(@" update BILLADMIN.BIC_CHARGE set ARBATCHID = '{0}_'+ CUST_CODE,INVOICE_STATUS='C',ARSAPDT=getdate() where CHARGE_DATE>='{1}' AND CHARGE_DATE<='{2}' AND ARBATCHID IS NULL
                                        ", batchId, sdt.ToString("yyyy-MM-dd HH:mm:ss"), edt.ToString("yyyy-MM-dd HH:mm:ss"));

                            cmd.CommandText = sqlcmd;
                            cmd.ExecuteNonQuery();
                            return batchId;
                        }
                        else
                            return string.Empty;



                    }
                }

                return string.Empty;
            }


           
        }
        private void UpdateFlag(TDN940ProviderParameters _args, string orderkey) {
            using (SqlConnection conn = new SqlConnection(_args.connectionstring))
            {
                conn.Open();
                //string whereexpression = "    WHERE RECEIPTKEY  IN (" + string.Join(",", receiptKeys.Select(t => "'" + t + "'").ToArray()) + ")";
                string sqlcmd = string.Format("UPDATE  [{0}].[ORDERS]  SET B2BFLAG3 = 1 where ORDERKEY = N'{1}'", _args.warehous, orderkey);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sqlcmd;
                cmd.ExecuteNonQuery();

            }
        }

        #endregion
    }

    [Serializable()]
    public class ARProviderParameters
    {
      
        [Description("Warehouse Name"), Category("Config")]
        public string warehous { get; set; }

        [Description("Connection String"), Category("Config")]
        public string connectionstring { get; set; }
        [Description("Xml targetNamespace"), Category("Config")]
        public string tagnamespace { get; set; }
        [Description("Enable Immediately"), Category("Config")]
        public bool Immediately { get; set; }
    }

}
