using DesignPatternsApp.Creational.AbstractFactory;
using DesignPatternsApp.Creational.FactoryMethod;

public class Program
{
    public static void Main(string[] args)
    {
        #region Factory Method Pattern
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("--- Factory Method Pattern ---");
        
        void ClientCode(Creator creator)
        {
            Console.WriteLine(creator.SomeOperation());
        }

        Console.WriteLine("App: Launched with ConcreteCreator1.");
        ClientCode(new ConcreteCreator1());

        Console.WriteLine("\nApp: Launched with ConcreteCreator2.");
        ClientCode(new ConcreteCreator2());

        #endregion

        #region AbstractFactory
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        var client = new Client();

        Console.WriteLine("--- Тестуємо першу фабрику ---");
        client.ClientMethod(new ConcreteFactory1());

        Console.WriteLine("\n--- Тестуємо другу фабрику ---");
        client.ClientMethod(new ConcreteFactory2());
        #endregion
    }
}
