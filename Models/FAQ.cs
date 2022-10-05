using System.ComponentModel.DataAnnotations;

namespace TBHAcademy.Models
{
    public class FAQ
    {
        [Key]
        public int FAQId { get; set; }
        public string Questions { get; set; }
        public string Answer { get; set; }
    }
}
