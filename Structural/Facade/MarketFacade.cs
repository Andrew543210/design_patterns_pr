namespace DesignPatternsApp.Structural.Facade;

public class MarketFacade
{
    private readonly NotificationService _notificationService;
    private readonly PaymentService _paymentService;
    private readonly WarehouseService _warehouseService;

    public MarketFacade(NotificationService notificationService, PaymentService paymentService,
        WarehouseService warehouseService)

    {
        _notificationService = notificationService;
        _paymentService = paymentService;
        _warehouseService = warehouseService;
    }

    public void PlaceOrder(string productName, int quantity, decimal price, string cardNumber)
    {
        _warehouseService.CheckInventory(productName);
        _warehouseService.RemoveProduct(productName, quantity);
        string orderID = _paymentService.PayByCard(cardNumber, price * quantity);
        _notificationService.SendOrderConfirmation(orderID);
        
    }
}

    

