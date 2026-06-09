namespace DesignPatternsApp.Structural.Facade;

public class PaymentService
{
    public string PayByCard(string cardNumber, decimal amount)
    {
        Console.WriteLine($"Paying {amount} by card {cardNumber}");
        return Guid.NewGuid().ToString();
    }

    public string PayByPayPal(string email, decimal amount)
    {
        Console.WriteLine($"Paying {amount} by PayPal account {email}");
        return Guid.NewGuid().ToString();
    }

    public string PayByBitcoin(string walletAddress, decimal amount)
    {
        Console.WriteLine($"Paying {amount} by Bitcoin wallet {walletAddress}");
        return Guid.NewGuid().ToString();
        
    }
}