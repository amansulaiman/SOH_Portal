using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Grading_SOH_Final_Rel.Models
{
    public class Applicants
    {
        [Key]
        public int ID { get; set; }
        [Display(Name ="First Name")]
        [Required(ErrorMessage ="You Must enter {0}")]
        public string FirstName { get; set; }

        [Display(Name = "Surname")]
        [Required(ErrorMessage = "You Must enter {0}")]
        public string SurName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You Must enter {0}")]
        public string LastName { get; set; }

        [Required]
        [Display(Name ="Local Govenment Area")]
        public lga LocalGovt { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public float PhoneNumber { get; set; }

        public enum lga
        {
            Municipal, Fagge, Nassarawa, Tarauni
        }
    }
}