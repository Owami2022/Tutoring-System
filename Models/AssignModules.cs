using System;
using System.ComponentModel.DataAnnotations;
using TBHAcademy.Areas.Identity.Data;

namespace TBHAcademy.Models
{
    public class AssignModules
    {
        [Key]
        public int AssignedID { get; set; }
        [Required]
        public string TutorID { get; set; }
        [Required]
        public int ModuleID { get; set; }
        [Required]
        public DateTime DateAssigned { get; set; }
        public virtual TBHAcademyUser TBHAcademyUser { get; set; }
        public virtual Modules Modules { get; set; }


    }
}
