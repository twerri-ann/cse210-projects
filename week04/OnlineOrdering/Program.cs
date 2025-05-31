using System;

class Program
{
     static void Main(string[] args)
    {
        // Create addresses
        Address usaAddress = new Address("123 Main St", "Dallas", "TX", "USA");
        Address canadaAddress = new Address("456 King St", "Vancouver", "BC", "Canada");

        // Create customers
        Customer customer1 = new Customer("Alice Johnson", usaAddress);
        Customer customer2 = new Customer("Bob Smith", canadaAddress);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P1001", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "P1002", 19.99, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Notebook", "P2001", 3.99, 5));
        order2.AddProduct(new Product("Pen", "P2002", 1.49, 10));

        // Store orders in a list
        List<Order> orders = new List<Order> { order1, order2 };

        // Display order details
        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.GetTotalCost():0.00}");
            Console.WriteLine(new string('-', 40));
        }
    }
}
