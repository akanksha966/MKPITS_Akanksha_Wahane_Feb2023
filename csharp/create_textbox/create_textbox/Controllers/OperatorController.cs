using create_textbox.Models;
using Microsoft.AspNetCore.Mvc;

namespace create_textbox.Controllers
{
    public class OperatorController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ope k)
        {
            ViewBag.result = k.result;

            ViewBag.num1 = k.num1;
            ViewBag.num2 = k.num2;
            char op;
           
            if (k.op=='+')
            {
                ViewBag.result = k.num1 + k.num2;
            }

            else if (k.op == '-')
            {
                ViewBag.result = k.num1 - k.num2;
            }

            else if (k.op == '*')
            {
                ViewBag.result = k.num1 * k.num2;
            }
           



            return View();  


        }


    }
}

