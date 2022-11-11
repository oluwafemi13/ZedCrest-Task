using System.ComponentModel.DataAnnotations;

namespace Zedcrest_Task.DTO
{
    public class UserLoginDTO
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
