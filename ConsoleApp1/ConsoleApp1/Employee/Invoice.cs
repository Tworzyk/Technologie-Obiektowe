namespace ConsoleApp1.Classes;

public class Invoice
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public HotelGuest Guest { get; set; } = default!;
    public List<InvoiceItem> Items { get; } = new();
    public DateTime IssueDate { get; set; }
    public string Number { get; set; } = default!;

    public decimal TotalAmount => CalculateTotal();

    private decimal CalculateTotal()
    {
        decimal sum = 0;
        foreach (var item in Items)
        {
            sum += item.Amount;
        }
        return sum;
    }
}