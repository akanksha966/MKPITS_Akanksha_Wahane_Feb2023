using create_textbox.Models;
using Microsoft.AspNetCore.Mvc;

namespace create_textbox.Controllers
{
    public class AdditionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(addition k)
        {
           ViewBag.num1=k.num1;
            ViewBag.num2=k.num2;
            if(k.op=='+')
            {
                ViewBag.result = k.num1+k.num2;

            }
            else
            {
                ViewBag.result = "Invalid operator";
            }
            return View();
        }
    }
}
