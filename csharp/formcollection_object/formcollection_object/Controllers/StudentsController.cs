using formcollection_object.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace formcollection_object.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult submit(FormCollection fc)
        {
            ViewBag.Id = fc["Id"];
            ViewBag.Name = fc["Name"];
            bool gender = Convert.ToBoolean(fc["gender"].Split(',')[0]);
            ViewBag.gender = gender;

            return View("Index");

        }
    }
}