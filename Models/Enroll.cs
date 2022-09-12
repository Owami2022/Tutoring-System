using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
// Refers to our displayName
using System.Linq;
using System.Threading.Tasks;
using TBHAcademy.Areas.Identity.Data;

namespace TBHAcademy.Models
{
    public class Enroll
    {
        [Key]
        public int EnrolledID { get; set; }
       
        [DisplayName("Date Enrolled")]
        public DateTime DateErolled { get; set; }
        [Required]
        [DisplayName("Module")]
        public int ModuleID { get; set; }
        [Required]
        [DisplayName("Student Number")]
        public string StudentID { get; set; }
        public virtual TBHAcademyUser TBHAcademyUser { get; set; }
    }
}
