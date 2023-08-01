namespace OnlineShopCart.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Category
    {
        public int CategoryId { get; set; }

        [StringLength(400)]
        public string CategoryCode { get; set; }

        [StringLength(400)]
        public string CategoryName { get; set; }
    }
}
