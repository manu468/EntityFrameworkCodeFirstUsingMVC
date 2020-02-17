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
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
        //  To add the new entities to the data model and perform database mapping that we 
        //didn't do by using attributes, replace the code in DAL\SchoolContext.cs ,, the replaced code is above 
        //public SchoolContext() : base("SchoolContext")
        //{
        //}
        //public DbSet<Student> Students { get; set; }
        //public DbSet<Enrollment> Enrollments { get; set; }
        //public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //The modelBuilder.Conventions.Remove statement in the OnModelCreating method prevents table
            //    names from being pluralized.If you didn't do this, the generated tables in the database
            //    would be named Students, Courses, and Enrollments. Instead, the table names will be Student, 
            //    Course, and Enrollment
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            // ------ fluent API-----
            //customize some of the mapping using fluent API calls.The API is "fluent" 
            //    because it's often used by stringing a series of method calls together into a single statement
            modelBuilder.Entity<Course>()
            .HasMany(c => c.Instructors).WithMany(i => i.Courses)
            .Map(t => t.MapLeftKey("CourseID")
                .MapRightKey("InstructorID")
                .ToTable("CourseInstructor"));
            modelBuilder.Entity<Department>().MapToStoredProcedures();
        }
    }
}
//This code creates a DbSet property for each entity set.In Entity Framework terminology, 
//    an entity set typically corresponds to a database table, and an entity corresponds to a row in the table.