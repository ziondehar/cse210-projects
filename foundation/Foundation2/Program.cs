using System;

class Program
{
    static void Main(string[] args)
    {
        var address1 = new Address(123, Perth, Australia, WA)
        Console.WriteLine("Address created:");
        Console.WriteLine(address1.GetFullAddress());
        Console.WriteLine();
    }
}