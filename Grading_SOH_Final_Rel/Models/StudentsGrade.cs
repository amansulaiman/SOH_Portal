namespace Grading_SOH_Final_Rel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StudentsGrade")]
    public partial class StudentsGrade
    {
        [Key]
        public int ID { get; set; }

        [StringLength(50)]
        public string StudentID { get; set; }

        [StringLength(50)]
        public string CourseCode { get; set; }

        [Range(0, 40, ErrorMessage = "Please Enter Valid ExaTestm score")]
        public double? TestScore { get; set; }

        [Range(0, 60, ErrorMessage = "Please Enter Valid Exam score")]
        public double? ExamScore { get; set; }
        
        public string Status { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime RegistrationDate { get; set; }

        public virtual Course Course { get; set; }

        public virtual Student Student { get; set; }
    }
}
