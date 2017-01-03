using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Grading_SOH_Final_Rel.Models
{
    public class Bulletin
    {
        public int BulletinID { get; set; }
        [Display(Name ="Content")]
        [DataType(DataType.MultilineText)]
        public string BelletinContent { get; set; }
        
        public DateTime PublishDate { get; set; }
        public DateTime ExpDate { get; set; }
    }
}