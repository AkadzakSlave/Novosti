namespace Models;

public class User
{
    public string Login { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public UserRole Role { get; set; }
    public string Comment { get; set; }
    public int Rating { get; set; }
}

public enum UserRole
{
    Admin,
    User,
    Guest
}
