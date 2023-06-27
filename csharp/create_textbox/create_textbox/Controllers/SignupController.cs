using create_textbox.Models;
using Microsoft.AspNetCore.Mvc;

namespace create_textbox.Controllers
{
    public class SignupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Index(Signup m)
        {
            ViewBag.username = m.username;
            ViewBag.password=m.password;
            return View();  
        }

    }
    
}
