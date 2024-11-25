using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Test Constructors");
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());
        
        Fraction fraction2 = new Fraction(5); 
        Console.WriteLine(fraction2.GetFractionString()); 
        Console.WriteLine(fraction2.GetDecimalValue());  

        Fraction fraction3 = new Fraction(3, 4); 
        Console.WriteLine(fraction3.GetFractionString()); 
        Console.WriteLine(fraction3.GetDecimalValue());   

        
        Console.WriteLine("\nTesting Getters and Setters:");
        fraction3.SetTop(1);
        fraction3.SetBottom(3);
        Console.WriteLine(fraction3.GetFractionString()); 
        Console.WriteLine(fraction3.GetDecimalValue());   

        
        Console.WriteLine("\nAdditional Tests:");
        Fraction fraction4 = new Fraction(7, 8); 
        Console.WriteLine(fraction4.GetFractionString()); 
        Console.WriteLine(fraction4.GetDecimalValue());  

        Fraction fraction5 = new Fraction(9); 
        Console.WriteLine(fraction5.GetFractionString());
        Console.WriteLine(fraction5.GetDecimalValue());

        
    }
}