namespace Grading_SOH_Final_Rel.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Session")]
    public partial class Session
    {

        public int SessionID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="Session Name")]
        public string SessionName { get; set; }
        
        public virtual List<Semister> Semisters { get; set; }
        
        public virtual List<Student> Students { get; set; }
    }
}
