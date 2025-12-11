using ConsoleApp1.Classes;

namespace ConsoleApp1;

public class Employee : SystemUser
{
    public Department Department { get; set; }
    public EmployeeRole Role { get; set; }
    public DateTime HireDate { get; set; }
    public decimal BaseSalary { get; set; }
    public bool IsActive { get; set; } = true;
}