using System;

public class Product
{
   private string _name;
   private string _productId;
   private decimal _price;
   private int _quantity ;

   public Product (string name, string productId, decimal price, int quantity)
   {
    _name = name;
    _productId = productId;
    _price = price;
    _quantity = quantity;
   }
   public decimal TotalCost()
   {
    return _price * _quantity;
   }

   public void DisplayProducts()
   {
        Console.WriteLine($"Product Name: {_name}");
        Console.WriteLine($"Product ID: {_productId}");
        Console.WriteLine($"Price per Unit: ${_price:F2}");
        Console.WriteLine($"Quantity: {_quantity}");
        Console.WriteLine($"Total Cost: ${TotalCost():F2}");
   }
}