using checkbox.Models;
using Microsoft.AspNetCore.Mvc;

namespace checkbox.Controllers
{
    public class CalculateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Calculatemodel cal)
        {
            ViewBag.number1 = cal.number1;
            ViewBag.number2 = cal.number2;
            if(cal.add==true)
            {
                cal.result1=cal.number1 + cal.number2;
                ViewBag.result1 = cal.result1;
            }
            if (cal.sub == true)
            {
                cal.result2 = cal.number1 - cal.number2;
                ViewBag.result2 = cal.result2;
            }
            if (cal.multiply== true)
            {
                cal.result3 = cal.number1 * cal.number2;
                ViewBag.result3 = cal.result3;
            }
            return View();


        }
    }
}
