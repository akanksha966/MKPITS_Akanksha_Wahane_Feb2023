using main_mvc_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace main_mvc_project.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Index()
        {
            ViewBag.ItemList = "Computer Shop Item List Page";
            ItemDBHandler handler = new ItemDBHandler();
            ModelState.Clear();
            return View(handler.getitemlist());
        }



        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ItemModel Ilist)
        {
            if (ModelState.IsValid)
            {
                ItemDBHandler db = new ItemDBHandler();
                if (db.InsertItem(Ilist))
                {
                    ViewBag.message = "Item Saved Successfully";
                    ModelState.Clear();
                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            //ItemDBHandler ItemHandler = new ItemDBHandler();
            //return View(ItemHandler.GetItemList().Find(itemmodel => itemmodel.ID == id));

            ItemDBHandler handler=new ItemDBHandler();
            return View(handler.getitemlist().Find(itemmodel=>itemmodel.ID==id));

        }
        [HttpPost]
        public ActionResult Edit( int id, ItemModel Ilist)
        {
            try
            {


                
                    ItemDBHandler itemDBHandler = new ItemDBHandler();
                   itemDBHandler.UpdateItem(Ilist);
                    
                        ViewBag.message = "updated succesffully";
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
            ItemDBHandler handler=new ItemDBHandler();
            return View(handler.getitemlist().Find(itemmodel=>itemmodel.ID == id));
        }
        [HttpPost]
        public ActionResult Delete(int id,ItemModel item)
        {
            try
            {
                ItemDBHandler itemDB = new ItemDBHandler();
                itemDB.DeleteItem(item);
                ViewBag.message = "delete successfully";
                return RedirectToAction("Index");
            }
            catch
            { 
                return View();
            }  

        }
        public ActionResult Details(int id)
        {
            ItemDBHandler handler= new ItemDBHandler();
            return View(handler.getitemlist().Find(itemmodel=>itemmodel.ID==id));
        }
    }
}