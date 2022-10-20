using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TBHAcademy.Models
{
    public class QuestionModel
    {
       
        [Required(ErrorMessage = "Question Number is Required")]
        [DisplayName("Question Number")]
        public string QuestionNum { get; set; }
        [Required(ErrorMessage = "Question is Required")]
        [DisplayName("Question Description")]
        public string QuestionDes { get; set; }
        [DisplayName("Option")]
        public List<string> ListofOptions { get; set; }
        public string QueAnswerTxt { get; set; }
        public int QuizID { get; set; }
    }
}
