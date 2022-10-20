using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;// Refers to our displayName
using System.Linq;
using System.Threading.Tasks;

namespace TBHAcademy.Models
{
    public class QuestionAnswer
    {
        [Key]
        public int AnsID { get; set; }
        [Required]
        public string AnsText { get; set; }
        [Required]
        public int Qid { get; set; }
    }
}
