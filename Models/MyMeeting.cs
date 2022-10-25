using TBHAcademy.Areas.Identity.Data;

namespace TBHAcademy.Models
{
    public class MyMeeting
    {
        public ScheduleMeeting ScheduleMeetingVM { get; set; }
        public TBHAcademyUser UserVM { get; set; }

    }
}
