using mvcprojecct_practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcprojecct_practice.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            ViewBag.ItemList = "Employee Details";
            EmployeeDBHandler handler = new EmployeeDBHandler();
            ModelState.Clear();
            return View(handler.GetEmployees());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();  

        }
        [HttpPost]
        public ActionResult Create(EmployeeModel model) 
        
        {
            if(ModelState.IsValid)
            {
                EmployeeDBHandler modelHandler = new EmployeeDBHandler();
                if(modelHandler.insertemployee(model))
                {
                    ViewBag.message = "Insert successfully";
                    ModelState.Clear();
                    RedirectToAction("Index");  
                }
                else
                {
                    return View("Error");
                }

            }
            return View();

        }
    }
}