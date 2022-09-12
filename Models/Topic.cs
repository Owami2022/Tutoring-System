using System.ComponentModel.DataAnnotations;

namespace TBHAcademy.Models
{
    public class Topic
    {
        [Key]
        [Required]
        public int TopicId { get; set; }
        [Display(Name = "Topic Name")]
        [Required]
        public string TopicName { get; set; }
        [Display(Name = "Topic Description")]
        public string TopicDescription { get; set; }

        //Assigned Module ID
        [Required]
        public int AssignedModuleId { get; set; }

    }
}
