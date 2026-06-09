namespace DesignPatternsApp.Structural.FlyWeight;

public class Flyweight
{
    private string _company;
    private string _model;
    private string _color;

    public Flyweight(string company, string model, string color)
    {
        _company = company;
        _model = model;
        _color = color;
    }
    public void Display(Car uniqueState)
    {
        Console.WriteLine($"Car: {_company} {_model} {_color} | Owner: {uniqueState.Owner}, Number: {uniqueState.Number}");
    }
    
}