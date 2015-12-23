using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kaifa.Dashboards.Models
{
    public class OrderCountViewModels
    {
        public int New { get; set; }
        public int Picking { get; set; }
        public int Loaded { get; set; }
        public int Shipped { get; set; }
    }
}