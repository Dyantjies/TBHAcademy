using TBHAcademy.Areas.Identity.Data;

namespace TBHAcademy.Models
{
    public class Faculties_Display
    {
        public int FacultyId { get; set; }
        public virtual Faculty Faculty { get; set; }
        public Course Course { get; set; }
        public Modules Modules { get; set; }
        public Enroll Enroll { get; set; }

    }
}