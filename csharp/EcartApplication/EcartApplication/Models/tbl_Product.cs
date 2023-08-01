namespace EcartApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [StringLength(500)]
        public string ProductName { get; set; }

        [Required]
        public string ProductImage { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        public int? ProductPrice { get; set; }

        public int? product_fk_user { get; set; }

        public int? product_fk_Category { get; set; }

        public virtual tbl_user tbl_user { get; set; }
    }
}
