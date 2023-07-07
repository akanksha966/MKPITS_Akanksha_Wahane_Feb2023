using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace dropdown2.Models
{
    public partial class ProductDetails : DbContext
    {
        public ProductDetails()
            : base("name=ProductDetails")
        {
        }

        public virtual DbSet<TableProduct> TableProducts { get; set; }
        public virtual DbSet<TableProductDetail> TableProductDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TableProduct>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<TableProductDetail>()
                .Property(e => e.Product_type_Name)
                .IsUnicode(false);
        }
    }
}
