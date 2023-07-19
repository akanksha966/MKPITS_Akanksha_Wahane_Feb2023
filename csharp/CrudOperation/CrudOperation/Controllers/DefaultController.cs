using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrudOperation.Models;

namespace CrudOperation.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            ItemDbHandler itemDbHandler = new ItemDbHandler();
            return View (itemDbHandler.GetItems());
          
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();  

        }
        [HttpPost]  
        public ActionResult Create(ItemModel model)
        {
             if(ModelState.IsValid) { 

                ItemDbHandler dbHandler = new ItemDbHandler();      
                
                if(dbHandler.InsertItemModel(model)) {

                    ViewBag.Message = "insert successfully";
                    ModelState.Clear();
                   
                }
                else
                {
                    return View();
                }
             
            }
             return View();

                
        }
    }
}