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
    }
}