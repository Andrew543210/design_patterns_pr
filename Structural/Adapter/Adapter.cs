namespace DesignPatternsApp.Structural.Adapter;

public class Adapter : ITarget
{
    private readonly Adaptee _adaptee;
    public Adapter(Adaptee adaptee)
    {
        this._adaptee = adaptee;
    }
    public string GetProductJSON()
    {
       string productXML = this._adaptee.GetProductXML();
       
       Console.WriteLine($"[Адаптер]: Отримано XML: {productXML}");
       Console.WriteLine("[Адаптер]: Конвертуємо XML в JSON...");
    
      
       return "{ \"id\": 1, \"name\": \"Laptop\", \"price\": 1200 }";
    }
}