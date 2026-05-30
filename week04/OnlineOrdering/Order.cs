// Represents a customer's order — bundles a customer with their list of products.
public class Order
{
    // All the products included in this order.
    private List<Product> _products;

    // Who placed this order.
    private Customer _customer;

    // Creates an order for a given customer and their list of products.
    public Order(Customer customer, List<Product> products)
    {
        this._customer = customer;
        this._products = products;
    }

    // Adds up the cost of every product, then adds shipping.
    // USA customers pay $5 shipping; everyone else pays $35.
    public decimal CalculateTotalCost()
    {
        decimal total = 0;
        foreach (Product p in _products)
        {
            total += p.GetTotalCost();
        }

        decimal shippingCost = _customer.LivesInUSA() ? 5 : 35;
        return total + shippingCost;
    }

    // Builds a packing slip listing every product name and ID in the order.
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product p in _products)
        {
            label += "- " + p.GetPackingLabel() + "\n";
        }
        return label;
    }

    // Builds a shipping label with the customer's name and full mailing address.
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddressString()}";
    }

}