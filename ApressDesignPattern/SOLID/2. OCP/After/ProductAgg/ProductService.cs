using ApressDesignPattern.SOLID._2._OCP.After.ProductAgg.Criterias;
using ApressDesignPattern.SOLID._2._OCP.After.ProductAgg.Entities;

namespace ApressDesignPattern.SOLID._2._OCP.After.ProductAgg;

public class ProductService
{
    public void Filter()
    {
        var apple = new Product("Apple", Color.Green, Size.Large);
        var tree = new Product("Tree", Color.Green, Size.Large);
        var house = new Product("House", Color.Blue, Size.Medium);

        Product[] products = { apple, tree, house };

        var pf = new ProductFilter();

        //var largeGreenSpec = new SizeSpecification(Size.Large)
        //                   & new ColorSpecification(Color.Green);

        //var largeGreenSpec = new AndSpecification<Product>(new SizeSpecification(Size.Large),
        //                                                   new ColorSpecification(Color.Green));
        

        var largeGreenSpec = Color.Green.And(Size.Large);

        var temp = products.Where(p => largeGreenSpec.IsSatisfied(p)).ToList();

        foreach (var p in pf.Filter(products, largeGreenSpec))
            Console.WriteLine($"{p.Name} is large and green");
    }
}
