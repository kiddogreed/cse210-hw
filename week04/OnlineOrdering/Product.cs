// Represents a single item that can be purchased — like one row in a shopping cart.
public class Product
{
    // Name of the product (e.g., "Laptop")
    private string _name;

    // Unique identifier for the product (e.g., "A101")
    private string _productId;

    // Price per unit (e.g., 999.99)
    private decimal _price;

    // How many of this product are being ordered.
    private int _quantity;

    // Creates a new product with name, ID, price, and quantity.
    public Product(string name, string productId, decimal price, int quantity)
    {
        this._name = name;
        this._productId = productId;
        this._price = price;
        this._quantity = quantity;
    }

    // Calculates cost for this line item: price × quantity.
    public decimal GetTotalCost()
    {
        return _price * _quantity;
    }

    // Returns a short label used on the packing slip (name + product ID).
    public string GetPackingLabel()
    {
        return $"{_name} (ID: {_productId})";
    }

}