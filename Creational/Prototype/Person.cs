namespace DesignPatternsApp.Creational.Prototype;

public class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
    public IdInfo IdInfo { get; set; }

    public Person ShallowCopy()
    {
        return (Person)this.MemberwiseClone();
    }

    public override string ToString()
    {
        return $"{this.Name} {this.Age} {this.IdInfo.IdNumber}";
    }

    public Person DeepCopy()
    {
        var p1 = (Person)this.MemberwiseClone();
        IdInfo idinfo1 = new IdInfo(this.IdInfo.IdNumber);
        p1.IdInfo = idinfo1;
        return p1;
    }
}