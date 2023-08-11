namespace ApressDesignPattern.SOLID._2._OCP.Zillow.Before;

public class Customer
{
    public Customer(int id)
    {
        Id = id;            
    }

    public int Id { get; set; }
    public List<SavedSearch> SavedSearches { get; set; } = new();
}
