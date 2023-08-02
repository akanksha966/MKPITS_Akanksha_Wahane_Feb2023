using RestaurantWebApplication3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantWebApplication3.Repositories
{
    public class ItemRepository
    {

        private RestaurantModel1 model1;
        public ItemRepository()
        {
            model1 = new RestaurantModel1();
        }


        public IEnumerable<SelectListItem> obj()
        {
            var obj = new List<SelectListItem>();
            obj = (from a in model1.Items
                   select new SelectListItem()
                   {
                       Text = a.ItemName,
                       Value = a.ItemId.ToString(),
                       Selected = false
                   }).ToList();
            return obj;
        }
    }
}