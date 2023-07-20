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
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            ItemDbHandler ha= new ItemDbHandler();  
            return View(ha.GetItems().Find(model=>model.ID==Id));
            
        }
        [HttpPost]
        public ActionResult Edit(ItemModel model)
        {
            try
            {


                ItemDbHandler ha = new ItemDbHandler();
                ha.UpdateinsertModel(model);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult Delete(int Id)
        {
            ItemDbHandler ha=new ItemDbHandler();
           return View(ha.GetItems().Find(model=>model.ID==Id));   
        }
        [HttpPost]
        public ActionResult Delete(ItemModel model)
        {
            try
            {


                ItemDbHandler ha = new ItemDbHandler();
                ha.DeleteinsertModel(model);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }
        public ActionResult Details(int id)
        {
            ItemDbHandler itemDbHandler = new ItemDbHandler();
            return View (itemDbHandler.GetItems().Find(model=>model.ID==model.ID)); 

          
        }
    }
}