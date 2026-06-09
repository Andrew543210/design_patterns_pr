namespace DesignPatternsApp.Structural.Decorator;

public class SyrupDecorator : CoffeeDecorator
{
    public SyrupDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override string GetDescription()
    {
        return $"{_coffee.GetDescription()} with syrup";
    }

    public override double GetCost()
    {
        return _coffee.GetCost() + 10.0;
    }
}