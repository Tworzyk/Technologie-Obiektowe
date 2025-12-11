namespace ConsoleApp1.Classes;

public class SystemAdministrator : Employee
{
    public SystemAdministrator()
    {
        Department = Department.Management;
        Role = EmployeeRole.SystemAdministrator;
    }

    public void CreateUser(SystemUser user)
    {
        // tworzenie użytkownika systemu
        // ToDo: implementacja (np. zapis do bazy)
    }

    public void AssignPermission(SystemUser user, string permission)
    {
        if (!user.Permissions.Contains(permission))
        {
            user.Permissions.Add(permission);
        }
    }
}