using TBHAcademy.Areas.Identity.Data;

namespace TBHAcademy.Models
{
    public class ModuleDisplay
    {
        public Modules ModulesVM { get; set; }
        public Course CourseVM { get; set; }
        public TBHAcademyUser UserVM {get;set;}
        public  Faculty FacultyVM { get; set; }
        public AssignModules AssignModulesVM { get; set; }
    }
    public class ManageContent
    {
        public Content content { get; set; }
        public Topic topic { get; set; }
        public AssignModules assignModules { get; set; }
        public TBHAcademyUser UserVM { get; set; }
        public Modules Modules { get; set; }
    }
        
}
