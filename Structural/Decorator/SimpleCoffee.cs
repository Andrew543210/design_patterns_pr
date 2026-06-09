namespace DesignPatternsApp.Structural.Decorator;

public class SimpleCoffee : ICoffee
{
    public double GetCost()
    {
        return 50.0;
    }

    public string GetDescription()
    {
       return "Simple coffee";
    }
}