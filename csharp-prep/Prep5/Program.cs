using System;

class Program
{
    static void Main(string[] args)

    {
        welcomeMessage();

        string username = name();
        int usernum = number();

        int squaredNumber = square( usernum);

        final (username,squaredNumber);
    }




    static void welcomeMessage()
        {
        Console.WriteLine("Hello and Welcome!");
        }

    static string name()
        {
            Console.WriteLine("What is your name");
            string name = Console.ReadLine();
            return name;
                
        }
    static int number()
        {
            Console.WriteLine("what is your age");
            int num = int.Parse(Console.ReadLine());
            return num;
        }
    static int square(int number)
        {
            int squared = number * number;
            return squared;
        }    
    static void final(string Name, int squaredNumber)
        {
            Console.Write($"{Name}, your squared number is {squaredNumber}");

        }
    
}