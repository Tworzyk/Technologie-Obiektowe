namespace ConsoleApp1.Classes;

public class CasinoGame
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public CasinoGameType GameType { get; set; }
    public string Name { get; set; } = default!;
    public bool IsActive { get; set; } = true;
}