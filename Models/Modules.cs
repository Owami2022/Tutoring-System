using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;// Refers to our displayName
using System.Linq;
using System.Threading.Tasks;
namespace TBHAcademy.Models
{
    public class Modules
    {
        [Key]
        public int ModuleId { get; set; }
        [Required]
        [Display(Name = "Module Code")]
        public string ModuleCode { get; set; }
        [Required]
        [Display(Name = "Module Name")]
        public string ModuleName { get; set; }
        [Required]
        [Display(Name = "Year")]
        public string Year { get; set; }
        [Required]
        [Display(Name = "Course Name")]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
