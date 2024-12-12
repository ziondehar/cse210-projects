using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(5);
        square.SetColor("RED");
        square.GetArea();
        Console.WriteLine($"Square: Color={square.GetColor()} Area = {square.GetArea()} ");
    }
}