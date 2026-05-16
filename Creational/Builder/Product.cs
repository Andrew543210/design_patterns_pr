namespace DesignPatternsApp.Creational.Builder;

public class Product
{
    private readonly List<string> _parts = new();
    public void Add(string part) => _parts.Add(part);
    public override string ToString() => string.Join(", ", _parts);
}