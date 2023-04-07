namespace API.DTOs
{
    // Our User DTO (Data Trasfer Object) doesnt need everything our AppUser contains, only these properties
    public class UserDto
    {
        public string Username { get; set; }
        public string Token { get; set; }
    }
}