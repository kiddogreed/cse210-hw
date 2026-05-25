// Stores a mailing address — street, city, state, and country.
public class Address
{
    // Street number and name (e.g., "123 Main St")
    private string street;

    // City name (e.g., "New York")
    private string city;

    // State or province (e.g., "NY")
    private string state;

    // Country name (e.g., "USA" or "Canada")
    private string country;

    // Sets up a new address with all four parts.
    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    // Returns true if the country is the USA — used to decide shipping cost.
    public bool IsInUSA()
    {
        return country.ToLower() == "usa";
    }

    // Builds and returns the full address as a single formatted string.
    public string GetFullAddress()
    {
        return $"{street}\n{city}, {state}\n{country}";
    }
}