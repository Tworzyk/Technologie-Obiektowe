namespace ConsoleApp1.Classes;

public class SpaWellnessDepartment
{
    public List<Employee> Employees { get; } = new();
    public List<SpaTreatment> Treatments { get; } = new();

    public void AddEmployee(Employee employee)
    {
        if (employee.Department == Department.SpaWellness &&
            !Employees.Contains(employee))
        {
            Employees.Add(employee);
        }
    }

    public void AddTreatment(SpaTreatment treatment)
    {
        Treatments.Add(treatment);
    }
}