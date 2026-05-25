// Represents a single item that can be purchased — like one row in a shopping cart.
public class Product
{
    // Name of the product (e.g., "Laptop")
    private string name;

    // Unique identifier for the product (e.g., "A101")
    private string productId;

    // Price per unit (e.g., 999.99)
    private decimal price;

    // How many of this product are being ordered.
    private int quantity;

    // Creates a new product with name, ID, price, and quantity.
    public Product(string name, string productId, decimal price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    // Calculates cost for this line item: price × quantity.
    public decimal GetTotalCost()
    {
        return price * quantity;
    }

    // Returns a short label used on the packing slip (name + product ID).
    public string GetPackingLabel()
    {
        return $"{name} (ID: {productId})";
    }

}