using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kaifa.Dashboards.Models
{
    public class TaskViewModels
    {
        public string TaskKey { get; set; }
        public DateTime StartTime { get; set; }
        public string OrderKey { get; set; }
        public string Owner { get; set; }
        public string Store { get; set; }
        public string Sku { get; set; }
        public int Qty { get; set; }
     
        public string Status { get; set; }
    }
}