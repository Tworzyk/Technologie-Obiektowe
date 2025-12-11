namespace ConsoleApp1.Classes;

public class HRDepartment
{
    public List<Employee> HREmployees { get; } = new();
    public List<Contract> Contracts { get; } = new();

    public void AddEmployee(Employee employee)
    {
        if (employee.Department == Department.HR &&
            !HREmployees.Contains(employee))
        {
            HREmployees.Add(employee);
        }
    }

    public void HireEmployee(Employee employee, Contract contract)
    {
        employee.IsActive = true;
        if (!Contracts.Contains(contract))
        {
            Contracts.Add(contract);
        }
    }

    public void FireEmployee(Employee employee)
    {
        employee.IsActive = false;
    }
}