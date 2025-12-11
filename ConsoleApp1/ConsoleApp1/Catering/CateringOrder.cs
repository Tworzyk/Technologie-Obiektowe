namespace ConsoleApp1.Classes;

public class CateringOrder
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public HotelGuest Guest { get; set; } = default!;
    public Room Room { get; set; } = default!;
    public List<CateringItem> Items { get; } = new();
    public DateTime OrderTime { get; set; }
    public bool IsDelivered { get; set; }

    public decimal GetTotalPrice()
    {
        return Items.Sum(i => i.UnitPrice * i.Quantity);
    }
}