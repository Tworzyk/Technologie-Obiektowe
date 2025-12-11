namespace ConsoleApp1.Classes;

public abstract class SystemUser : Person
{
    public string Username { get; set; } = default!;
    public string PasswordHash { get; set; } = default!;

    public List<string> Permissions { get; } = new();

    public bool HasPermission(string permission) =>
        Permissions.Contains(permission);
}
