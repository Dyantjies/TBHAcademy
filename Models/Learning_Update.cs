using TBHAcademy.Areas.Identity.Data;


namespace TBHAcademy.Models
{
    public class Learning_Update
    {
        public Course Course { get; set; }
        public Faculty  Faculty { get; set; }
        public Mark_Capture Mark_Capture { get; set; }
        public TBHAcademyUser TBHAcademyUser { get; set; }
        public Modules Modules { get; set; }
        public Enroll Enroll { get; set; }
    }
}
