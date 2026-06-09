namespace DesignPatternsApp.Structural.Decorator;

public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override double GetCost()
    {
        return _coffee.GetCost() + 15.0;
    }

    public override string GetDescription()
    {
        return _coffee.GetDescription() + ", Milk";
    }
}
