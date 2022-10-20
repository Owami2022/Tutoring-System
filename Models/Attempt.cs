using System;
using System.ComponentModel.DataAnnotations;

namespace TBHAcademy.Models
{
    public class Attempt
    {
        [Key]
        public int AttemptID { get; set; }
        [Required]
        public string StudentID { get; set; }
        [Required]
        public int QuizID { get; set; } 
        public string Date { get; set; }
        public  string time { get; set; }

    }
}
