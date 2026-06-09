namespace DesignPatternsApp.Structural.Facade;

public class NotificationService
{
    public void SendOrderConfirmation(string orderId)
    {
       
        Console.WriteLine($"Order confirmation sent for Order ID: {orderId}");
    }
}