using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MuppavarapuStateUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        //The CourseID property is a foreign key, and the corresponding navigation property is Course.
        //    An Enrollment entity is associated with one Course entity.
        public int CourseID { get; set; }
        //The StudentID property is a foreign key, and the corresponding navigation property is Student.
        //    An Enrollment entity is associated with one Student entity, so the property can only hold a 
        //    single Student entity(unlike the Student.Enrollments navigation property we saw earlier,
        //        which can hold multiple Enrollment entities).
        public int StudentID { get; set; }
        //The Grade property is an enum. The question mark after the Grade type declaration 
        //    indicates that the Grade property is nullable.A grade that's null is different 
        //    from a zero grade — null means a grade isn't known or hasn't been assigned yet.
        [DisplayFormat(NullDisplayText ="No Grade")]
        public Grade? Grade { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}