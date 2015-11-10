using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace Kaifa.B2B.Utility
{
    public class SAPARReturnHelper
    {
        public const string CONNSTRING = "Server=10.10.205.37;Database=STEST;User ID=sa;Password=1;Trusted_Connection=False;";
        public static void Update(string batchid, string sapBKId, string msg)
        {
            using (SqlConnection conn = new SqlConnection(CONNSTRING)) { 
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "[billadmin].[ARReturnId]";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@WMSBATCHID", batchid));
                cmd.Parameters.Add(new SqlParameter("@SAPID", sapBKId));
                cmd.Parameters.Add(new SqlParameter("@msg", msg));
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
