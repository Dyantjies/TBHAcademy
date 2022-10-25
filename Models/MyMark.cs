using TBHAcademy.Areas.Identity.Data;

namespace TBHAcademy.Models
{
    public class MyMark
    {
        public Modules ModulesVM { get; set; }
        public Mark_Capture Mark_CaptureVM { get; set; }
        public TBHAcademyUser UserVM { get; set; }
    }
}
