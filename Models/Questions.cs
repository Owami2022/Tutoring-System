using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;// Refers to our displayName
using System.Linq;
using System.Threading.Tasks;

namespace TBHAcademy.Models
{
    public class Questions
    {
        [key]
        public int QId { get; set; }
        [Required(ErrorMessage = "Question Number is Required")]
        [DisplayName("Question Number")]
        public string QNumber { get; set; }
        [Required(ErrorMessage ="Question is Required")]
        [DisplayName("Question Description")]
        public string QuesDes { get; set; }
        public bool IsMultiple { get; set; }
        public int QuizID { get; set; }
       



    }
}
