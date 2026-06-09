namespace DesignPatternsApp.Structural.FlyWeight;

public class FlyweightFactory
{
    private readonly Dictionary<string, Flyweight> _flyweights = new();

    public string GetKey(string company, string model, string color)
    {
        return $"_{company}_{model}_{color}";
    }
    public Flyweight GetFlyweight(string company, string model, string color)
    {
        var key = GetKey(company, model, color);
        if (!_flyweights.ContainsKey(key))
        {
            Console.WriteLine($"FlyweightFactory: Ключ не знайдено. Створюємо новий Flyweight для [{company} {model} {color}].");
            _flyweights[key] = new Flyweight(company, model, color);
        }
        return _flyweights[key];
    }
}