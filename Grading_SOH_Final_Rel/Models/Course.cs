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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            StudentsGrades = new HashSet<StudentsGrade>();
            StudentsGrades1 = new HashSet<StudentsGrade>();
            StudentsGrades2 = new HashSet<StudentsGrade>();
            StudentsGrades3 = new HashSet<StudentsGrade>();
            StudentsGrades4 = new HashSet<StudentsGrade>();
            StudentsGrades5 = new HashSet<StudentsGrade>();
            StudentsGrades6 = new HashSet<StudentsGrade>();
            StudentsGrades7 = new HashSet<StudentsGrade>();
        }

        [StringLength(50)]
        public string CourseID { get; set; }

        [Required]
        [StringLength(50)]
        public string CourseName { get; set; }

        //public double ExamMax { get; set; }

        //public double TestMax { get; set; }

        public int CreditUnit { get; set; }

        public int DepartmentID { get; set; }

        public int SemisterID { get; set; }

        public virtual Department Department { get; set; }

        public virtual Semister Semister { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentsGrade> StudentsGrades { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentsGrade> StudentsGrades1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentsGrade> StudentsGrades2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentsGrade> StudentsGrades3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentsGrade> StudentsGrades4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentsGrade> StudentsGrades5 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentsGrade> StudentsGrades6 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentsGrade> StudentsGrades7 { get; set; }
    }
}
