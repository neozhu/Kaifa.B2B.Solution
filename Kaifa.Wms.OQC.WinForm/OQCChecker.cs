using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using NPOI.HSSF.UserModel;
using System.IO;
using NPOI;
using NPOI.HPSF;
using NPOI.HSSF;
using NPOI.HSSF.UserModel;
using NPOI.POIFS;
using NPOI.Util;

namespace Kaifa.Wms.OQC.WinForm
{
    public class BlackItem {
        public string Vendor { get; set; }
        public string Sku { get; set; }
        public string Als { get; set; }
        public string LotNo { get; set; }
        public string DateCode { get; set; }
        public string TraceCode { get; set; }
        public string Reason { get; set; }
    }

    class OQCChecker
    {
        private List<BlackItem> _backList;
        public List<BlackItem> BackList {

            get { 
                if(_backList==null){
                    
                _backList= GetBlackList();
                    return _backList;
                }else{
                return  _backList;
                }
            }
        }

        public bool ValidateBackList(string Vendor, string sku, string Als, string LotNo, string DateCode, string TraceCode)
        {
            bool val = false;
            foreach (BlackItem item in BackList.Where(x=>x.Vendor==Vendor && x.Sku==sku)) {
                if (!string.IsNullOrEmpty(item.Als) && !string.IsNullOrEmpty(Als))
                {
                    if (Als.Contains(item.Als))
                        return true;
                }
                if (!string.IsNullOrEmpty(item.LotNo) && !string.IsNullOrEmpty(LotNo))
                {
                    if (LotNo.Contains(item.Als))
                        return true;
                }
                if (!string.IsNullOrEmpty(item.DateCode) && !string.IsNullOrEmpty(DateCode))
                {
                    if (DateCode.Contains(item.DateCode))
                        return true;

                    string[] dstr = item.DateCode.Split(new char[] { ',', '，', ';' });
                    if (dstr.Length > 1) {
                        if (dstr.Contains(DateCode))
                        {
                            return true;
                        }
                    }
                    dstr = item.DateCode.Split(new char[] { '-' });
                    if (dstr.Length == 2)
                    {
                        int d1 = 0;
                        int d2 = 0;
                        int d3 = 0;
                        if( int.TryParse(dstr[0],out d1) && int.TryParse(dstr[1],out d2) && int.TryParse(DateCode,out d3))
                        if (d3>=d1 &&  d3 <=d2)
                        {
                            return true;
                        }
                    }

                }

                if (!string.IsNullOrEmpty(item.TraceCode) && !string.IsNullOrEmpty(TraceCode))
                {
                    if (TraceCode.Contains(item.TraceCode))
                        return true;
                     string[] dstr = item.TraceCode.Split(new char[] { ',', '，', ';','/','\\','|' });
                     if (dstr.Length > 1)
                     {
                         if (dstr.Contains(TraceCode))
                         {
                             return true;
                         }
                     }
                      
                }
            
            }
            return val;
        }

