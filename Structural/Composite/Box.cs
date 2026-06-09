namespace DesignPatternsApp.Structural.Composite;

public class Box :IOrderComponent
{
    private string _title;
    private List<IOrderComponent> _orderComponents = new ();

    public Box(string title)
    {
       _title = title; 
    }
    public decimal CalculatePrice()
    {
        decimal totalPrice = 0;
        foreach (var component in _orderComponents)
        {
            totalPrice += component.CalculatePrice();
        }
        return totalPrice;
    }

    public string GetTitle()
    {
        return _title;
    }
    public void Add(IOrderComponent orderComponent)
    {
        _orderComponents.Add(orderComponent);
    }
    public void Remove(IOrderComponent orderComponent)
    {
        _orderComponents.Remove(orderComponent);
    }
}