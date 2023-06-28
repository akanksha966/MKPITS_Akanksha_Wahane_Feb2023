using Microsoft.AspNetCore.Mvc;
using RedirectPage.Models;
using System.Diagnostics;


namespace RedirectPage.Controllers
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
        public IActionResult Index(IFormCollection f,usermodel model)
        {
            //storing the value of textbox in usermodel property
            if (ModelState.IsValid)
            {
                model.username = f["username"];
                return View(model);     
            }
            else
            {
                return View();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
           // return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
       // }
    }
}