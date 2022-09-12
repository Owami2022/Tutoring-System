using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace TBHAcademy.Models
{
    public class Faculty
    {

        [Required]
        [Key]
        public int FacultyId { get; set; }
        [Required]
        public string FacultyName { get; set; }
        [Required]
        public string FacultyDescription { get; set; }

        public List<Course> Courses { get; set; }
    }
}
