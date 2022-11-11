using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Zedcrest_Task.DTO
{
    public class UserRegistrationDTO
    {
        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public string? UserName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Format")]
        public string? Email { get; set; }

        [Required]
        [PasswordPropertyText]
        [Compare("ConfirmPassword", ErrorMessage = "Password Do Not Match")]
        public string? Password { get; set; }

        [Required]
        [PasswordPropertyText]
        public string? ConfirmPassword { get; set; }

        [Required]
        [Phone]
        [MinLength(3)]
        [MaxLength(11)]
        public string? PhoneNumber { get; set; }
    }
}
