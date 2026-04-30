namespace DesignPatternsApp.Creational.FactoryMethod;

class ConcreteCreator1 : Creator
{
    public override IProduct FactoryMethod() => new ConcreteProduct1();
}

class ConcreteCreator2 : Creator
{
    public override IProduct FactoryMethod() => new ConcreteProduct2();
}