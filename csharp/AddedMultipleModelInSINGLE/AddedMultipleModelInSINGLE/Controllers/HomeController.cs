using AddedMultipleModelInSINGLE.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AddedMultipleModelInSINGLE.Controllers;

namespace AddedMultipleModelInSINGLE.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()

        {   
            Teacher teacher = new Teacher();
            Student student = new Student();
            ViewBag.message = "Welcome to my demo!!";
            dynamic mymodel=new ExpandoObject();    
            mymodel.teachers= teacher.GetTeachers();
            mymodel.student= student.GetStudents();

            return View(mymodel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}