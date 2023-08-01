namespace WebAppEcart.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    [Table("Item")]
    public partial class Item
    {
        public Guid ItemId { get; set; }

        public int? CategoryId { get; set; }

        [StringLength(400)]
        public string ItemCode { get; set; }

        [StringLength(400)]
        public string ItemName { get; set; }

        [StringLength(400)]
        public string Description { get; set; }

        [StringLength(400)]
        public string ImagePath { get; set; }

        public IEnumerable<SelectListItem> CategorySelectListItem { get; set; }

        public decimal? ItemPrice { get; set; }
    }
}
