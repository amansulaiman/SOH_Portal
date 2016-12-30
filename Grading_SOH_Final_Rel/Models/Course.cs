namespace Grading_SOH_Final_Rel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Course")]
    public partial class Course
    {

        [StringLength(50)]
        public string CourseID { get; set; }

        [Required]
        [StringLength(50)]
        public string CourseName { get; set; }
 

        public int CreditUnit { get; set; }

        public int DepartmentID { get; set; }

        public int SemisterID { get; set; }

        public virtual Department Department { get; set; }

        public virtual Semister Semister { get; set; }
        
        public virtual List<StudentsGrade> StudentsGrades { get; set; }
    }
}
