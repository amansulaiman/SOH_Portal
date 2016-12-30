namespace Grading_SOH_Final_Rel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Semister
    {
        
        public int SemisterID { get; set; }

        [Required]
        [StringLength(50)]
        public string SemisterName { get; set; }

        public int SessionID { get; set; }
        
        public virtual List<Course> Courses { get; set; }

        public virtual Session Session { get; set; }

        public enum Sessions
        {
            First_Semister, Second_Semister
        }
    }
}
