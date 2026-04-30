using DesignPatternsApp.Creational.FactoryMethod;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("--- Factory Method Pattern ---");

// Клієнтська логіка
void ClientCode(Creator creator)
{
    Console.WriteLine(creator.SomeOperation());
}

Console.WriteLine("App: Launched with ConcreteCreator1.");
ClientCode(new ConcreteCreator1());

Console.WriteLine("\nApp: Launched with ConcreteCreator2.");
ClientCode(new ConcreteCreator2());
