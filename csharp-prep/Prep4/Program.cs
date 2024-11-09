using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        int number =    -1;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number!=0)
            {
                Console.WriteLine("Enter number: ");
                    number = int.Parse(Console.ReadLine());
                if (number!=0)
                    {
                        numbers.Add (number);
                    }
            }
        int Sum = 0;
        foreach (int num in numbers)
            {
                Sum += num;
            }
        Console.WriteLine($"Your total is {Sum}");
    }
}