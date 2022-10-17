using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TBHAcademy.Areas.Identity.Data;

namespace TBHAcademy.Models
{
    public class ScheduleMeeting
    {
        [key]
        public int ScheduleMeetingID { get; set; }

        [Required]
        [Display(Name = "Appointment Date")]
        public DateTime AppointmentDate { get; set; }

        [Required]
        [Display(Name = "Meet link")]
        public string Link { get; set; }

        [Required]
        [Display(Name ="Meet purpose")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Select Student")]
        public string StudentId { get; set; }

        public virtual TBHAcademyUser TBHAcademyUser { get; set; }
    }
}
