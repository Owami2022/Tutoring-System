using TBHAcademy.Areas.Identity.Data;

namespace TBHAcademy.Models
{
    public class Enrolled_Module_Display
    {
        public Enroll Enroll { get; set; }
        public TBHAcademyUser TBHAcademyUser { get; set; }
        public AssignModules AssignModules { get; set; }
        public Modules Modules { get; set; }
        public Course Course { get; set; }
    }
}
