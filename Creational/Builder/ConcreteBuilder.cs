namespace DesignPatternsApp.Creational.Builder;

public class ConcreteBuilder : IBuilder
{
    private Product _product = new();
    public ConcreteBuilder()
    {
        this.Reset();
    }
    public void Reset() => this._product = new Product();
    public void BuildPartA() => this._product.Add("PartA");
    public void BuildPartB() => this._product.Add("PartB");
    public void BuildPartC() => this._product.Add("PartC");

    public Product GetProduct()
    {
        Product result = this._product;
        this.Reset();
        return result;
    }
}