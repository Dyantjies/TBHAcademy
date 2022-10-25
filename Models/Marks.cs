using System;
using System.ComponentModel.DataAnnotations;
using TBHAcademy.Areas.Identity.Data;

namespace TBHAcademy.Models
{
    public class Marks
    {
        [Key]
        public int MarksId { get; set; }

        [Required]
        [Display(Name ="Description")]
        [StringLength(100)]
        public string MarksDescription { get; set; }

        [Required]
        [Display(Name ="Overall Mark")]
        public int OverallMarks { get; set; }

        [Required]
        [Display(Name ="Obtained Mark")]
        public int ObtainedMark { get; set; }

        //[Required]
        [Display(Name ="Comment")]
        public string MarksComment { get; set; }

        [Required]
        [Display(Name ="Assessment Date")]
        public DateTime dateTime { get; set; }
       
        //Join Comment table as FK

        [Required]
        [Display(Name = "Please Add Comment")]
        public int CommentId { get; set; }
        public virtual Comment Comment { get; set; }

        [Required]
        [Display(Name = "Please Select Module")]
        public int ModuleId { get; set; }
        public virtual Modules Modules { get; set; }
        
        [Display(Name = "Please Select Student")]
        public string StudentId { get; set; }
        public virtual TBHAcademyUser TBHAcademyUser { get; set; } 

    }
}