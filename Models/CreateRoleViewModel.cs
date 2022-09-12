using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
namespace TBHAcademy.Models

{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
        
    }
}
