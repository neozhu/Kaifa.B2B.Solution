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
        public async Task<List<TransactionWeekSummaryModel>> GetWeekSummary()
        {
            using (SqlConnection db = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["wmsConnection"].ConnectionString))
            {
                await db.OpenAsync();
                SqlCommand command = db.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from wmwhse1.v_TransactionWeekSummary";
                SqlDataReader reader = await command.ExecuteReaderAsync();
                List<TransactionWeekSummaryModel> list = new List<TransactionWeekSummaryModel>();

                while (await reader.ReadAsync())
                {
                   
                    if (!await reader.IsDBNullAsync(0))
                    {
                         TransactionWeekSummaryModel item = new TransactionWeekSummaryModel();
                        item.Week = reader[0].ToString() + " W" + reader[1].ToString();
                        item.ReceiptQty = Convert.ToInt32(reader[2]);
                        item.ShippedQty = Convert.ToInt32(reader[3]);
                        list.Add(item);
                    }
                }

                db.Close();
                return list;
            }
        }

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

                    if (Convert.ToInt32(reader["status"]) == 95)
                    {
                        ordercount.Shipped += Convert.ToInt32(reader["count"]);
                    }
                }
                db.Close();
                return ordercount;

            }
        }
    }
}