namespace ConsoleApp1.Classes;

public class SpaTreatment
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = default!;
    public TimeSpan Duration { get; set; }
    public decimal Price { get; set; }
}
