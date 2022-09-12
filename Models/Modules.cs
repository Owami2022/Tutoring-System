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
        public string ModuleCode { get; set; }
        [Required]
        public string ModuleName { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public int CourseID { get; set; }
        public virtual Course Course { get; set; }
    }
}
