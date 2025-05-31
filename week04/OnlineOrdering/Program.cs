using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter customer name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter street address:");
        string street = Console.ReadLine();

        Console.WriteLine("Enter city:");
        string city = Console.ReadLine();

        Console.WriteLine("Enter state/province:");
        string state = Console.ReadLine();

        Console.WriteLine("Enter country:");
        string country = Console.ReadLine();

        Address address = new Address(street, city, state, country);
        Customer customer = new Customer(name, address);
        Order order = new Order(customer);

        Console.Write("How many products to add? ");
        int productCount = int.Parse(Console.ReadLine());

        for (int i = 1; i <= productCount; i++)
        {
            Console.WriteLine($"\nEnter info for product #{i}:");

            Console.Write("Product name: ");
            string productName = Console.ReadLine();

            Console.Write("Product ID: ");
            string productId = Console.ReadLine();

            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Product product = new Product(productName, productId, price, quantity);
            order.AddProduct(product);
        }

        // Displaying order info
        Console.WriteLine("\n" + order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order.GetTotalCost():0.00}");
    }
}