using System.ComponentModel.DataAnnotations;

namespace TBHAcademy.Models
{
    public class FAQ
    {
        [Key]
        public int FAQId { get; set; }
        [Required(ErrorMessage ="Please enter A Question")]

        public string Questions { get; set; }
        [Required(ErrorMessage = "Please enter An Answer")]
        public string Answer { get; set; }
    }
}
