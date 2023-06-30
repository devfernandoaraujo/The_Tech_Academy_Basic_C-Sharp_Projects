using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Assignment.Models
{
    internal class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Adding Id of the table Students as Primary key
            modelBuilder.Entity<Student>()
                .HasKey(s => s.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
