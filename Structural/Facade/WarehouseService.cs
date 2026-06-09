namespace DesignPatternsApp.Structural.Facade;

public class WarehouseService
{
    public void AddProduct(string name, int quantity)
    {
        Console.WriteLine($"Adding {quantity} of {name} to the warehouse.");
    }

    public void RemoveProduct(string name, int quantity)
    {
        Console.WriteLine($"Removing {quantity} of {name} from the warehouse.");
    }

    public void CheckInventory(string name)
    {
        Console.WriteLine($"Checking inventory for {name}.");
    }
}