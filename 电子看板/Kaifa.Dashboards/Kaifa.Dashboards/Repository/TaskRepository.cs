using Kaifa.Dashboards.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Kaifa.Dashboards.Repository
{
    public class TaskRepository
    {
        public async Task<List<TaskViewModels>> Get()
        {
            using (SqlConnection db = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["wmsConnection"].ConnectionString))
            {
                await db.OpenAsync();
                SqlCommand command = db.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from wmwhse1.taskdetail where status <>'9' and tasktype='PK' ";
                SqlDataReader reader = await command.ExecuteReaderAsync();
                List<TaskViewModels> list = new List<TaskViewModels>();
                while (await reader.ReadAsync())
                {
                    TaskViewModels item = new TaskViewModels();
                    list.Add(item);

                    item.TaskKey = reader["TASKDETAILKEY"].ToString();
                    item.OrderKey = reader["ORDERKEY"].ToString();
                    item.Owner = reader["USERKEY"].ToString();
                    item.Qty = Convert.ToInt32(reader["QTY"]);
                    item.Sku = reader["SKU"].ToString();
                    item.Status = reader["STATUS"].ToString();
                    item.Store = reader["STORERKEY"].ToString();

                }
                db.Close();
                return list;
            }
        }
    }
}