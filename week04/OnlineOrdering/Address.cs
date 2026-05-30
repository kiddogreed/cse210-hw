// Stores a mailing address — street, city, state, and country.
public class Address
{
    // Street number and name (e.g., "123 Main St")
    private string _street;

    // City name (e.g., "New York")
    private string _city;

    // State or province (e.g., "NY")
    private string _state;

    // Country name (e.g., "USA" or "Canada")
    private string _country;

    // Sets up a new address with all four parts.
    public Address(string street, string city, string state, string country)
    {
        this._street = street;
        this._city = city;
        this._state = state;
        this._country = country;
    }

    // Returns true if the country is the USA — used to decide shipping cost.
    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }

    // Builds and returns the full address as a single formatted string.
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}