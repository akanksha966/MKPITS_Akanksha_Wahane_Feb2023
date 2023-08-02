using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantWebApplication3.ViewModel
{
    public class PaymentViewModel
    {

        public int PaymentTypeId { get; set; }

        public string PaymentTypeName { get; set; }
    }
}