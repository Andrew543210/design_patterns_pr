namespace DesignPatternsApp.Creational.Singleton;

public class Singleton
{
    private static readonly object _lock = new();
    private Singleton()
    {
        Console.WriteLine("Creating singleton");
    }
    private static Singleton _instance;

    public static Singleton GetInstance()
    {
        if (_instance == null) // Перша перевірка (без lock)
        {
            lock (_lock)
            {
                if (_instance == null) // Друга перевірка (вже під lock)
                {
                    _instance = new Singleton();
                }
            }
        }
        return _instance;
    }

    public void DoSomething() => Console.WriteLine("Doing something");
}