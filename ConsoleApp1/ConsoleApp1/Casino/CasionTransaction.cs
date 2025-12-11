namespace ConsoleApp1.Classes;


public class CasinoTransaction
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public CasinoPlayerAccount Account { get; set; } = default!;
    public decimal Amount { get; set; }
    public DateTime Time { get; set; }
    public string Description { get; set; } = default!;
}