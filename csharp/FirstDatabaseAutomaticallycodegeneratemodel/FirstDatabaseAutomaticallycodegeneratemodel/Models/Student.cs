using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FirstDatabaseAutomaticallycodegeneratemodel.Models
{
    public partial class Student : DbContext
    {
        public Student()
            : base("name=Student")
        {
        }

        public virtual DbSet<BookModel> BookModels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
