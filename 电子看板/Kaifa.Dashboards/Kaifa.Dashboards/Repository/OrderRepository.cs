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
    public class OrderRepository
    {

        public async Task<OrderCountViewModels> GetCount()
        {
            using (SqlConnection db = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["wmsConnection"].ConnectionString))
            {
                await db.OpenAsync();
                SqlCommand command = db.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select status,count(*) count from wmwhse1.orders group by status";
                SqlDataReader reader = await command.ExecuteReaderAsync();
                OrderCountViewModels ordercount = new OrderCountViewModels();

                while (await reader.ReadAsync())
                {
                    
                    if (reader.GetString(0) == "0")
                    {
                        ordercount.New += reader.GetInt32(1);
                    }
                    if (Convert.ToInt32(reader.GetString(0)) > 0 && Convert.ToInt32(reader.GetString(0)) < 88)
                    {
                        ordercount.Picking += reader.GetInt32(1);
                    }

                    if (Convert.ToInt32(reader.GetString(0)) ==88 && Convert.ToInt32(reader.GetString(0)) == 92)
                    {
                        ordercount.Loaded += reader.GetInt32(1);
                    }

                    if (Convert.ToInt32(reader.GetString(0)) ==95)
                    {
                        ordercount.Shipped += reader.GetInt32(1);
                    }
                }
                db.Close();
                return ordercount;

            }
        }
    }
}