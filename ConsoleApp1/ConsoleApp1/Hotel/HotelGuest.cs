using ConsoleApp1.Classes;

namespace ConsoleApp1;

public class HotelGuest : Person
{
    public string DocumentNumber { get; set; } = default!;
    public List<Reservation> Reservations { get; } = new();
    public List<Payment> Payments { get; } = new();

    public void AddReservation(Reservation reservation)
    {
        Reservations.Add(reservation);
    }
}