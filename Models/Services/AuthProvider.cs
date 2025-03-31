namespace Models.Services;

public class AuthProvider(UsersStorage usersStorage)
{
    private User? _currentUser;

    public void Register(User credentialsR, UserRole role)
    {
        var user = usersStorage.GetUserByLogin(credentialsR.Login);
        if (user != null)
        {
            throw new Exception("Пользователь с таким логином уже существует.");
        }
        _currentUser = new User()
        {
            Login = credentialsR.Login,
            Password = credentialsR.Password,
            Name = credentialsR.Name,
            Role = role
        };
        usersStorage.AddUser(_currentUser);
    }
    public void Login(User credentialsL)
    {
        var user = usersStorage.GetUserByLogin(credentialsL.Login);
        if (user == null || user.Password != credentialsL.Password || user.Login != credentialsL.Login) throw new Exception("Неверный лог или пароль");
        _currentUser = user;
    }
    public void Logout()
    {
        _currentUser = null;
    }

    public User? GetCurrentUser()
    {
        return _currentUser;
    }
}