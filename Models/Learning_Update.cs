using TBHAcademy.Areas.Identity.Data;


namespace TBHAcademy.Models
{
    public class Learning_Update
    {
        public TBHAcademyUser TBHAcademyUser { get; set; }
        public AssignModules AssignModules { get; set; }
        public Mark_Capture Mark_Capture { get; set; }
        public Modules Modules { get; set; }
    }
}
