using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppEcart.Models;

namespace WebAppEcart.Controllers
{
    public class ItemController : Controller
    {
       private Model1 model;
        public ItemController() {
            model = new Model1();


        }
        // GET: Item
        public ActionResult Index()
        {
            Item item = new Item();
            item.CategorySelectListItem = (from objcat in model.Categories
                                           select new SelectListItem()
                                           {
                                               Text = objcat.CategoryName,
                                               Value = objcat.CategoryId.ToString(),
                                               Selected = true

                                           });
            return View(item);
        }
    }

    internal class from
    {
    }
}