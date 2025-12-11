namespace ConsoleApp1.Classes;

public class HousekeepingStaff : Employee
{
    public HousekeepingStaff()
    {
        Department = Department.Housekeeping;
        Role = EmployeeRole.Housekeeper;
    }

    public void MarkRoomAsClean(Room room)
    {
        room.IsClean = true;
    }
}