using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AdmissionRegistraton.Models
{
    public partial class CourseModel : DbContext
    {
        public CourseModel()
            : base("name=CourseModel")
        {
        }

        public virtual DbSet<BatchTable> BatchTables { get; set; }
        public virtual DbSet<Coursetable> Coursetables { get; set; }
        public virtual DbSet<RegistrationTable> RegistrationTables { get; set; }
        public virtual DbSet<UserTable> UserTables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BatchTable>()
                .Property(e => e.Batch)
                .IsUnicode(false);

            modelBuilder.Entity<BatchTable>()
                .Property(e => e.Year)
                .IsUnicode(false);

            modelBuilder.Entity<Coursetable>()
                .Property(e => e.CourseName)
                .IsUnicode(false);

            modelBuilder.Entity<RegistrationTable>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<RegistrationTable>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<RegistrationTable>()
                .Property(e => e.Nic)
                .IsUnicode(false);

            modelBuilder.Entity<UserTable>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<UserTable>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<UserTable>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<UserTable>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
