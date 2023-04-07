namespace API.Entities
{
    // User Class will define how our user object will be stored (and the database AppUser)
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}