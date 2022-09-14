using TBHAcademy.Areas.Identity.Data;

namespace TBHAcademy.Models
{
    public class ManageContent
    {
        public Content content { get; set; }
        public AssignModules assignModules { get; set; }
        public TBHAcademyUser UserVM { get; set; }
        public Modules Modules { get; set; }
    }
}
