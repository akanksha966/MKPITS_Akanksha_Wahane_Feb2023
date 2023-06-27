using create_textbox.Models;
using Microsoft.AspNetCore.Mvc;

namespace create_textbox.Controllers
{
    public class FinalResultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       // [HttpPost]
        public IActionResult Result(Percentage k)
        {
            ViewBag.num1 = k.num1;
            ViewBag.num2 = k.num2;
            ViewBag.num3 = k.num3;
            //ViewBag.percent = k.percentage;
           // ViewBag.grade=k.grade;




            k.total = k.num1 + k.num2 + k.num3;
           // ViewBag.total=k.total;
            
            k.percentage = (k.total / 300.0f) * 100.0f;
           ViewBag.total=k.total;
           ViewBag.percentage = k.percentage;

            if (k.percentage < 90)
            {

                k.grade = "Distinction";
            }
            else if (k.percentage < 75)
            {
                k.grade = "Pass";
            }
            else
            {
                k.grade = "Fail";
            }
            ViewBag.grade = k.grade;


            return View();
        }
    }
}
