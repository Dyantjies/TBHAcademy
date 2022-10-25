using System.Collections.Generic;

namespace TBHAcademy.Models
{
    public class UserRolesViewModel
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }
}
