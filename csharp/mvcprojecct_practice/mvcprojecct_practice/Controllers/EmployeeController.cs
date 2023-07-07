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
                    return RedirectToAction("Index");  
                }
                else
                {
                    return View("Error");
                }

            }
            return View();

        }
        [HttpGet]
        public ActionResult Edit (int Id)
        {
            EmployeeDBHandler handler=new EmployeeDBHandler();  
           //return View(handler.GetEmployees().Find(model=>model.Id==Id));
            return View(handler.GetEmployees().Find(model => model.Id==Id));



        }
        [HttpPost]
        public ActionResult Edit (EmployeeModel model,int id)
        {
           try
            {
                EmployeeDBHandler handler = new EmployeeDBHandler();
                handler.updateemployee(model);
                return RedirectToAction("Index");
               
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            EmployeeDBHandler handler=new EmployeeDBHandler();
            return View(handler.GetEmployees().Find(model=>model.Id==id));
        }
        [HttpPost]
        public ActionResult Delete(EmployeeModel model,int id)//it is post method to click the button and go to the another page
        {
            try
            {
                EmployeeDBHandler handler = new EmployeeDBHandler();
                handler.deleteitem(model);
                return RedirectToAction("Index");

            }
            catch { return View(); }
          
        }
        public ActionResult Details(int id)
        {
            EmployeeDBHandler handler=new EmployeeDBHandler();
            return View(handler.GetEmployees().Find(model=>model.Id==id));
        }
    }
}