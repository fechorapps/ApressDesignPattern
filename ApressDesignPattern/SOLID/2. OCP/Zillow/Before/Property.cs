namespace ApressDesignPattern.SOLID._2._OCP.Zillow.Before;

public class Property
{
    public Property(string location, int price, int numberOfRooms)
    {
        Location = location;
        Price = price;
        NumberOfRooms = numberOfRooms;
    }

    public string Location { get; private set; } = string.Empty;
    public int Price { get; private set; }
    public int NumberOfRooms { get; private set; }        
}
