namespace ConsoleApp1.Classes;

public class Reservation
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public HotelGuest Guest { get; set; } = default!;
    public Room Room { get; set; } = default!;
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }
    public bool IsPaid { get; set; }

    public int GetNumberOfNights()
    {
        return (CheckOut.Date - CheckIn.Date).Days;
    }

    public decimal GetTotalPrice()
    {
        return GetNumberOfNights() * Room.PricePerNight;
    }
}