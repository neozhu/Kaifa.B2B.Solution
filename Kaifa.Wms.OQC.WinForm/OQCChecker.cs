using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Kaifa.Wms.OQC.WinForm
{
    class OQCChecker
    {
        private string _connectionstring;
        public OQCChecker(string connectionstring)
        {
            _connectionstring = connectionstring;
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

        public DataTable GetOQCResult(string orderkey,string dropid,bool onlydiff) {
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                string sqltxt = string.Format(@"SELECT ORDERKEY ,STORERKEY,SKU,QTY,CHECKEDQTY,DIFFQTY,DROPID FROM [WMWHSE1].OQC WHERE ORDERKEY='{0}'", orderkey);
                if(!string.IsNullOrEmpty(dropid)){
                    sqltxt +=string.Format(" AND DROPID='{0}'",dropid);
                }
                if(onlydiff){
                     sqltxt +=string.Format(" AND DIFFQTY<>0 ");
                }
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
                string sqltxt = string.Format(@"SELECT SERIALKEY ,STORERKEY,SKU,CHECKQTY,DROPID,Q2CODE,ORDERKEY FROM [WMWHSE1].ORDERSHIPREVIEW WHERE ORDERKEY='{0}' ", orderkey);
                if (!string.IsNullOrEmpty(dropid))
                {
                    sqltxt += string.Format(" AND DROPID='{0}' ", dropid);
                }
               
                cmd.CommandText = sqltxt + " ORDER BY SERIALKEY ";
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
        public int GetSumCheckedQtyByDropId(string orderkey,string dropid)
        {
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format(@"select isnull(sum(isnull(checkQty,0)),0) from [wmwhse1].ordershipreview where orderkey='{0}' and dropid='{1}'", orderkey,dropid);
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
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format(@"select count(*) from [wmwhse1].pickdetail where orderkey='{0}' and  status in(5,8) and dropid='{1}' and sku='{2}' and storerkey='{3}'", orderkey, dropid,sku,storer);
                object result = cmd.ExecuteScalar();
                conn.Close();
                return Convert.ToBoolean(result);
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
         
        public void insertLog(string orderkey,string dropid,string storerkey,string sku,int checkqty,string qrcode)
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
            ,qrcode
            ,checkqty
            ,storerkey
            ,sku
            ,dropid
            ,checkqty);
                cmd.ExecuteNonQuery();
                conn.Close();
                
            }
        }


        public void PlayAlarm()
        {

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.ALARM5);
  
            player.Play();
        }


    }

     
}
