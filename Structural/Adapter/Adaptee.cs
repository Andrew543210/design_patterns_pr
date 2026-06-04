namespace DesignPatternsApp.Structural.Adapter;

public class Adaptee
{
    public string GetProductXML()
    {
        return "<product><id>1</id><name>Laptop</name><price>1200</price></product>";
    }
}