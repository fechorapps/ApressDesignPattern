using ApressDesignPattern.SOLID._2._OCP.After.ProductAgg.Entities;

namespace ApressDesignPattern.SOLID._2._OCP.After.ProductAgg.Criterias;

public class ColorSpecification : Specification<Product>
{
    public Color Color { get; private set; }
    public ColorSpecification(Color color) => Color = color;
    public override bool IsSatisfied(Product product) => product.Color == Color;
}
