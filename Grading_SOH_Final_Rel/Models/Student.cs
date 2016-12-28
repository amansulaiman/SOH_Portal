namespace Grading_SOH_Final_Rel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [StringLength(50)]
        [Display(Name = "Student ID", ShortName = "ID", Description = "Student ID", Prompt = "Enter Student ID")]
        [DataType(DataType.Text, ErrorMessage = "Please Enter Error Message")]
        public string StudentID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "First Name", ShortName = "Name", GroupName = "BioData", Description = "First Name", Prompt = "Enter First Name")]
        [DataType(DataType.Text, ErrorMessage = "Please Enter Error Message")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Surname", ShortName = "Surname", GroupName = "BioData", Description = "Surame", Prompt = "Enter Surname")]
        [DataType(DataType.Text, ErrorMessage = "Please Enter Error Message")]
        public string SurName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name", ShortName = "Name", GroupName = "BioData", Description = "Last Name", Prompt = "Enter Last Name")]
        [DataType(DataType.Text, ErrorMessage = "Please Enter Error Message")]
        public string LastName { get; set; }

        public int SessionID { get; set; }

        public int? Age { get; set; }

        [StringLength(50)]
        public string HighestQualification { get; set; }

        public int DepartmentID { get; set; }
        
        [StringLength(50)]
        public string Status { get; set; }

        public virtual Department Department { get; set; }

        public virtual Session Session { get; set; }

        public virtual List<StudentsGrade> StudentsGrades { get; set; }
    }
}
