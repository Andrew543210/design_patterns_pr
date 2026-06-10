using DesignPatternsApp.Creational.AbstractFactory;
using DesignPatternsApp.Creational.FactoryMethod;
using DesignPatternsApp.Creational.Prototype;
using DesignPatternsApp.Structural.Adapter;
using DesignPatternsApp.Structural.Bridge;
using DesignPatternsApp.Structural.Composite;
using DesignPatternsApp.Structural.Decorator;
using DesignPatternsApp.Structural.Facade;
using DesignPatternsApp.Structural.FlyWeight;
using Product = DesignPatternsApp.Creational.Builder.Product;
using DesignPatternsApp.Structural.Proxy;

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

        // var p1 = new Person{Name = "john",Age = 15, IdInfo = new IdInfo(123)};
        // var p2 = p1.ShallowCopy();
        // var p3 = p1.DeepCopy();
        // Console.WriteLine(p1);
        // Console.WriteLine(p2);
        // Console.WriteLine(p3);
        //
        // p1.IdInfo.IdNumber = 321;
        // Console.WriteLine(p1);
        // Console.WriteLine(p2);
        // Console.WriteLine(p3);
        #endregion

        #region Adapter

        // Adaptee adaptee1 = new Adaptee();
        //
        // ITarget target1 = new Adapter(adaptee1);
        //
        // string result = target1.GetProductJSON();
        //
        // Console.WriteLine($"[Клієнт]: Отримано фінальний результат від ITarget:{result}");

        #endregion

        #region Bridge

        // Console.WriteLine("\n--- Bridge ---");
        //
        // IDevice myTv = new Tv();
        //
        // Console.WriteLine("\n[Клієнт]: Беремо звичайний пульт...");
        // RemoteControl basicRemote = new RemoteControl(myTv);
        // basicRemote.TogglePower();
        //
        // Console.WriteLine("\n[Клієнт]: Беремо просунутий пульт для того самого ТВ...");
        // AdvancedRemoteControl advancedRemote = new AdvancedRemoteControl(myTv);
        // advancedRemote.Mute(); // Звук скинеться до 0
        //
        // basicRemote.TogglePower();

        #endregion

        #region Composite

        // Console.WriteLine("\n--- Тест патерну Composite ---");
        //
        // IOrderComponent phone = new CompositeProduct("iPhone 15", 1000);
        // IOrderComponent casePhone = new CompositeProduct("Чохол для iPhone", 20);
        // IOrderComponent laptop = new CompositeProduct("MacBook Pro", 2500);
        //
        // Box phoneBox = new Box("Коробка з телефоном та чохлом");
        // phoneBox.Add(phone);
        // phoneBox.Add(casePhone);
        //
        //
        // Box mainBox = new Box("Головна коробка замовлення");
        // mainBox.Add(laptop);    
        // mainBox.Add(phoneBox);  
        //
        //
        // Console.WriteLine($"[Клієнт]: Рахуємо загальну вартість усього дерева замовлення...");
        // decimal finalPrice = mainBox.CalculatePrice();
        //
        // Console.WriteLine($"Об'єкт: {mainBox.GetTitle()}");
        // Console.WriteLine($"Загальна сума до сплати: {finalPrice} USD");

        #endregion

        #region Decorator

        Console.WriteLine("\n--- Тест патерну Decorator ---");
        
        ICoffee myCoffee = new SimpleCoffee();
        Console.WriteLine($"Напій: {myCoffee.GetDescription()} | Ціна: {myCoffee.GetCost()}$");
        
        myCoffee = new MilkDecorator(myCoffee);
        Console.WriteLine($"Напій: {myCoffee.GetDescription()} | Ціна: {myCoffee.GetCost()}$");
        
        myCoffee = new SyrupDecorator(myCoffee);
        Console.WriteLine($"Напій: {myCoffee.GetDescription()} | Ціна: {myCoffee.GetCost()}$");
        
        myCoffee = new MilkDecorator(myCoffee);
        Console.WriteLine($"Напій: {myCoffee.GetDescription()} | Ціна: {myCoffee.GetCost()}$");

        #endregion

        #region Facade

        Console.WriteLine("\n--- Тест патерну Facade ---");
        
        WarehouseService warehouse = new WarehouseService();
        PaymentService payment = new PaymentService();
        NotificationService notification = new NotificationService();


        MarketFacade market = new MarketFacade(notification, payment, warehouse);
        
        market.PlaceOrder("Smartphone", 2, 500, "1234-5678-9876-5432");

        #endregion

        #region Flyweight

         Console.WriteLine("\n--- Тест патерну Flyweight ---");

         FlyweightFactory factory = new FlyweightFactory();

         Car car = new("Andrew", 7777);
         
         var flyweight1 = factory.GetFlyweight("Ford", "Mustang", "Red");
         flyweight1.Display(car);
         var flyweight2 = factory.GetFlyweight("Toyota", "Camry", "Blue");
         flyweight2.Display(car);
         var flyweight3 = factory.GetFlyweight("Ford", "Mustang", "Red");
         Car car2 = new("John", 8888);
         flyweight3.Display(car2);
         


         #endregion
         
        #region Proxy

        Console.WriteLine("\n--- Тест патерну Proxy ---");
        
        Console.WriteLine("Клієнт: Намагаюся видалити товар як звичайний Користувач...");
        IWarehouseRepository proxyForUser = new WarehouseProxy("User");
        proxyForUser.DeleteProduct(101); 

        Console.WriteLine(new string('-', 40));
        
        Console.WriteLine("Клієнт: Намагаюся видалити товар як Адміністратор...");
        IWarehouseRepository proxyForAdmin = new WarehouseProxy("Admin");
        
        proxyForAdmin.DeleteProduct(101); 

        Console.WriteLine("\nКлієнт: Роблю повторний запит на видалення іншого товару...");
        proxyForAdmin.DeleteProduct(202);
        #endregion
            
    }
}


