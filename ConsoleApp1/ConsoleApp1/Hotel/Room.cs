namespace ConsoleApp1.Classes;

public class Room
{
    public int Number { get; set; }
    public string Type { get; set; } = default!; // np. Standard, Suite
    public bool IsOccupied { get; set; }
    public bool IsClean { get; set; } = true;
    public decimal PricePerNight { get; set; }
}