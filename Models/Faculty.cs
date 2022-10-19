using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using TBHAcademy.Areas.Identity.Data;

namespace TBHAcademy.Models
{
    public class Faculty
    {

        
        [Key]
        public int FacultyId { get; set; }
        [Required]
        [Display (Name = "Faculty Name")]
        public string FacultyName { get; set; }
        [Required]
        [Display (Name = "Faculty Description")]
        public string FacultyDescription { get; set; }
        
        public List<Course> Courses { get; set; }
        
        
        public int Status { get; set; }
    }
}
