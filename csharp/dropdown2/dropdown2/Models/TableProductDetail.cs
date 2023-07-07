namespace dropdown2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TableProductDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int productcategoryid { get; set; }

        [StringLength(30)]
        public string Product_type_Name { get; set; }

        public int? productid { get; set; }

        public virtual TableProduct TableProduct { get; set; }
    }
}
