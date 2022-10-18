using System.ComponentModel.DataAnnotations;

namespace TBHAcademy.Models
{
    public class Comment
    {
        [key]
        public int CommentId { get; set; }

        [Required]
        [Display(Name = "Comments")]
        public string CommentText { get; set; }

    }
}
