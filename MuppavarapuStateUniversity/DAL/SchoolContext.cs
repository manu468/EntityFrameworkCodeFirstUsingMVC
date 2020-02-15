using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using MuppavarapuStateUniversity.Models;

namespace MuppavarapuStateUniversity.DAL
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("SchoolContext")
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //The modelBuilder.Conventions.Remove statement in the OnModelCreating method prevents table
            //    names from being pluralized.If you didn't do this, the generated tables in the database
            //    would be named Students, Courses, and Enrollments. Instead, the table names will be Student, 
            //    Course, and Enrollment
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
//This code creates a DbSet property for each entity set.In Entity Framework terminology, 
//    an entity set typically corresponds to a database table, and an entity corresponds to a row in the table.