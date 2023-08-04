namespace RestaurantWebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("order2.Transactions")]
    public partial class Transaction
    {
        public int TransactionId { get; set; }

        public int? ItemId { get; set; }

        public decimal? Quantity { get; set; }

        public DateTime? TransactionDate { get; set; }

        public int? TypeId { get; set; }
    }
}
