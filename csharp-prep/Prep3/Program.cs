using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {   

        
        int magicNumber = 63;
        int guess = 0;
        while (guess!=magicNumber)
            {Console.WriteLine("What is the magic number");
            guess = int.Parse(Console.ReadLine());

            if (guess<magicNumber)
                {
                    Console.WriteLine("Higher");
                }
            else if (guess>magicNumber)
                {
                    Console.WriteLine("Lower");
                }
            else 
                {
                    Console.WriteLine($"Conratulations you got the Magic Number {magicNumber}!");
                }
            }
    }   
}