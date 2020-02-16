using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MuppavarapuStateUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        public string FirstName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        //The Enrollments property is a navigation property.
        //    Navigation properties hold other entities that are related to this entity.In this case, the Enrollments property of 
        //        a Student entity will hold all of the Enrollment entities that are related to that Student entity.In other words, 
        //        if a given Student row in the database has two related Enrollment rows (rows that contain that student's 
        //        primary key value in their StudentID foreign key column), that Student entity's Enrollments navigation property 
        //        will contain those two Enrollment entities.


        //Navigation properties are typically defined as virtual so that they can take advantage of certain Entity Framework 
        //         functionality such as lazy loading.

        //    If a navigation property can hold multiple entities(as in many-to-many or one-to-many relationships), 
        //    its type must be a list in which entries can be added, deleted, and updated, such as ICollection.
        //
    }
}
