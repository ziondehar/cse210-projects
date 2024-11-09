using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What was your grade");
        int grade = int.Parse(Console.ReadLine());

        if (grade >= 90 && grade <100)
            {
                Console.WriteLine("You got an A");
            }
        else if (grade >= 80 && grade <100)
            {
                Console.WriteLine("You got an B");
            }
        else if (grade >= 70 && grade <100)
            {
                Console.WriteLine("You got an C");
            }
        else if (grade >= 60 && grade <100)
            {
                Console.WriteLine("You got an D");
            }
        else if (grade < 60 && grade >0)
            {
                Console.WriteLine("You got an F");
            }
        else 
            {
                Console.WriteLine("This grade isnt possible");
            }
    }
}