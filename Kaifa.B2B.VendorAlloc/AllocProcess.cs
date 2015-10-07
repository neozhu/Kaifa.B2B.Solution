using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Excel;
using System.Data;
using System.Data.SqlClient;

namespace Kaifa.B2B.VendorAlloc
{
    public class AllocProcess
    {
        private string _excelFile;
        private string _connectionstring;
        public const string WAREHOUSE = "WMWHSE1";
        public AllocProcess(string allocFile, string connectionstring)
        {
            _excelFile = allocFile;
            _connectionstring = connectionstring;
        }
        private string GetAllocType(string filename)
        {
            if (filename.ToLower().IndexOf("adhoc") > 0)
            {
                return "A";
            }
            else
            {
                return "Q";
            }
        }
        public void Read() {
            using (FileStream stream = File.Open(_excelFile, FileMode.Open, FileAccess.Read)) {
                IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                excelReader.IsFirstRowAsColumnNames = true;
                DataSet result = excelReader.AsDataSet();
                excelReader.Close();
                stream.Close();
                if (result.Tables.Count > 0)
                {
                    using (SqlConnection conn = new SqlConnection(_connectionstring))
                    {
                        conn.Open();
                       
                        SqlTransaction trx = conn.BeginTransaction();
                        try
                        {
                            DataTable dt = result.Tables[0];
                            foreach (DataRow dr in dt.Rows)
                            {
                                object site = dr["Site"];
                                if (site == null || string.IsNullOrEmpty(site.ToString()))
                                {
                                    continue;
                                }
                                SqlCommand cmd = conn.CreateCommand();
                                cmd.Transaction = trx;
                                cmd.CommandText =string.Format(@"INSERT INTO [wmwhse1].[STXALLOCATION]
                                                    ([WHSEID]
                                                    ,[PLANNERCODE]
                                                    ,[SITE]
                                                    ,[TYPE]
                                                    ,[PRISKU]
                                                    ,[SKU]
                                                    ,[STORERKEY]
                                                    ,[COMMODITYCLASS]
                                                    ,[ALLQTY]
                                                    ,[STARTDATE]
                                                    ,[ENDDATE]
                                                    ,[ADDDATE]
                                                    ,[ADDWHO]
                                                    ,[NOTES])
                                                    VALUES
                                                          ('{0}'
                                                          ,'{1}'
                                                          ,'{2}'
                                                          ,'{3}'
                                                          ,'{4}'
                                                          ,'{5}'
                                                          ,'{6}'
                                                          ,'{7}'
                                                          ,'{8}'
                                                          ,'{9}'
                                                          ,'{10}'
                                                          ,'{11}'
                                                          ,'{12}'
                                                          ,'{13}')"   
                                    
                                    , WAREHOUSE
                                    , dr["Planner Code"]
                                    , dr["SITE"]
                                    , GetAllocType(_excelFile)
                                    , dr["Prime Part"]
                                    , dr["Alternate Part"]
                                    , dr["Vendor Number"]
                                    , dr["Non ASIC Indicator"]
                                    , dr["Allocation Percentage"]
                                    , dr["Start Date Active"]
                                    , dr["End Date Active"]
                                    , DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                                    , WAREHOUSE
                                    , ""
                                    );

                                //Site	Prime Part	Alternate Part	Vendor Number	Allocation Percentage	Start Date Active	End Date Active	Planner Code	Non ASIC Indicator
                                cmd.ExecuteNonQuery();
                            }
                            trx.Commit();
                            conn.Close();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                            trx.Rollback();
                            conn.Close();
                        }
                    }
                }


            }

        }

    }
}
