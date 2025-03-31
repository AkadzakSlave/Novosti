namespace Models.Services;

public class UsersStorage
{
    private List<User> _users = [];

    public User? GetUserByLogin(string login)
    {
       return _users.FirstOrDefault(x=> string.Equals(x.Login, login, StringComparison.CurrentCultureIgnoreCase));
    }

    public void AddUser(User user)
    {
        _users.Add(user);
    }
    
}