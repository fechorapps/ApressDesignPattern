namespace ApressDesignPattern.SOLID._2._OCP.Zillow.Before;

public class SavedSearch
{
    public SavedSearch(string preferredLocation, int maxPrice, int minNumberOfRooms)
    {
        PreferredLocation = preferredLocation;
        MaxPrice = maxPrice;
        MinNumberOfRooms = minNumberOfRooms;
    }

    public string PreferredLocation { get; private set; } = string.Empty;
    public int MaxPrice { get; private set; }
    public int MinNumberOfRooms { get; private set; }        
}
