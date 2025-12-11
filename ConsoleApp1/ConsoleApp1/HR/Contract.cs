namespace ConsoleApp1.Classes;

public class Contract
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Employee Employee { get; set; } = default!;
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Terms { get; set; } = default!;
}