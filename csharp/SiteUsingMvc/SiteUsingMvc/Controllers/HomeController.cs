using Microsoft.AspNetCore.Mvc;
using SiteUsingMvc.Models;
using System.Diagnostics;

namespace SiteUsingMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Courses()
        {
            return View();
        }

        public IActionResult Admission()
        {
            return View();
        }
        public IActionResult Job()
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