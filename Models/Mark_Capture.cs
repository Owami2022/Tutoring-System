using System.ComponentModel.DataAnnotations;
using TBHAcademy.Areas.Identity.Data;

namespace TBHAcademy.Models
{
    public class Mark_Capture
    {
        [key]
        public int MarkID { get; set; }
        [Required]
        [Display(Name ="Student")]
        public string  StudentID { get; set; }
        public virtual TBHAcademyUser TBHAcademyUser { get; set; }
        [Display(Name = "Module")]
        [Required]
        public int ModuleID { get; set; }
        [Required]
        [Display(Name = "Type")]
        public string Assessment_Type { get; set; }
        [Required]
        [Display(Name = "Date of Assesment")]
        public string DateOfAssessment { get; set; }
        [Required]
        [Display(Name = "Overall Mark")]
        public int Overall_Mark { get; set; }
        [Required]
        [Display(Name = "Mark Obtained")]
        public int mark_Obtained { get; set; }

    }
}
