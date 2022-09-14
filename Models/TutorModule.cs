using TBHAcademy.Areas.Identity.Data;

namespace TBHAcademy.Models
{
    public class TutorModule
    {
        public Modules ModulesTM { get; set; }
        public TBHAcademyUser UserTM { get; set; }
        public Course CourseTM { get; set; }
        public AssignModules AssignTM { get; set; }
    }
}
