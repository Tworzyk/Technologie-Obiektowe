namespace ConsoleApp1.Classes;

public class SecurityStaff : Employee
{
    public SecurityStaff()
    {
        Department = Department.Security;
        Role = EmployeeRole.SecurityGuard;
    }

    public void LogIncident(string description)
    {
        // zapisanie incydentu ochrony (log, baza danych, itp.)
        // ToDo: implementacja
    }
}