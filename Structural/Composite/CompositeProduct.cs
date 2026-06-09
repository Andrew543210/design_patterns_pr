namespace DesignPatternsApp.Structural.Composite;

public class CompositeProduct : IOrderComponent
{
    private string _title;
    private decimal _price;
    public CompositeProduct(string title, decimal price)
    {
        _title = title;
        _price = price;
    }
    public decimal CalculatePrice()
    {
        return _price;
    }

    public string GetTitle()
    {
       return _title;
    }
}