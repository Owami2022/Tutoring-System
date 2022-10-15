using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;// Refers to our displayName
using System.Linq;
using System.Threading.Tasks;
namespace TBHAcademy.Models
{
    public class Quiz
    {
        [key]

        public int QuizID { get; set; }
        [Required]
        [DisplayName("Quiz Description")]
        public string QDescription { get; set; }
        [Required]
        [DisplayName("Activation Date")]
        public string DActive { get; set; }
        [Required]
        [DisplayName("Attempts Allowed")]
        public int Attempts { get; set; }
        [DisplayName("Timer")]
        public int Time { get; set; }
        public bool IsActive { get; set; }

        public int AssignedID { get; set; }
        public virtual AssignModules AssignModules { get; set; }

    }
}
