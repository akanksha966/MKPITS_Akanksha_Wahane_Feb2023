using Microsoft.AspNetCore.Mvc;
using radiobutton.Models;

namespace radiobutton.Controllers
{
    public class CalculateerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(user u)
        {
            ViewBag.number1 = u.number1;
            ViewBag.number2 = u.number2;
            string c = u.caltype;
            int result = 0;
            if(c=="add")
            {
                result=u.number1+u.number2;
            }

            if (c == "sub")
            {
                result = u.number1 - u.number2;
            }
            if (c == "mult")
            {
                result = u.number1 * u.number2;
            }
            ViewBag.res=result;
            return View();

        }
    }
}
