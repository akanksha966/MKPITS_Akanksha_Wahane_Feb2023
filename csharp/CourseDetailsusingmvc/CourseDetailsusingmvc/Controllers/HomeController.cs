using CourseDetailsusingmvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CourseDetailsusingmvc.Controllers
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
        public IActionResult Index(course c)
        {
            ViewBag.username = c.username;
            ViewBag.gender = c.gender;
            ViewBag.batch = null;
            if(c.batch1==true)
            {
                ViewBag.batch1 = "Java";
            }
            if (c.batch2 == true)
            {
                ViewBag.batch2 = "Dotnet";
            }
            var selectedvalue = c.getcity;
            ViewBag.getcity = selectedvalue.ToString();
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