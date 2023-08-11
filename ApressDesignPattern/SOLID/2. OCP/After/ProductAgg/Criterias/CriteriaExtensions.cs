using ApressDesignPattern.SOLID._2._OCP.After.Base.Specification;
using ApressDesignPattern.SOLID._2._OCP.After.ProductAgg.Entities;

namespace ApressDesignPattern.SOLID._2._OCP.After.ProductAgg.Criterias
{
    public static class CriteriaExtensions
    {
        public static ISpecification<Product> And(this Color color,Size size) =>
            new AndSpecification<Product>(
                new ColorSpecification(color),
                new SizeSpecification(size));
        

        public static ISpecification<Product> Or(this Color color, Size size) => 
            new OrSpecification<Product>(
                new ColorSpecification(color),
                new SizeSpecification(size));
        
    }
}
