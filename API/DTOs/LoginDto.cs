using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    // Our Login DTO (Data Trasfer Object) doesnt need everything our AppUser contains, only these properties
    public class LoginDto
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}