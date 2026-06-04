using DesignPatternsApp.Creational.AbstractFactory;
using DesignPatternsApp.Creational.Builder;
using DesignPatternsApp.Creational.FactoryMethod;
using DesignPatternsApp.Creational.Prototype;
using DesignPatternsApp.Structural.Adapter;

public class Program
{
    public static void Main(string[] args)
    {
        #region Factory Method Pattern
        
        // Console.ForegroundColor = ConsoleColor.Green;
        // Console.WriteLine("--- Factory Method Pattern ---");
        //
        // void ClientCode(Creator creator)
        // {
        //     Console.WriteLine(creator.SomeOperation());
        // }
        //
        // Console.WriteLine("App: Launched with ConcreteCreator1.");
        // ClientCode(new ConcreteCreator1());
        //
        // Console.WriteLine("\nApp: Launched with ConcreteCreator2.");
        // ClientCode(new ConcreteCreator2());

        #endregion

        #region AbstractFactory
        // Console.ForegroundColor = ConsoleColor.DarkYellow;
        // var client = new Client();
        //
        // Console.WriteLine("--- Тестуємо першу фабрику ---");
        // client.ClientMethod(new ConcreteFactory1());
        //
        // Console.WriteLine("\n--- Тестуємо другу фабрику ---");
        // client.ClientMethod(new ConcreteFactory2());
        #endregion

        #region Builder
        // Console.ForegroundColor = ConsoleColor.Cyan;
        // var builder = new ConcreteBuilder();
        // var director = new Director(builder);
        // director.Construct();
        // var product = builder.GetProduct();
        // Console.WriteLine(product);
        #endregion

        #region Prototype

        var p1 = new Person{Name = "john",Age = 15, IdInfo = new IdInfo(123)};
        var p2 = p1.ShallowCopy();
        var p3 = p1.DeepCopy();
        Console.WriteLine(p1);
        Console.WriteLine(p2);
        Console.WriteLine(p3);
        
        p1.IdInfo.IdNumber = 321;
        Console.WriteLine(p1);
        Console.WriteLine(p2);
        Console.WriteLine(p3);
        #endregion

        #region Adapter

        Adaptee adaptee1 = new Adaptee();
        
        ITarget target1 = new Adapter(adaptee1);
        
        string result = target1.GetProductJSON();

        Console.WriteLine($"[Клієнт]: Отримано фінальний результат від ITarget:{result}");

        #endregion
        
    }
}
