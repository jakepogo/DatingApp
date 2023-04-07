using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    // Our Registration DTO (Data Trasfer Object) doesnt need everything our AppUser contains, only these properties
    public class RegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}