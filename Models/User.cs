using Microsoft.AspNetCore.Identity;

namespace Zedcrest_Task.Models
{
    public class User: IdentityUser
    {
        public string FirstName { get; set; }

        public string Lastname { get; set; }
    }
}
