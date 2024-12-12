using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(5);
        square.SetColor("RED");
        square.GetArea();
        Console.WriteLine($"Square: Color={square.GetColor()} Area = {square.GetArea()} ");
    
        Rectangle rectangle = new Rectangle(4, 12);
        rectangle.SetColor("Blue");
        Console.WriteLine($"Rectangle Color: {rectangle.GetColor()}, Area: {rectangle.GetArea()}");

        
        Circle circle = new Circle(18);
        circle.SetColor("Green");
        Console.WriteLine($"Circle Color: {circle.GetColor()}, Area: {circle.GetArea()}");
    }
}   