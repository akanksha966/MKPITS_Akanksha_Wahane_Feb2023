using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantWebApplication3.Repositories
{
    public class OrderDetailViewModel
    {
        public int OrderDetailId { get; set; }

        public int OrderId { get; set; }

        public int ItemID { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal Discount { get; set; }

        public decimal Total { get; set; }

        public decimal Quantity { get; set; }

    }
}