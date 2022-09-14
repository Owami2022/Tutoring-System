using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace TBHAcademy.Models
{
    public class TeamMark
    {
        [Key]
        public int Teamid { get; set; }
        [Required]
        [DisplayName("Full Name")]
        public string StName{ get; set; }
        [Required]
        [DisplayName("Surname")]
        public string StSurname { get; set; }
        [DisplayName("Term 1")]
        public int TeamOne { get; set; }
        [DisplayName("Term 2")]
        public int TeamTwo { get; set; }
        [DisplayName("Term 3")]
        public int TeamThree { get; set; }

        [DisplayName("Term 4")]
        public int TeamFour { get; set; }

    }
}
