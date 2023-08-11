namespace ApressDesignPattern.SOLID._2._OCP.Before
{
    public class ProductService
    {
        public void Filter()
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };

            var pf = new ProductFilter();

            var productsFilters = pf.FilterByColor(products, Color.Green);

            foreach (var p in productsFilters)
                Console.WriteLine($" - {p.Name} is green");
        }
    }
}
