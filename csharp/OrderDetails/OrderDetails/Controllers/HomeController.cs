using Microsoft.AspNetCore.Mvc;
using OrderDetails.Models;
using System.Diagnostics;

namespace OrderDetails.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(order o)
        {
            double result = 0;
            ViewBag.orderno = o.orderno;
            ViewBag.custname = o.custname;

            var selectedvalue = o.getname;
            ViewBag.getname= selectedvalue.ToString();
            ViewBag.price = o.price;
            ViewBag.quantity=o.quantity;

            result=ViewBag.price*ViewBag.quantity;  
            ViewBag.result= result; 
            return View();
            

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}