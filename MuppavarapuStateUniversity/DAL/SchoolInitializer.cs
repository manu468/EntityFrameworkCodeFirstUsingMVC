using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MuppavarapuStateUniversity.Models;

namespace MuppavarapuStateUniversity.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        //  Seed method that Entity Framework automatically calls after creating the database in order to populate it with test data.
        // the Seed method will run when the database is re-created and will re-create your test data
        protected override void Seed(SchoolContext context)
        {
            //The Seed method takes the database context object as an input parameter, and the code in the method uses that 
            //    object to add new entities to the database.For each entity type, the code creates a collection of new entities,
            //adds them to the appropriate DbSet property, and then saves the changes to the database. It isn't necessary 
            //    to call the SaveChanges method after each group of entities, as is done here, but doing that helps you 
            //    locate the source of a problem if an exception occurs while the code is writing to the database.


            var students = new List<Student>
            {
            //new Student{FirstName="Pani",LastName="Chusko",EnrollmentDate=DateTime.Parse("2005-09-01")},
            //new Student{FirstName="Kandal",LastName="Gymson",EnrollmentDate=DateTime.Parse("2002-09-01")},
            //new Student{FirstName="Manu",LastName="Muppavarapu",EnrollmentDate=DateTime.Parse("2003-09-01")},
            //new Student{FirstName="Puth",LastName="Rocky",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{FirstName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
            new Course{CourseID=1050,Title="Chemistry",Credits=3,},
            new Course{CourseID=4022,Title="Microeconomics",Credits=3,},
            new Course{CourseID=4041,Title="Macroeconomics",Credits=3,},
            new Course{CourseID=1045,Title="Calculus",Credits=4,},
            new Course{CourseID=3141,Title="Trigonometry",Credits=4,},
            new Course{CourseID=2021,Title="Composition",Credits=3,},
            new Course{CourseID=2042,Title="Literature",Credits=4,}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050,},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}
//This code  causes a database to be created when needed and loads test data into the new database.
//To tell Entity Framework to use your initializer class, add an element to the entityFramework element in the application
//  Web.config file 