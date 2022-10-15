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
        [key]
        public int OpID { get; set; }
        public string OpName { get; set; }
        public int Qid { get; set; }
    }
}
