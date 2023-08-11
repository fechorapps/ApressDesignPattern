namespace ApressDesignPattern.SOLID._2._OCP.Zillow.Before;

public class MatchingManager
{
    public List<SavedSearch> GetMatchingSavedSearches(Customer customer, Property newProperty)
    {
        List<SavedSearch> matchingSearches = new List<SavedSearch>();

        foreach (SavedSearch search in customer.SavedSearches)
        {
            if (search.PreferredLocation == newProperty.Location &&
                search.MaxPrice >= newProperty.Price &&
                search.MinNumberOfRooms <= newProperty.NumberOfRooms)
            {
                matchingSearches.Add(search);
            }
        }

        return matchingSearches;
    }
}
