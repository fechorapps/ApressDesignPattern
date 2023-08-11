namespace ApressDesignPattern.SOLID._2._OCP.After.ProductAgg.Entities;

public class Product
{
    public string Name { get; private set; } = string.Empty;
    public Color Color { get; private set; }
    public Size Size { get; private set; }       

    public Product(string name, Color color, Size size)
    {
        Name = name;
        Color = color;
        Size = size;
    }
}
