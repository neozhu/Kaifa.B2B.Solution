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
        private string _fileName = "";
        public AllocProcess(string allocFile, string connectionstring)
        {
            _excelFile = allocFile;
            _connectionstring = connectionstring;

            FileInfo fs = new FileInfo(_excelFile);

            _fileName = fs.Name;
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
                DataTable dt = null;
                excelReader.Close();
                stream.Close();
                if (result.Tables.Count > 0 && result.Tables[0].Rows.Count>0)
                {
                    DataTable notsku=VaildateTable(result.Tables[0]);
                    if (notsku.Rows.Count>0)
                    {
                        MailClient.SendNoSKUAllocNotificationMail(notsku, _excelFile, "以下SKU没有找到主数据-请先维护好主数据后再重新导入");

                        return;
                    }
                    using (SqlConnection conn = new SqlConnection(_connectionstring))
                    {
                        conn.Open();
                       
                        SqlTransaction trx = conn.BeginTransaction();
                        try
                        {
                             dt = result.Tables[0];
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
                                                    ,[STXAGRP]
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
                                                          ,'{14}'
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
                                    , _fileName
                                    );
                                Console.WriteLine("reading....." + dr["Planner Code"].ToString());
                                //Site	Prime Part	Alternate Part	Vendor Number	Allocation Percentage	Start Date Active	End Date Active	Planner Code	Non ASIC Indicator
                                cmd.ExecuteNonQuery();
                            }
                            trx.Commit();
                            conn.Close();


                            MailClient.SendAllocNotificationMail(dt, _excelFile,string.Empty);
                        }
                        catch (Exception e)
                        {
                            MailClient.SendAllocNotificationMail(dt, _excelFile, e.Message);
                            Console.WriteLine(e);
                            trx.Rollback();
                            conn.Close();
                        }
                    }
                }


            }

        }
        private DataTable VaildateTable(DataTable datatable)
        {
            DataTable dt = new DataTable();
            foreach (DataRow dr in datatable.Rows)
            {
                
                    if (!VaildationSKU(dr["Alternate Part"].ToString(), dr["Vendor Number"].ToString()))
                                {
                                    dt.ImportRow(dr);
                                }
            }
            return dt;
        }
        private bool VaildationSKU(string sku, string store)
        {
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("SELECT COUNT(*) FROM [WMWHSE1].SKU WHERE SKU=N'{0}' AND STORERKEY=N'{1}' ", sku,store);
                object result = cmd.ExecuteScalar();

                conn.Close();
                return Convert.ToBoolean(result);
            }
        }


        private void addSTXALLOCATION_RPT(string filename,string allocType)
        {
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format(" Select * FROM [SCPRD].[wmwhse1].[STXALLOCATION] where STXAGRP = N'{0}'",filename);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                 adapter.Fill(ds);
                 conn.Close();

                 foreach (DataRow dr in ds.Tables[0].Rows)
                 {
                     STXCalendar stxcalendar = null;
                     stxcalendar = getSTXFYQW(dr["STARTDATE"].ToString(), dr["ENDDATE"].ToString());
                     int sumqty = sumLocationQty(dr["PRISKU"].ToString(), stxcalendar);
                     //如果sumqty>0 不管
                     int exist = GetLocationRPT(stxcalendar, dr["PRISKU"].ToString(), dr["SKU"].ToString());


                     if (allocType == "Q")
                     {
                         
                     }
                     else
                     {

                     }
                 }

            }

           
        }

        private void insertLocRPT(DataRow dr,STXCalendar calendar,string filename)
        {
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                #region insert sql
                cmd.CommandText = string.Format(@"INSERT INTO [wmwhse1].[STXALLOCATION_RPT]
           ([WHSEID]
           ,[STXAGRP]
           ,[STXAKEY]
           ,[FISCALYEAR]
           ,[QUARTER]
           ,[WEEK]
           ,[PRISKU]
           ,[PLANNERCODE]
           ,[SITE]
           ,[STORERKEY]
           ,[SKU]
           ,[QPERCENT]
           ,[ADDWHO]
           ,[begweek]
       )
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
           ,'{13}'
		 
         )"
           , "wmwhse1"
           , filename
           , getmaxkey()
           , calendar.Year
           , calendar.Quarter
           ,calendar.Week
           , dr["PRISKU"].ToString()
           , dr["PLANNERCODE"].ToString()
           , dr["SITE"].ToString()
           , dr["STORERKEY"].ToString()
           , dr["SKU"].ToString()
           , dr["QPERCENT"].ToString()  
           , "importservice"
           , calendar.BeginWeek
                    );
                #endregion
                cmd.ExecuteNonQuery();



                conn.Close();
            }

        }
        private void updateLocRPT(DataRow dr, STXCalendar calendar, string filename)
        {

        }

        private int GetLocationRPT(STXCalendar calendar,string psku,string sku) {

            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("select count(*) from [wmwhse1].[STXALLOCATION_RPT] r where   r.PRISKU='{0}' and r.sku='{1}' and r.FISCALYEAR='{2}' and r.QUARTER='{3}' ",
                    psku, sku, calendar.Year, calendar.Quarter);

                object result = cmd.ExecuteScalar();
                conn.Close();
                return Convert.ToInt32(result);
                
            }
        }

        private int sumLocationQty(string psku,STXCalendar calendar)
        {
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("select isnull(sum(WALLACTUALQTY),0)  from [wmwhse1].[STXALLOCATION_RPT] r where     r.PRISKU='{0}' and r.FISCALYEAR='{1}' and r.QUARTER='{2}' ", 
                    psku,calendar.Year,calendar.Quarter);
                object result = cmd.ExecuteScalar();
                conn.Close();
                return Convert.ToInt32(result);

            }
        }
        private STXCalendar getSTXFYQW(string startdt, string enddt)
        {
            STXCalendar stxcalendar = new STXCalendar();

            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("  select Top 1 FISCALYEAR,QUARTER,WEEK from [SCPRD].[wmwhse1].[STXCALENDAR] where CONVERT(datetime,FROM_DATE) >= CONVERT(datetime,'{0}') and CONVERT(datetime,TO_DATE)<=CONVERT(datetime,'{1}')",
                    startdt,enddt);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    stxcalendar.Year = Convert.ToInt32( reader.GetSqlString(0));
                    stxcalendar.Quarter = Convert.ToInt32(reader.GetSqlString(1));
                    stxcalendar.Week = Convert.ToInt32(reader.GetSqlString(2));
                }
                conn.Close();
            }
            
            if (stxcalendar.Quarter==4 && isMaxWeek(stxcalendar.Year, stxcalendar.Quarter, stxcalendar.Week))
            {
                stxcalendar.Week = 1;

                stxcalendar.Quarter = 1;

                stxcalendar.Year = stxcalendar.Year + 1;

            }
            else if (isMaxWeek(stxcalendar.Year, stxcalendar.Quarter, stxcalendar.Week))
            {
                stxcalendar.Week = stxcalendar.Week + 1;
                stxcalendar.Quarter = stxcalendar.Quarter + 1;

            }
            stxcalendar.BeginWeek = getBeginWeek(stxcalendar.Year, stxcalendar.Quarter);
            return stxcalendar;

        }
        
        private bool isMaxWeek(int year,int quarter, int week)
        {
            int maxweek = 0;
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("select max(WEEK) from [SCPRD].[wmwhse1].[STXCALENDAR] where FISCALYEAR='{0}' and QUARTER='{1}'",
                    year, quarter);

                object result = cmd.ExecuteScalar();
                 maxweek = Convert.ToInt32(result);
                conn.Close();
            }
            return maxweek == week;
          
        }

        private bool isMaxQuarter(int year, int quarter)
        {
            int maxQuarter = 0;
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("select max(WEEK) from [SCPRD].[wmwhse1].[STXCALENDAR] where FISCALYEAR='{0}'",
                    year, quarter);

                object result = cmd.ExecuteScalar();
                maxQuarter = Convert.ToInt32(result);
                conn.Close();
            }
            return maxQuarter == quarter;

        }

        private int getBeginWeek(int year, int quarter)
        {


            int minweek = 0;
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("select min(r.[week]) from  [wmwhse1].[STXCALENDAR] r where r.FISCALYEAR='{0}' and r.[QUARTER]='{1}'",
                    year, quarter);

                object result = cmd.ExecuteScalar();
                minweek = Convert.ToInt32(result);
                conn.Close();
            }
            return minweek;
        }


        private string getmaxkey() {

            int maxkey = 0;
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("select max(convert(int,stxakey)) + 1 from [wmwhse1].[STXALLOCATION_RPT]"
                     );

                object result = cmd.ExecuteScalar();
                maxkey = Convert.ToInt32(result);
                conn.Close();
            }
            return maxkey.ToString();
        }
    }



    public class STXCalendar{

        public int Year;
        public int Quarter;
        public int Week;
        public int BeginWeek;
    }
}
