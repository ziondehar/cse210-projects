using System;

public class Product
{
   private string _name;
   private string _productId;
   private int _price;
   private int _quantity ;

   class Product (string name, string productId, int price, int quantity)
   {
    _name = name;
    _productId = productId;
   }
}