        public List<BlackItem> GetBlackList() {
            List<BlackItem> list = new List<BlackItem>();
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                string sqltxt = string.Format(@"SELECT T.VENDORNO,T.MATERIALNO,T.ASLCODE,T.LOTNO,T.DATECODE,T.TRACECODE,T.REASON FROM [WMWHSE1].[BLACKLIST] T WHERE T.STATUS=0");
                cmd.CommandText = sqltxt;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) {
                    BlackItem item = new BlackItem();
                    item.Vendor = reader.GetValue(0) == DBNull.Value?"":reader.GetString(0);
                    item.Sku = reader.GetValue(1) == DBNull.Value ? "" : reader.GetString(1);
                    item.Als = reader.GetValue(2) == DBNull.Value ? "" : reader.GetString(2);
                    item.LotNo = reader.GetValue(3) == DBNull.Value ? "" : reader.GetString(3);
                    item.DateCode = reader.GetValue(4) == DBNull.Value ? "" : reader.GetString(4);
                    item.TraceCode = reader.GetValue(5) == DBNull.Value ? "" : reader.GetString(5);
                    item.Reason = reader.GetValue(6) == DBNull.Value ? "" : reader.GetString(6);
                    list.Add(item);
                }
            }
            return list;
        }

        private string _connectionstring;
        private DataTable _cacheTable = null;
        public OQCChecker(string connectionstring)
        {
            _connectionstring = "Server=10.10.205.147;Database=SCPRD;User ID=sa;Password=Suwmsdb_2015;Trusted_Connection=False";
        }

        public DataTable GetOrderQty(string orderkey)
        {
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format(@"SELECT T2.ORDERKEY,T2.[STATUS],SUM(T1.OPENQTY) OPENQTY,SUM(T1.QTYPICKED) QTYPICKED FROM [WMWHSE1].[ORDERDETAIL] T1,[WMWHSE1].[ORDERS] T2  WHERE
                                                    T1.ORDERKEY=T2.ORDERKEY AND
                                                  T2.ORDERKEY='{0}' GROUP BY T2.ORDERKEY,T2.STATUS", orderkey);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);


                conn.Close();
                return ds.Tables[0];

            }
        }

        public void DelCheckLog(int Id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                string sqltxt = string.Format(@"delete from [wmwhse1].[ORDERSHIPREVIEW] where SERIALKEY={0}", Id);
                cmd.CommandText = sqltxt;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public DataTable GetOQCResult(string orderkey, string dropid, bool onlydiff)
        {
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                string sqltxt = string.Format(@"SELECT ORDERKEY ,STORERKEY,SKU,QTY,CHECKEDQTY,DIFFQTY,DROPID FROM [WMWHSE1].OQC WHERE ORDERKEY='{0}' ", orderkey);
                if (!string.IsNullOrEmpty(dropid))
                {
                    //sqltxt += string.Format(" AND DROPID='{0}'", dropid);
                }
                if (onlydiff)
                {
                    sqltxt += string.Format(" AND DIFFQTY<>0 ");
                }
                cmd.CommandText = sqltxt + "  order by CHECKEDQTY desc";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);


                conn.Close();
                return ds.Tables[0];

            }
        }
        public DataTable GetSKUPicking(string orderkey, string dd)
        {
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                string sqltxt = string.Format(@"select ROW_NUMBER() OVER(ORDER BY sku ) AS rownum ,* from wmwhse1.[OPICKING] where ORDERKEY='{0}'  ", orderkey);
                if (dd == "True")
                {
                    sqltxt += string.Format(" AND DIFFQTY<>0 ");
                }
                cmd.CommandText = sqltxt + "  order by order by sku ";

                cmd.CommandText = sqltxt;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);


                conn.Close();
                return ds.Tables[0];

            }
        }
        public DataTable GetCheckLog(string orderkey, string dropid)
        {
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                string sqltxt = string.Format(@"SELECT SERIALKEY ,STORERKEY,SKU,CHECKQTY,DROPID,Q2CODE,ORDERKEY FROM [WMWHSE1].ORDERSHIPREVIEW WHERE ORDERKEY='{0}'  ", orderkey);
                if (!string.IsNullOrEmpty(dropid))
                {
                    sqltxt += string.Format(" AND DROPID='{0}' ", dropid);
                }

                cmd.CommandText = sqltxt + " ORDER BY SERIALKEY desc";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);


                conn.Close();
                return ds.Tables[0];

            }
        }
        public int GetSumCheckedQty(string orderkey)
        {
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format(@"select isnull(sum(isnull(checkQty,0)),0) from [wmwhse1].ordershipreview where orderkey='{0}'", orderkey);
                object result = cmd.ExecuteScalar();
                conn.Close();
                return Convert.ToInt32(result);
            }
        }
        public int GetSumCheckedQtyByDropId(string orderkey, string dropid)
        {
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format(@"select isnull(sum(isnull(checkQty,0)),0) from [wmwhse1].ordershipreview where orderkey='{0}' and dropid='{1}'", orderkey, dropid);
                object result = cmd.ExecuteScalar();
                conn.Close();
                return Convert.ToInt32(result);
            }
        }

        public int GetSumPickedQtyByDropId(string orderkey, string dropid)
        {
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format(@"select isnull(sum(qty),0) from [wmwhse1].pickdetail where orderkey='{0}'  and status in(5,8) and dropid='{1}'", orderkey, dropid);
                object result = cmd.ExecuteScalar();
                conn.Close();
                return Convert.ToInt32(result);
            }
        }
        public bool checkingSku(string orderkey, string dropid, string storer, string sku)
        {
            if (this._cacheTable == null)
            {
                loadcacheTable(orderkey, dropid);
            }
            string filter = string.Format("ORDERKEY = '{0}' AND STORERKEY = '{1}' AND SKU = '{2}' ", orderkey, storer, sku );
            DataRow[] rows = this._cacheTable.Select(filter);
            if (rows.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

            //using (SqlConnection conn = new SqlConnection(_connectionstring))
            //{
            //    conn.Open();
            //    SqlCommand cmd = conn.CreateCommand();
            //    cmd.CommandText = string.Format(@"select count(*) from [wmwhse1].pickdetail where orderkey='{0}' and  status in(5,8) and dropid='{1}' and sku='{2}' and storerkey='{3}'", orderkey, dropid, sku, storer);
            //    object result = cmd.ExecuteScalar();
            //    conn.Close();
            //    return Convert.ToBoolean(result);
            //}
        }

        public void loadcacheTable(string orderkey, string dropid)
        {
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("SELECT ORDERKEY ,STORERKEY,SKU,DROPID FROM [WMWHSE1].OQC WHERE ORDERKEY='{0}'  ", orderkey);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                this._cacheTable = ds.Tables[0];

            }
        }

        public bool checkingOrderKey(string orderkey)
        {
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format(@"select count(*) from [wmwhse1].pickdetail where orderkey='{0}'    ", orderkey);
                object result = cmd.ExecuteScalar();
                conn.Close();
                return Convert.ToBoolean(result);
            }
        }
        public bool checkingDropId(string orderkey, string dropid)
        {
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format(@"select count(*) from [wmwhse1].pickdetail where orderkey='{0}' and  status in(5,8) and dropid='{1}' ", orderkey, dropid);
                object result = cmd.ExecuteScalar();
                conn.Close();
                return Convert.ToBoolean(result);
            }
        }

        public void insertLog(string orderkey, string dropid, string storerkey, string sku, int checkqty, string qrcode)
        {
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format(@"INSERT INTO [wmwhse1].[ORDERSHIPREVIEW]
           ([orderkey]
           ,[q2code]
           ,[qty]
           ,[storerkey]
           ,[sku]
           ,[dropid]
           ,[checkQty])
     VALUES
           ('{0}'
           ,'{1}'
           ,'{2}'
           ,'{3}'
           ,'{4}'
           ,'{5}'
           ,'{6}'
          )", orderkey
            , qrcode
            , checkqty
            , storerkey
            , sku
            , dropid
            , checkqty);
                cmd.ExecuteNonQuery();
                conn.Close();

            }
        }

        public void PlayNumSound(int num)
        {
            System.Media.SoundPlayer player;
            string numstr = num.ToString();
            foreach (char ch in numstr)
            {
                int i = Convert.ToInt32(ch) - 48;
                switch (i)
                {
                    case 0:
                        player = new System.Media.SoundPlayer(Properties.Resources._0);

                        player.Play();
                        break;
                    case 1:
                        player = new System.Media.SoundPlayer(Properties.Resources._1);

                        player.Play();
                        break;
                    case 2:
                        player = new System.Media.SoundPlayer(Properties.Resources._2);

                        player.Play();
                        break;
                    case 3:
                        player = new System.Media.SoundPlayer(Properties.Resources._3);

                        player.Play();
                        break;
                    case 4:
                        player = new System.Media.SoundPlayer(Properties.Resources._4);

                        player.Play();
                        break;
                    case 5:
                        player = new System.Media.SoundPlayer(Properties.Resources._5);

                        player.Play();
                        break;
                    case 6:
                        player = new System.Media.SoundPlayer(Properties.Resources._6);

                        player.Play();
                        break;
                    case 7:
                        player = new System.Media.SoundPlayer(Properties.Resources._7);

                        player.Play();
                        break;
                    case 8:
                        player = new System.Media.SoundPlayer(Properties.Resources._8);

                        player.Play();
                        break;
                    case 9:
                        player = new System.Media.SoundPlayer(Properties.Resources._9);

                        player.Play();
                        break;
                    default:

                        break;

                }
                System.Threading.Thread.Sleep(500);
            }
        }
        public void PlayAlarm()
        {

            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.ALARM5);

            //player.Play();
            System.Media.SystemSounds.Asterisk.Play();
        }
        public void PlayOK()
        {

            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.DRBELL);

            //player.Play();

            System.Media.SystemSounds.Question.Play();
        }


        private MemoryStream ExportDataSetToExcel(DataSet sourceDs, string sheetName)
        {
            HSSFWorkbook workbook = new HSSFWorkbook();
            MemoryStream ms = new MemoryStream();
            string[] sheetNames = sheetName.Split(',');
            for (int i = 0; i < sheetNames.Length; i++)
            {
                HSSFSheet sheet = (HSSFSheet)workbook.CreateSheet(sheetNames[i]);
                HSSFRow headerRow = (HSSFRow)sheet.CreateRow(0);
                // handling header.
                foreach (DataColumn column in sourceDs.Tables[i].Columns)
                    headerRow.CreateCell(column.Ordinal).SetCellValue(column.ColumnName);
                // handling value.
                int rowIndex = 1;
                foreach (DataRow row in sourceDs.Tables[i].Rows)
                {
                    HSSFRow dataRow = (HSSFRow)sheet.CreateRow(rowIndex);
                    foreach (DataColumn column in sourceDs.Tables[i].Columns)
                    {
                        dataRow.CreateCell(column.Ordinal).SetCellValue(row[column].ToString());
                    }
                    rowIndex++;
                }
            }
            workbook.Write(ms);
            ms.Flush();
            ms.Position = 0;
            workbook = null;
            return ms;
        }

        public MemoryStream ExportExcel(string orderkey)
        {
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("SELECT ORDERKEY as '订单号' ,STORERKEY as '货主',SKU,QTY as '订单数量',CHECKEDQTY as '复检数量',DIFFQTY as '差异数量',DROPID as '落放ID' FROM [WMWHSE1].OQC  WHERE ORDERKEY='{0}' ; SELECT SERIALKEY as 'ID' ,STORERKEY as '货主',SKU,CHECKQTY as '扫描数量',DROPID as '落放ID',Q2CODE as '二维码信息',ORDERKEY as '订单号' FROM [WMWHSE1].ORDERSHIPREVIEW WHERE ORDERKEY='{0}' ", orderkey);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);


                MemoryStream file = ExportDataSetToExcel(ds, "复检结果,扫描记录");

                return file;

            }
        }

    }


}
