using TBHAcademy.Areas.Identity.Data;
using TBHAcademy.Models;

namespace TBHAcademy.Controllers
{
    public class Academic_Info_Display
    {
        public Enroll Enroll { get; set; }
        public TBHAcademyUser TBHAcademyUser { get; set; }
        public AssignModules AssignModules { get; set; }
        public Modules Modules { get; set; }
        public Course Course { get; set; }
    }
}
