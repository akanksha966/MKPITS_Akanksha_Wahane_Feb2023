using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using using_View_Model.Models;

namespace using_View_Model.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Teacher teacher = new Teacher();
            Student student = new Student();
            ViewBag.message = "Welcome to my demo!!";
            ViewData["Teachers"] =teacher.GetTeachers();
            ViewData["Students"] =student.GetStudents();

            return View();
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