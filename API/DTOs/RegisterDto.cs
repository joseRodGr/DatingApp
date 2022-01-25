using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        // [Required(ErrorMessage ="Username is mandatory")]
        // [MinLength(3, ErrorMessage = "Password must be equal or greater than 3 characters")]
        [Required]
        public string Username { get; set; }

        // [Required(ErrorMessage ="Password is mandatory")]
        // [MinLength(5,ErrorMessage = "Password must be equal or greater than 5 characters")]
        [Required]
        [StringLength(8, MinimumLength = 4)]
        public string Password { get; set; }

    
    }
}