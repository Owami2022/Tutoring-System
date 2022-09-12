using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
namespace TBHAcademy.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Display(Name = "Course Name")]
        [Required]
        public string CourseName { get; set; }
        [Required]
        [Display(Name = "Course Description")]
        public string CourseDescription { get; set; }
        public int Status { get; set; }
        [Required]
        [Display(Name = "Please select a Faculty")]
        public int FacultyId { get; set; }
        public virtual Faculty Faculty { get; set; }

    }
}
