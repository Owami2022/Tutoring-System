using TBHAcademy.Areas.Identity.Data;

namespace TBHAcademy.Models
{
    public class MyMark
    {
        public Modules ModulesVM { get; set; }
        public Comment CommentVM { get; set; }
        public TBHAcademyUser UserVM { get; set; }
    }
}
