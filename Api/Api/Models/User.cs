namespace Api.Models
{
    public enum userRole
    {
        user,
        admin
    }
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string? Email { get; set; } = null;
        public string Password { get; set; }

        public userRole Role { get; set; } = userRole.user;

    }
}
