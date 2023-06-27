using Microsoft.AspNetCore.Mvc;
using productlistmvc.Models;

namespace productlistmvc.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // -wap to accept empname, basic salary and designation
        //and display bonus = 10000 for manager , 5000 for clerk and 1000 for peon
        //and also display total salary
        [HttpPost]
      public IActionResult Index(Class k)
        { 
            ViewBag.empname=k.empname;
            ViewBag.salary = k.salary;
            ViewBag.designation = k.designation;
            //ViewBag.bonus=k.bonus;  
            if(k.designation=="Manager")
            {
                k.bonus = 10000;
                k.totalsalary = k.salary+k.bonus;   
            }
            else if (k.designation == "Clerk")
            {
                k.bonus =5000;
                k.totalsalary = k.salary + k.bonus;

            }
            else if (k.designation == "Peon")
            {
                k.bonus = 1000;
                k.totalsalary = k.salary + k.bonus;

            }
            else
            {
                "Invalid Designation".ToString();
            }
            ViewBag.bonus = k.bonus;
            ViewBag.totalsalary = k.totalsalary;        


            return View();


        }
    }
}
