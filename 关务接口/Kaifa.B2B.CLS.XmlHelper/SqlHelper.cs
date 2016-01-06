using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Kaifa.B2B.CLS.XmlHelper
{
    public class SqlHelper
    {
        public static void UpdateCLSStatus(string orderkey, string gatepassno)
        {
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["warehouse1"].ConnectionString))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    SqlCommand sqlcommand = conn.CreateCommand();

                    sqlcommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlcommand.Transaction = trans;

                    sqlcommand.CommandText = "[dbo].[[updateCLSStatus]]";
                    sqlcommand.Parameters.Add(new SqlParameter("@ERP_OBJECT_ID", orderkey));
                    sqlcommand.Parameters.Add(new SqlParameter("@GATEPASS_NO", gatepassno));
                      
                        sqlcommand.ExecuteNonQuery();
                 

                    trans.Commit();
                    conn.Close();
                }
                catch (Exception e)
                {
                    trans.Rollback();
                    conn.Close();
                }

            }
        }

        public static void Insert(List<DecModel> declist)
        {
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["warehouse1"].ConnectionString))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    SqlCommand sqlcommand = conn.CreateCommand();

                    sqlcommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlcommand.Transaction = trans;
                    foreach (DecModel item in declist)
                    {
                        sqlcommand.Parameters.Clear();
                        sqlcommand.CommandText = "[dbo].[insertHB_DEC]";
                        sqlcommand.Parameters.Add(new SqlParameter("@ENTRY_ID", item.EntryId));
                        sqlcommand.Parameters.Add(new SqlParameter("@COP_G_NO", item.GNo));
                        sqlcommand.Parameters.Add(new SqlParameter("@I_E_FLAG", item.IEFlag));
                        sqlcommand.Parameters.Add(new SqlParameter("@QTY", item.Qty));
                        sqlcommand.Parameters.Add(new SqlParameter("@SEQ_NO", item.SeqNo));
                        sqlcommand.ExecuteNonQuery();
                    }

                    trans.Commit();
                    conn.Close();
                }
                catch (Exception e)
                {
                    trans.Rollback();
                    conn.Close();
                }

            }
        }
    }
}
