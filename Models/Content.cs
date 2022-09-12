using System.ComponentModel.DataAnnotations;

namespace TBHAcademy.Models
{
    public class Content
    {
        [Key]
        [Required]
        //Content ID
        public int ContentId { get; set; }
        //Documents
        [Display(Name = "Document discription")]
        public string DocumentDescription1 { get; set; }
        [Display(Name = "Document")]
        public byte[] Document1{ get; set; }
        [Display(Name = "Document discription")]
        public string DocumentDescription2 { get; set; }
        [Display(Name = "Document")]
        public byte[] Document2 { get; set; }
        [Display(Name = "Document discription")]
        public string DocumentDescription3 { get; set; }
        [Display(Name = "Document")]
        public byte[] Document3 { get; set; }
        [Display(Name = "Document discription")]
        public string DocumentDescription4 { get; set; }
        [Display(Name = "Document")]
        public byte[] Document4 { get; set; }
        [Display(Name = "Document discription")]
        public string DocumentDescription5 { get; set; }
        [Display(Name = "Document")]
        public byte[] Document5 { get; set; }

        //Links
        [Display(Name = "Link discription")]
        public string LinkDescription1 { get; set; }
        [Display(Name = "Link")]
        public string Link1 { get; set; }
        [Display(Name = "Link discription")]
        public string LinkDescription2 { get; set; }
        [Display(Name = "Link")]
        public string Link2 { get; set; }
        [Display(Name = "Link discription")]
        public string LinkDescription3 { get; set; }
        [Display(Name = "Link")]
        public string Link3 { get; set; }
        [Display(Name = "Link discription")]
        public string LinkDescription4 { get; set; }
        [Display(Name = "Link")]
        public string Link4 { get; set; }
        [Display(Name = "Link discription")]
        public string LinkDescription5 { get; set; }
        [Display(Name = "Link")]
        public string Link5 { get; set; }

        //Topic ID
        public int TopicID { get; set; }
        public virtual Topic Topic { get; set; }

    }
}
