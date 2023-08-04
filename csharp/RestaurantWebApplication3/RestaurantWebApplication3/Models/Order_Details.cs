namespace RestaurantWebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("order2.Order_Details")]
    public partial class Order_Details
    {
        [Key]
        public int OrderDetailId { get; set; }

        public int? OrderId { get; set; }

        public int? ItemID { get; set; }

        public decimal? UnitPrice { get; set; }

        public decimal? Discount { get; set; }

        public decimal? Total { get; set; }

        public decimal? Quantity { get; set; }

        public virtual Order Order { get; set; }
    }
}
