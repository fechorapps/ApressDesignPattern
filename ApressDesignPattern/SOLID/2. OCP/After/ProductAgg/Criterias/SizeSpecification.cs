using ApressDesignPattern.SOLID._2._OCP.After.ProductAgg.Entities;

namespace ApressDesignPattern.SOLID._2._OCP.After.ProductAgg.Criterias;

public class SizeSpecification : Specification<Product>
{
    public Size Size { get; private set; }
    public SizeSpecification(Size size) => Size = size;
    public override bool IsSatisfied(Product product) => product.Size == Size;
}