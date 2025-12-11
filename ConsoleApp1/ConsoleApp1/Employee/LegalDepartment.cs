namespace ConsoleApp1.Classes;

public class LegalDepartment
{
    public List<Employee> Lawyers { get; } = new();
    public List<Contract> ReviewedContracts { get; } = new();

    public void AddEmployee(Employee employee)
    {
        if (employee.Department == Department.Legal &&
            !Lawyers.Contains(employee))
        {
            Lawyers.Add(employee);
        }
    }

    public void ReviewContract(Contract contract)
    {
        // logika weryfikacji kontraktu
        if (!ReviewedContracts.Contains(contract))
        {
            ReviewedContracts.Add(contract);
        }
    }
}