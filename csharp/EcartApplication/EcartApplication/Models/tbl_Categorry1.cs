namespace EcartApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Categorry1
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(600)]
        public string CategoryName { get; set; }

        [Required]
        public string CategoryImage { get; set; }

        public int? Category_admin { get; set; }

        public int? Category_Status { get; set; }

        public virtual tbl_admin tbl_admin { get; set; }
    }
}
