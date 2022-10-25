using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TBHAcademy.Models
{
    public enum CourseStatus
    {
        [Description("Active")]
        Active = 0,
        [Description("Inactive")]
        Inactive = 1,
    }

    public enum UserStatus
    {
        [Description("Active")]
        Active = 0,
        [Description("Inactive")]
        Inactive = 1,
    }
}
