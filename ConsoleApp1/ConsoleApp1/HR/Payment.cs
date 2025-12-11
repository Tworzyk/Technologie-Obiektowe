namespace ConsoleApp1.Classes;

public class Payment
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public HotelGuest Guest { get; set; } = default!;
    public decimal Amount { get; set; }
    public DateTime PaidAt { get; set; }
    public string Method { get; set; } = default!; // karta, gotówka, przelew
}