using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EcartApplication.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tbl_admin> tbl_admin { get; set; }
        public virtual DbSet<tbl_Categorry1> tbl_Categorry1 { get; set; }
        public virtual DbSet<tbl_Product> tbl_Product { get; set; }
        public virtual DbSet<tbl_user> tbl_user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbl_admin>()
                .Property(e => e.AdminUsername)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_admin>()
                .Property(e => e.AdminPassword)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_admin>()
                .HasMany(e => e.tbl_Categorry1)
                .WithOptional(e => e.tbl_admin)
                .HasForeignKey(e => e.Category_admin);

            modelBuilder.Entity<tbl_Categorry1>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Categorry1>()
                .Property(e => e.CategoryImage)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_user>()
                .HasMany(e => e.tbl_Product)
                .WithOptional(e => e.tbl_user)
                .HasForeignKey(e => e.product_fk_user);
        }
    }
}
