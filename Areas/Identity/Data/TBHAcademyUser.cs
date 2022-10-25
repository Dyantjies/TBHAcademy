using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TBHAcademy.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the TBHAcademyUser class
    public class TBHAcademyUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }
        [PersonalData]
        [DisplayFormat(DataFormatString = "{dd MMM yyyy}")]
        [Display(Name = "Date of Birthday")]
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]


        public DateTime DOB { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Gender { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public int Status { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Role { get; set; }

        public DateTime date { get;set; }
        [Display(Name = "User Picture")]
        public byte[] MyPicture { get; set; }

        [Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; }

        [Display(Name = "Address Line 2")]
        public string AddressLine2 { get; set; }

    }
}
