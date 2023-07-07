using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace dropdownmvc.Models
{
    public partial class DataModel : DbContext
    {
        public DataModel(): base("name=DataModel")
        {
        }

        public virtual DbSet<Citytable> Citytables { get; set; }
        public virtual DbSet<Statetable> Statetables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Citytable>()
                .Property(e => e.cityname)
                .IsUnicode(false);

            modelBuilder.Entity<Statetable>()
                .Property(e => e.statename)
                .IsUnicode(false);
        }
    }
}
