namespace ConsoleApp1.Classes;

public class ReceptionStaff : Employee
{
    public ReceptionStaff()
    {
        Department = Department.Reception;
        Role = EmployeeRole.Receptionist;
    }

    public void CheckInGuest(HotelGuest guest, Reservation reservation)
    {
        // logika check-in
        reservation.Guest = guest;
        reservation.Room.IsOccupied = true;
        if (!guest.Reservations.Contains(reservation))
        {
            guest.Reservations.Add(reservation);
        }
    }

    public void CheckOutGuest(HotelGuest guest)
    {
        // logika check-out
        var lastReservation = guest.Reservations
            .OrderByDescending(r => r.CheckIn)
            .FirstOrDefault();

        if (lastReservation != null)
        {
            lastReservation.Room.IsOccupied = false;
        }
    }
}