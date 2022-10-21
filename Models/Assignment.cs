using System;
using System.ComponentModel.DataAnnotations;

namespace TBHAcademy.Models
{
    public class Assignment
    {
        [Key]
        public int AssignmnetID { get; set; }
        [Required]
        [Display(Name = "Assignment Description")]
        public string AssignmentDes { get; set; }
        [Required]
        [Display(Name = "Assignment Due Date")]
        public DateTime DueDate { get; set; }
        public string FileType { get; set; }
        public string FileName { get; set; }
        public string Extension { get; set; }
        public string CreatedDate { get; set; }
        [Required]
        public int ModuleID { get; set; }
    }
}
