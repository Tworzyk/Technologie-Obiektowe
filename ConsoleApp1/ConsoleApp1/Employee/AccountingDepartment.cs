namespace ConsoleApp1.Classes;

public class AccountingDepartment
{
    public List<Employee> Employees { get; } = new();
    public List<Invoice> Invoices { get; } = new();

    public void AddEmployee(Employee employee)
    {
        if (employee.Department == Department.Accounting &&
            !Employees.Contains(employee))
        {
            Employees.Add(employee);
        }
    }

    public void RegisterInvoice(Invoice invoice)
    {
        Invoices.Add(invoice);
    }
}