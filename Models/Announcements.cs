using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace TBHAcademy.Models
{
    public class Announcements
    {
        [Key]
        public int AnnouncementId { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Display (Name = "Date Created")]
        public DateTime DateCreated { get; set; }
    }
}
