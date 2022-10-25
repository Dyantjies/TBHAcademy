using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TBHAcademy.Areas.Identity.Data;

namespace TBHAcademy.Models
{
    public class ScheduleMeeting
    {
        [key]
        public int ScheduleMeetingID { get; set; }

        [Required]
        [Display(Name = "Meeting Title")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Meet purpose")]
        public string Description { get; set; }

        [Display(Name = "Meeting Date")]
        public DateTime AppointmentDate { get; set; }

        [Required]
        [Display(Name = "Meet link")]
        public string Link { get; set; }
        
        [Display(Name = "Select Individual Member")]
        public string MemberId { get; set; }
        [Display(Name = "Invite Student For: ")]
        public int ModuleID { get; set; }
        [Display(Name = "Meeting Hoster")]
        public string CreatorID { get; set; }
        public virtual TBHAcademyUser TBHAcademyUser { get; set; }

    }
}
