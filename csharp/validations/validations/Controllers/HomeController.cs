using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using validations.Models;

namespace validations.Controllers
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
        public IActionResult StudentDetails(StudentModel Sm)
        {
           if(string.IsNullOrEmpty(Sm.Name))
            {
                ModelState.AddModelError("Name", "Name required");
            }
           if(Sm.Age==0||Sm.Age>120)
            {
                ModelState.AddModelError("Age", "please enter valid age between 1-120");
            }
           if(ModelState.IsValid)
            {
                ViewBag.name = Sm.Name;
                ViewBag.age = Sm.Age;
                return View("Index");
            }
            else
            {
                ViewBag.name = "No Data";
                ViewBag.age = "No Data";
                return View("Index");
            }

        }
        public IActionResult Result(usermodel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.name = model.Name;
                ViewBag.age = model.Age;
                ViewBag.email=model.Email;
                ViewBag.conemail = model.ConfirmEmail;
                return View("Result");
            }
            else
            {
                ViewBag.name = "No Data";
                ViewBag.age = "No Data";
                ViewBag.email = "No Data";
                ViewBag.conemail = "No Data";
                return View("Result");
            }
        }
        public IActionResult User(user user)
        {
            ViewBag.username = user.UserName;
            ViewBag.MobileNo = user.MobileNumber;
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