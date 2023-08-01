using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShopCart.Models;



namespace OnlineShopCart.Controllers
{
    public class ItemController : Controller
    {

        private ECartDBModel model;
        public ItemController()
        {
            model = new ECartDBModel();


        }
        // GET: Item
        public ActionResult Index(SelectListItem selectListItem)
        {
            Item item = new Item();
            item.CategorySelectListItem=(from objcat in model.Categories select new SelectListItem()

            {
                Text = objcat.CategoryName,
                Value = objcat.CategoryId.ToString(),
                Selected = true

            } );

            return View( item );
                                         
                                         

        }
    }
}