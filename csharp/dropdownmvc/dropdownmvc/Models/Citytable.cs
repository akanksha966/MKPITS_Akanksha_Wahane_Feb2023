namespace dropdownmvc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Citytable")]
    public partial class Citytable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Cityid { get; set; }

        [StringLength(30)]
        public string cityname { get; set; }

        public int? stateid { get; set; }

        public virtual Statetable Statetable { get; set; }
    }
}
