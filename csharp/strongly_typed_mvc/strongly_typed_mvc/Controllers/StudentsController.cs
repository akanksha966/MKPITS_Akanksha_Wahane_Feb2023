using strongly_typed_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace strongly_typed_mvc.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult form1(Student s)
        {
            ViewBag.id = s.Id;
            ViewBag.name = s.Name;  
            return View("Index");
        }
    }
}