namespace DesignPatternsApp.Structural.Proxy;

public class WarehouseRepository : IWarehouseRepository
{
    public void DeleteProduct(int productId)
    {
        Console.WriteLine($"Deleting product with ID: {productId} from DB");
    }
}