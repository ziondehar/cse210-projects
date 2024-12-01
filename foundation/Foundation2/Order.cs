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

    public double CalculateTotalCost()
    {
        double totalCost = 0;

      
        foreach (var product in _products)
        {
            totalCost += product.

    
        totalCost += _customer.LivesInUSA() ? 5 : 35;

        return totalCost;
    }


}