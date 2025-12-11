namespace ConsoleApp1.Classes;

public class CateringStaff : Employee
{
    public CateringStaff()
    {
        Department = Department.Catering;
        Role = EmployeeRole.CateringStaff;
    }

    public void RegisterOrder(Room room, CateringOrder order)
    {
        // logika obsługi zamówienia
        order.Room = room;
        order.IsDelivered = false;
    }
}