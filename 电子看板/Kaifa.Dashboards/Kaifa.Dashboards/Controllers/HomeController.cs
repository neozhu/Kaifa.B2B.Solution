using Kaifa.Dashboards.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Kaifa.Dashboards.Controllers
{
    public class HomeController : Controller
    {
        private OrderRepository orderRepository = null;
        private TaskRepository taskRepository = null;
        public HomeController()
        {
            orderRepository = new OrderRepository();
            taskRepository = new TaskRepository();
        }
        public async Task<ActionResult> Index()
        {
            var order = await orderRepository.GetCount();
            ViewBag.OrderCount = order;
            var tasks = await taskRepository.Get();
            return View(tasks );
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}