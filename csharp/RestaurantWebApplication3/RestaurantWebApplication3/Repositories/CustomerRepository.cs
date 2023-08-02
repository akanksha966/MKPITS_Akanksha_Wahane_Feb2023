using RestaurantWebApplication3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantWebApplication3.Repositories
{
    public class CustomerRepository
    {

        private RestaurantModel1 model1;
        public CustomerRepository()
        {
            model1 = new RestaurantModel1();
        }


        public IEnumerable<SelectListItem> obj()
        {
            var obj = new List<SelectListItem>();
            obj = (from a in model1.Customers
                   select new SelectListItem()
                   {
                       Text = a.CustomerName,
                       Value = a.CustomerId.ToString(),
                       Selected = true
                   }).ToList();
            return obj;
        }
    }
}