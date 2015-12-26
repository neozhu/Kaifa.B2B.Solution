using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kaifa.Dashboards.Models
{
    public class WeekSummaryViewModels
    {
    }

    public class TransactionWeekSummaryModel
    {
        public string Week { get; set; }
        public int ReceiptQty { get; set; }
        public int ShippedQty { get; set; }
    }
}