using TBHAcademy.Areas.Identity.Data;

namespace TBHAcademy.Models
{
    public class ModuleDisplay
    {
        public Modules ModulesVM { get; set; }
        public Course CourseVM { get; set; }
        public Enroll EnrollVM { get; set; } 
        public TBHAcademyUser UserVM {get;set;}
        public  Faculty FacultyVM { get; set; }
        public AssignModules AssignModulesVM { get; set; }
    }     
}
