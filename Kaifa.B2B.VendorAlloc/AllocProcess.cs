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
    public class Item {
        public string SITE { get; set; }
        public string PRIMEPART { get; set; }
        public string ALTERNATEPART { get; set; }
        public string VENDORCODE { get; set; }
        public string PERCENTAGE { get; set; }
        public string STARTDATE { get; set; }
        public string ENDDATE{get;set;}
        public string PLANNERCODE { get; set; }
        public string FLAG { get; set; }
        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3}", this.SITE, this.PRIMEPART, this.ALTERNATEPART, this.VENDORCODE);
        }
    }
    public class AllocProcess
    {
        private string _excelFile;
        private string _connectionstring;
        public const string WAREHOUSE = "WMWHSE1";
        private string _warehouse = "wmwhse1";
        private string _fileName = "";
        public AllocProcess(string allocFile, string connectionstring,string warehouse)
        {
            _excelFile = allocFile;
            _warehouse = warehouse;
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

        private List<Item> ReadCSV() {
            List<Item> list = new List<Item>();
            using (StreamReader sr = new StreamReader(_excelFile, Encoding.UTF8)) {
                string line = string.Empty;
                while ((line = sr.ReadLine()) != null)
                {
                    System.Console.WriteLine(line);
                    string[] lineitems = line.Split(new char[] { ',' });
                    if (lineitems.Length >= 9 && lineitems[0]=="SZT")
                    {
                        Item item = new Item();
                        item.SITE = lineitems[0];
                        item.PRIMEPART = lineitems[1];
                        item.ALTERNATEPART = lineitems[2];
                        item.VENDORCODE = lineitems[3];
                        item.PERCENTAGE = lineitems[4];
                        item.STARTDATE = lineitems[5];
                        item.ENDDATE = lineitems[6];
                        item.PLANNERCODE = lineitems[7];
                        item.FLAG = lineitems[8];
                        list.Add(item);
                      
                    }

                }
                sr.Close();
                
            }
            return list;
        
        }
         

        public void Read() {

            List<Item> list = ReadCSV();
            if (list.Count > 0) {
                string result = VaildateSku(list);
                if (!string.IsNullOrEmpty(result)) {
                    MailClient.SendNoSKUAllocNotificationMail(result, _excelFile, "以下SKU没有找到主数据-请先维护好主数据后再重新导入");
                    return;
                }


                using (SqlConnection conn = new SqlConnection(_connectionstring))
                {
                    conn.Open();

                    SqlTransaction trx = conn.BeginTransaction();
                    try
                    {

                        foreach (Item item in list)
                        {

                            string site = item.SITE;
                            if (site == null || string.IsNullOrEmpty(site.ToString()))
                            {
                                continue;
                            }

                            #region sqlcmd
                            SqlCommand cmd = conn.CreateCommand();
                            cmd.Transaction = trx;
                            cmd.CommandText = string.Format(@"INSERT INTO [{0}].[STXALLOCATION]
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

                                , _warehouse
                                , item.PLANNERCODE
                                , item.SITE
                                , GetAllocType(_excelFile)
                                , item.PRIMEPART
                                , item.ALTERNATEPART
                                , item.VENDORCODE
                                , item.FLAG
                                , item.PERCENTAGE
                                , item.STARTDATE
                                , item.ENDDATE
                                , DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                                , _warehouse
                                , ""
                                , _fileName
                                );
                            Console.WriteLine("reading....." + item.ToString());
                            #endregion
                            //Site	Prime Part	Alternate Part	Vendor Number	Allocation Percentage	Start Date Active	End Date Active	Planner Code	Non ASIC Indicator
                            cmd.ExecuteNonQuery();
                        }
                        trx.Commit();
                        conn.Close();


                        MailClient.SendAllocNotificationMail(list, _excelFile, string.Empty);
                    }
                    catch (Exception e)
                    {
                        MailClient.SendAllocNotificationMail(list, _excelFile, e.Message);
                        Console.WriteLine(e);
                        trx.Rollback();
                        conn.Close();
                    }
                }



            
            }



//            using (FileStream stream = File.Open(_excelFile, FileMode.Open, FileAccess.Read)) {
//                IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
//                excelReader.IsFirstRowAsColumnNames = true;
//                DataSet result = excelReader.AsDataSet();
//                DataTable dt = null;
//                excelReader.Close();
//                stream.Close();
//                if (result.Tables.Count > 0 && result.Tables[0].Rows.Count>0)
//                {
//                    try
//                    {
//                        //DataTable notsku = VaildateTable(result.Tables[0]);
//                        //if (notsku.Rows.Count > 0)
//                        //{
//                        //    MailClient.SendNoSKUAllocNotificationMail(notsku, _excelFile, "以下SKU没有找到主数据-请先维护好主数据后再重新导入");

//                        //    return;
//                        //}
//                    }
//                    catch (Exception e)
//                    {
//                        Console.WriteLine(e);
//                    }
//                    using (SqlConnection conn = new SqlConnection(_connectionstring))
//                    {
//                        conn.Open();
                       
//                        SqlTransaction trx = conn.BeginTransaction();
//                        try
//                        {
//                             dt = result.Tables[0];
//                            foreach (DataRow dr in dt.Rows)
//                            {

//                                object site = dr["Site"];
//                                if (site == null || string.IsNullOrEmpty(site.ToString()))
//                                {
//                                    continue;
//                                }

//                                #region sqlcmd
//                                SqlCommand cmd = conn.CreateCommand();
//                                cmd.Transaction = trx;
//                                cmd.CommandText =string.Format(@"INSERT INTO [{0}].[STXALLOCATION]
//                                                    ([WHSEID]
//                                                    ,[PLANNERCODE]
//                                                    ,[STXAGRP]
//                                                    ,[SITE]
//                                                    ,[TYPE]
//                                                    ,[PRISKU]
//                                                    ,[SKU]
//                                                    ,[STORERKEY]
//                                                    ,[COMMODITYCLASS]
//                                                    ,[ALLQTY]
//                                                    ,[STARTDATE]
//                                                    ,[ENDDATE]
//                                                    ,[ADDDATE]
//                                                    ,[ADDWHO]
//                                                    ,[NOTES])
//                                                    VALUES
//                                                          ('{0}'
//                                                          ,'{1}'
//                                                          ,'{14}'
//                                                          ,'{2}'
//                                                          ,'{3}'
//                                                          ,'{4}'
//                                                          ,'{5}'
//                                                          ,'{6}'
//                                                          ,'{7}'
//                                                          ,'{8}'
//                                                          ,'{9}'
//                                                          ,'{10}'
//                                                          ,'{11}'
//                                                          ,'{12}'
//                                                          ,'{13}')"

//                                    , _warehouse
//                                    , dr["Planner Code"]
//                                    , dr["SITE"]
//                                    , GetAllocType(_excelFile)
//                                    , dr["Prime Part"]
//                                    , dr["Alternate Part"]
//                                    , dr["Vendor Number"]
//                                    , dr["Non ASIC Indicator"]
//                                    , dr["Allocation Percentage"]
//                                    , dr["Start Date Active"]
//                                    , dr["End Date Active"]
//                                    , DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
//                                    , _warehouse
//                                    , ""
//                                    , _fileName
//                                    );
//                                Console.WriteLine("reading....." + dr["Planner Code"].ToString());
//                                #endregion
//                                //Site	Prime Part	Alternate Part	Vendor Number	Allocation Percentage	Start Date Active	End Date Active	Planner Code	Non ASIC Indicator
//                                cmd.ExecuteNonQuery();
//                            }
//                            trx.Commit();
//                            conn.Close();


//                            MailClient.SendAllocNotificationMail(dt, _excelFile,string.Empty);
//                        }
//                        catch (Exception e)
//                        {
//                            MailClient.SendAllocNotificationMail(dt, _excelFile, e.Message);
//                            Console.WriteLine(e);
//                            trx.Rollback();
//                            conn.Close();
//                        }
//                    }
//                }


//            }

        }

        private string VaildateSku(List<Item> list)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Item item in list)
            {

                if (!VaildationSKU(item.ALTERNATEPART, item.VENDORCODE))
                {
                    sb.Append(string.Format("SKU:{0} STORE:{1} 主数据没有维护<br>", item.ALTERNATEPART, item.VENDORCODE));
                }
            }
            return sb.ToString();
        }



        private DataTable VaildateTable(DataTable datatable)
        {
            DataTable dt = new DataTable();
            foreach (DataColumn cl in datatable.Columns)
            {
                dt.Columns.Add(cl.ColumnName);
            }
            foreach (DataRow dr in datatable.Rows)
            {
                
                    if (!VaildationSKU(dr["Alternate Part"].ToString(), dr["Vendor Number"].ToString()))
                                {
                                    dt.ImportRow(dr);
                                    Console.WriteLine(dr["Alternate Part"].ToString(), dr["Vendor Number"].ToString());
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
                cmd.CommandText = string.Format("SELECT COUNT(*) FROM [{2}].SKU WHERE SKU=N'{0}' AND STORERKEY=N'{1}' ", sku,store,_warehouse);
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
                cmd.CommandText = string.Format(" Select * FROM [{1}].[STXALLOCATION] where STXAGRP = N'{0}'",filename,_warehouse);
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
                cmd.CommandText = string.Format(@"INSERT INTO [{14}].[STXALLOCATION_RPT]
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
           , _warehouse
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
           ,_warehouse
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
                cmd.CommandText = string.Format("select count(*) from [{4}].[STXALLOCATION_RPT] r where   r.PRISKU='{0}' and r.sku='{1}' and r.FISCALYEAR='{2}' and r.QUARTER='{3}' ",
                    psku, sku, calendar.Year, calendar.Quarter,_warehouse);

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
                cmd.CommandText = string.Format("select isnull(sum(WALLACTUALQTY),0)  from [{3}].[STXALLOCATION_RPT] r where     r.PRISKU='{0}' and r.FISCALYEAR='{1}' and r.QUARTER='{2}' ", 
                    psku,calendar.Year,calendar.Quarter,_warehouse);
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
                cmd.CommandText = string.Format("  select Top 1 FISCALYEAR,QUARTER,WEEK from [{2}].[STXCALENDAR] where CONVERT(datetime,FROM_DATE) >= CONVERT(datetime,'{0}') and CONVERT(datetime,TO_DATE)<=CONVERT(datetime,'{1}')",
                    startdt,enddt,_warehouse);

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
                cmd.CommandText = string.Format("select max(WEEK) from  [{2}].[STXCALENDAR] where FISCALYEAR='{0}' and QUARTER='{1}'",
                    year, quarter,_warehouse);

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
                cmd.CommandText = string.Format("select max(WEEK) from  [{1}].[STXCALENDAR] where FISCALYEAR='{0}'",
                    year, _warehouse);

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
                cmd.CommandText = string.Format("select min(r.[week]) from  [{2}].[STXCALENDAR] r where r.FISCALYEAR='{0}' and r.[QUARTER]='{1}'",
                    year, quarter,_warehouse);

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
                cmd.CommandText = string.Format("select max(convert(int,stxakey)) + 1 from [{0}].[STXALLOCATION_RPT]",_warehouse
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
