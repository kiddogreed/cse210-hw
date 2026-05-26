using System;

// Entry point — builds sample orders and prints packing slips, shipping labels, and totals.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");


        // Two sample addresses — one in the USA, one in Canada.
         Address addr1 = new Address("1729 Evang", "Bangkal", "Makati", "USA");
        Address addr2 = new Address("Sector 7", "San Carlos", "Caba", "Canada");

        // Two customers linked to those addresses.
        Customer cust1 = new Customer("Gusion Johnson", addr1);
        Customer cust2 = new Customer("Bob Hayabusa", addr2);

        // Products for order 1: a laptop and two mice.
        List<Product> products1 = new List<Product>
        {
            new Product("Laptop", "A101", 999.99m, 1),
            new Product("Mouse", "B202", 25.50m, 2)
        };

        // Products for order 2: a camera, tripod, and three memory cards.
        List<Product> products2 = new List<Product>
        {
            new Product("PS6", "C303", 450.00m, 1),
            new Product("I-MAC", "D404", 75.00m, 1),
            new Product("Memory Card", "E505", 20.00m, 3)
        };

        // Create each order by pairing a customer with their product list.
        Order order1 = new Order(cust1, products1);
        Order order2 = new Order(cust2, products2);

        List<Order> orders = new List<Order> { order1, order2 };

        // Print the packing label, shipping label, and total cost for every order.
        foreach (Order o in orders)
        {
            Console.WriteLine(o.GetPackingLabel());
            Console.WriteLine(o.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${o.CalculateTotalCost()}\n");
        }
    }
}