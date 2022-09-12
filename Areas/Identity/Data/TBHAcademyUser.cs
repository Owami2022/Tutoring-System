using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TBHAcademy.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the TBHAcademyUser class
    public class TBHAcademyUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }
        [PersonalData]
        [DisplayFormat(DataFormatString = "{dd MMM yyyy}")]
        [Display(Name = "Date of Birthday")]
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        

        public DateTime DOB { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Gender { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Status { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Role { get; set; }

        public DateTime date { get;set; }    
    }
}
