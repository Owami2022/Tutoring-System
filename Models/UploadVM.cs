using System.Collections.Generic;

namespace TBHAcademy.Models
{
    public class UploadVM
    {
        public List<Upload> File { get; set; }
        public Modules ModulesVM { get; set; }
        public AssignModules AssignModulesVM { get; set; }
    }
}
