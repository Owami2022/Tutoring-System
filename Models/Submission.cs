using System.ComponentModel.DataAnnotations;

namespace TBHAcademy.Models
{
    public abstract class Submission
    {
        [Key]           
        public int Id { get; set; }
        [Display(Name="Save As")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string DateOfSub { get; set; }
        public string FileType { get; set; }
        public string Extension { get; set; }
        public string StudentID { get; set; }
        public int ModuleID { get; set; }
        public int AssignmentID { get; set; }



    }
}
