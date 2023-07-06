namespace FirstDatabaseAutomaticallycodegeneratemodel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BookModel")]
    public partial class BookModel
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string BokkName { get; set; }

        [StringLength(50)]
        public string Price { get; set; }
    }
}
