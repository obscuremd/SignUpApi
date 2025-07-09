using System.ComponentModel.DataAnnotations;

namespace SignUpApi.DTOs
{
    public class UserLoginDto
    {
        [Required, MinLength(2), EmailAddress]
        public string Email { get; set; }

        [Required, MinLength(6)]
        public string Password { get; set; }
    }
}
