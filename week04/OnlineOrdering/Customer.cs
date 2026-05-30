// Represents a customer who places an order — stores their name and address.
public class Customer
{
    // Full name of the customer (e.g., "Alice Johnson")
    private string _name;

    // Where the customer lives — links to an Address object.
    private Address _address;

    // Sets up a new customer with a name and address.
    public Customer(string name, Address address)
    {
        this._name = name;
        this._address = address;
    }

    // Returns the customer's name.
    public string GetName()
    {
        return _name;
    }

    // Checks if the customer lives in the USA — affects shipping cost.
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    // Returns the customer's full address as a formatted string.
    public string GetAddressString()
    {
        return _address.GetFullAddress();
    }

}