namespace Models.Services;

public class PermissionProvider
{
    public bool HasPermission(User user, string permission)
    {
        switch (user.Role)
        {
            case UserRole.Admin:
                return true;
            case UserRole.User:
                return permission != "AdminOnly";
            case UserRole.Guest:
                return false;
            default:
                return false;
        }
    }
}
