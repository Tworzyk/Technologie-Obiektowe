namespace ConsoleApp1.Classes;

public class MarketingDepartment
{
    public List<Employee> Employees { get; } = new();
    public List<MarketingCampaign> Campaigns { get; } = new();

    public void AddEmployee(Employee employee)
    {
        if (employee.Department == Department.Marketing &&
            !Employees.Contains(employee))
        {
            Employees.Add(employee);
        }
    }

    public void CreateCampaign(MarketingCampaign campaign)
    {
        Campaigns.Add(campaign);
    }
}