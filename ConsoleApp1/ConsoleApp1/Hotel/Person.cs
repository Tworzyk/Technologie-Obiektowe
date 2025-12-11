namespace ConsoleApp1.Classes;

public abstract class Person
{
    public string Name { get; set; } = default!;
    public string Surname { get; set; } = default!;

    public List<string> Permissions { get; } = new();

    public bool HasPermission(string permission) =>
        Permissions.Contains(permission);
}