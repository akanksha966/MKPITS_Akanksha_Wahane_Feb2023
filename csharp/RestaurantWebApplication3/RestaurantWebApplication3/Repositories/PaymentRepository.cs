using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestaurantWebApplication3.Models;

namespace RestaurantWebApplication3.Repositories
{
    public class PaymentRepository
    {
        private RestaurantModel1 model1;
        public PaymentRepository()
        {
            model1 = new RestaurantModel1();
        }
        public IEnumerable<SelectListItem> obj()
        {
            var obj = new List<SelectListItem>();
            obj=(from a in model1.PaymentTypes select new SelectListItem()
            {
                Text=a.PaymentTypeName,
                Value=a.PaymentTypeId.ToString(),
                Selected=true
            }).ToList();
            return obj;
        }
    }
}