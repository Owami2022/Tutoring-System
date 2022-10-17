using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;// Refers to our displayName
using System.Linq;
using System.Threading.Tasks;
namespace TBHAcademy.Models
{
    public class QuestionOptions
    {
        [Key]
        public int OpID { get; set; }
        [Required]
        public string OpName { get; set; }
        [Required]
        public int Qid { get; set; }
    }
}
