using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantWebApplication3.Repositories
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }

        public int PaymentTypeId { get; set; }

        public int CustomerId { get; set; }

        public string Ordernumber { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal FinalTotal { get; set; }
        public IEnumerable<OrderDetailViewModel> IsOfOrderDetailViewModel { get; set; }

    }
}