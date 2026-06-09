namespace DesignPatternsApp.Structural.FlyWeight;

public class Car
{
    public string Owner { get; set; }
    public int Number { get; set; }
    public Car(string owner, int number)
    {
        Owner = owner;
        Number = number;
    }
}