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
        [StringLength(50)]
        public string StudentID { get; set; }

        [StringLength(50)]
        public string C1Code { get; set; }

        public double? C1Test { get; set; }

        [Range(0, 60, ErrorMessage = "Please Enter Valid Exam score")]
        public double? C1Exam { get; set; }

        [StringLength(50)]
        public string C2Code { get; set; }

        [Range(0,40,ErrorMessage ="Please Enter Valid Test score")]
        public double? C2Test { get; set; }

        [Range(0, 60, ErrorMessage = "Please Enter Valid Exam score")]
        public double? C2Exam { get; set; }

        [StringLength(50)]
        public string C3Code { get; set; }

        [Range(0, 40, ErrorMessage = "Please Enter Valid Test score")]
        public double? C3Test { get; set; }

        [Range(0, 60, ErrorMessage = "Please Enter Valid Exam score")]
        public double? C3Exam { get; set; }

        [StringLength(50)]
        public string C4Code { get; set; }

        [Range(0, 40, ErrorMessage = "Please Enter Valid Test score")]
        public double? C4Test { get; set; }

        [Range(0, 60, ErrorMessage = "Please Enter Valid Exam score")]
        public double? C4Exam { get; set; }

        [StringLength(50)]
        public string C5Code { get; set; }

        [Range(0, 40, ErrorMessage = "Please Enter Valid Test score")]
        public double? C5Test { get; set; }

        [Range(0, 60, ErrorMessage = "Please Enter Valid Exam score")]
        public double? C5Exam { get; set; }

        [StringLength(50)]
        public string C6Code { get; set; }

        [Range(0, 40, ErrorMessage = "Please Enter Valid Test score")]
        public double? C6Test { get; set; }

        [Range(0, 60, ErrorMessage = "Please Enter Valid Exam score")]
        public double? C6Exam { get; set; }

        [StringLength(50)]
        public string C7Code { get; set; }

        [Range(0, 40, ErrorMessage = "Please Enter Valid Test score")]
        public double? C7Test { get; set; }

        [Range(0, 60, ErrorMessage = "Please Enter Valid Exam score")]
        public double? C7Exam { get; set; }

        [StringLength(50)]
        public string C8Code { get; set; }

        [Range(0, 40, ErrorMessage = "Please Enter Valid Test score")]
        public double? C8Test { get; set; }

        [Range(0, 60, ErrorMessage = "Please Enter Valid Exam score")]
        public double? C8Exam { get; set; }

        [Required]
        [StringLength(50)]
        public string STATUS { get; set; }

        public virtual Course Course { get; set; }

        public virtual Course Course1 { get; set; }

        public virtual Course Course2 { get; set; }

        public virtual Course Course3 { get; set; }

        public virtual Course Course4 { get; set; }

        public virtual Course Course5 { get; set; }

        public virtual Course Course6 { get; set; }

        public virtual Course Course7 { get; set; }

        public virtual Student Student { get; set; }
    }
}
