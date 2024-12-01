using System;

public class Order
{
    List<Product> _products;
    Customer _customer;
    

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }


    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;

        foreach (var product in _products)
        {
            totalCost += product.TotalCost();
        }
        totalCost += _customer.LivesInUSA() ? 5 : 35;

        return totalCost;
    }
    public void DisplayOrder()
    {
        Console.WriteLine($"Customer: {_customer.GetName()}");
        Console.WriteLine("Products:");
        foreach (var product in _products)
        {
            product.DisplayProducts();
            Console.WriteLine();
        }
        Console.WriteLine($"Total Order Cost: ${CalculateTotalCost():F2}");
    }
}