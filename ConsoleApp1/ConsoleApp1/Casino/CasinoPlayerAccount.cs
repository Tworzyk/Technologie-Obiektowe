namespace ConsoleApp1.Classes;

public class CasinoPlayerAccount
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public HotelGuest Guest { get; set; } = default!;
    public decimal Balance { get; private set; }

    public void Credit(decimal amount)
    {
        Balance += amount;
    }

    public void Debit(decimal amount)
    {
        if (amount > Balance)
            throw new InvalidOperationException("Niewystarczające środki na koncie kasynowym.");

        Balance -= amount;
    }
}