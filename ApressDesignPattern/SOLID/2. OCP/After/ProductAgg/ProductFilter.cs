using ApressDesignPattern.SOLID._2._OCP.After.Base.Specification;
using ApressDesignPattern.SOLID._2._OCP.After.ProductAgg.Entities;

namespace ApressDesignPattern.SOLID._2._OCP.After.ProductAgg
{
    public class ProductFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, Specification<Product> spec)
        {
            foreach (var i in items)
                if (spec.IsSatisfied(i))
                    yield return i;
        }
    }
}
