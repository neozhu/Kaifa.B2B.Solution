using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kaifa.Dashboards.Repository
{
    public class TaskRepository
    {
        public void Get()
        {
            using (SqlConnection db = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["wmsConnection"].ConnectionString))
            {
                await db.OpenAsync();
                SqlCommand command = db.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select status,count(*) count from wmwhse1.orders group by status";
                SqlDataReader reader = await command.ExecuteReaderAsync();
            }
    }
}