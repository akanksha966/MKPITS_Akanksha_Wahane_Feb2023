using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantWebApplication3.ViewModel
{
    public class ItemViewModel
    {

        public int ItemId { get; set; }

        
        public string ItemName { get; set; }

        public decimal ItemPrice { get; set; }
    }
}