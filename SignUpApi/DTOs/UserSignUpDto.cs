using System.ComponentModel.DataAnnotations;

namespace SignUpApi.DTOs
{
    public class UserSignUpDto
    {
        [Required, MinLength(2)]
        public string FirstName { get; set; }
        
        [Required, MinLength(2)]
        public string LastName { get; set; }
        
        [Required, MinLength(2), EmailAddress]
        public string Email { get; set; }
        
        [Required, MinLength(6)]
        public string Password { get; set; }
        
        [Required, Compare("Password", ErrorMessage ="Passsword Mismatch")]
        public string ConfirmPassword { get; set; }


    }
}
