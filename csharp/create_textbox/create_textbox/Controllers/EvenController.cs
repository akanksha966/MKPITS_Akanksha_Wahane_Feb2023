using create_textbox.Models;
using Microsoft.AspNetCore.Mvc;

namespace create_textbox.Controllers
{
    public class EvenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(EvenOdd s)
        {
            ViewBag.number = s.number;
            if(s.number%2==0)
            {
                ViewBag.result = "even";
            }
            else
            {
                ViewBag.result= "odd";
            }
                return View();

            
        }
    }
}
