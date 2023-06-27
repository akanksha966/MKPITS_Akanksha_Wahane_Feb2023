using Microsoft.AspNetCore.Mvc;
using radiobutton.Models;

namespace radiobutton.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Class s)
        {
            ViewBag.empname = s.empname;
            ViewBag.salary=s.salary;
            ViewBag.result = null;
            ViewBag.final = null;
           
            if(s.hra==true)
            {
                ViewBag.result1 = s.salary * 0.25;
            }
            if (s.da == true)
            {
                ViewBag.result2 = s.salary * 0.45;
            }
            if (s.ta== true)
            {
                ViewBag.result3 = s.salary * 0.15;
            }
            ViewBag.final=ViewBag.salary+ViewBag.result1+ViewBag.result2+ViewBag.result3;
            return View();  


        }
    }
}
