using Microsoft.AspNetCore.Mvc;
using radiobutton.Models;

namespace radiobutton.Controllers
{
    public class SignupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(sign sign)
        {
            ViewBag.username = sign.username;
            ViewBag.password=sign.password;
            ViewBag.email=sign.email;
            ViewBag.gender=sign.gender;
           
            ViewBag.subject1 = null;
            ViewBag.subject2 = null;

            if (sign.subject1==true)
            {
                ViewBag.subject1 = "Dotnet";
            }
            if (sign.subject2 == true)
            {
                ViewBag.subject2 = "Java";
            }
            return View();  



        }
    }
}
