namespace DesignPatternsApp.Structural.Decorator;

public abstract class CoffeeDecorator : ICoffee
{
    protected ICoffee _coffee;
    public CoffeeDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }
    public virtual double GetCost()
    {
       return _coffee.GetCost();
    }

    public virtual string GetDescription()
    {
        return _coffee.GetDescription();
    }
}