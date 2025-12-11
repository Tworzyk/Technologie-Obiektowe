namespace ConsoleApp1.Classes;

public class MiniLasVegas
{
    public List<CasinoGame> Games { get; } = new();
    public List<CasinoPlayerAccount> Accounts { get; } = new();

    public CasinoPlayerAccount CreateAccount(HotelGuest guest)
    {
        var account = new CasinoPlayerAccount
        {
            Guest = guest
        };
        Accounts.Add(account);
        return account;
    }

    public CasinoPlayerAccount? GetAccountForGuest(HotelGuest guest)
    {
        return Accounts.FirstOrDefault(a => a.Guest == guest);
    }
}