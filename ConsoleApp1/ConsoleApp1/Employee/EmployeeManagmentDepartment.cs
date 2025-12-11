namespace ConsoleApp1.Classes;

public class EmployeeManagementDepartment
{
    public List<Employee> ManagedEmployees { get; } = new();

    public void AddEmployee(Employee employee)
    {
        if (!ManagedEmployees.Contains(employee))
        {
            ManagedEmployees.Add(employee);
        }
    }

    public void DeactivateEmployee(Employee employee)
    {
        employee.IsActive = false;
    }
}