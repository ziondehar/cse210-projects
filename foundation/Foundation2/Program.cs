using System;

class Program
{
    static void Main(string[] args)
    {
        var address = new Address("123", "Perth", "Ausralia", "WA");
        Console.WriteLine("Address created:");
        Console.WriteLine(address.GetFullAddress());
        Console.WriteLine();

      
        var customer = new Customer("BO TURNER", address);
        Console.WriteLine($"Customer created: {customer.GetName()}");
        Console.WriteLine($"Lives in USA: {customer.LivesInUSA()}");
        Console.WriteLine();

        
        var product1 = new Product("Smartphone", "1010", 699.99m, 1);
        var product2 = new Product("Headphones", "1011", 49.99m, 2);
        Console.WriteLine("Products created:");
        product1.DisplayProducts();
        Console.WriteLine();
        product2.DisplayProducts();
        Console.WriteLine();

        var order = new Order(customer);
        order.AddProduct(product1);
        order.AddProduct(product2);

       
        Console.WriteLine("Order details:");
        order.DisplayOrder();

      
        Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():F2}");
    }


}