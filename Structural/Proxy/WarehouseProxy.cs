namespace DesignPatternsApp.Structural.Proxy;

public class WarehouseProxy : IWarehouseRepository
{
    private WarehouseRepository _warehouseRepository;
    private string _userRole;

    public WarehouseProxy(string userRole)
    {
        _userRole = userRole;
        _warehouseRepository = new WarehouseRepository();
    }
  public void DeleteProduct(int productId)
  {
      if (_userRole == "Admin")
      {
          
          if (_warehouseRepository == null)
          {
              Console.WriteLine("WarehouseProxy: Ініціалізуємо реальне з'єднання з БД (Lazy Loading)...");
              _warehouseRepository = new WarehouseRepository();
          }

          _warehouseRepository.DeleteProduct(productId);
      }
      else
      {
          Console.WriteLine($"WarehouseProxy: Відмовлено в доступі для ролі [{_userRole}]. Видалення ID {productId} неможливе.");
      }
  }
}