using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
       Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Save to File");
            Console.WriteLine("4. Load from File");
            Console.WriteLine("5. Exit");
            Console.Write("Your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddEntry(journal);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    SaveToFile(journal);
                    break;
                case "4":
                    LoadFromFile(journal);
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
        
    }

    static void AddEntry(Journal journal)
    {
         Console.Write("Enter the date (YYYY-MM-DD): ");
        string date = Console.ReadLine();
        Console.Write
        string prompt = Console.ReadLine();
        Console.Write("Enter your Answer: ");
        string response = Console.ReadLine();
    }
}

//https://www.youtube.com/watch?v=wxznTygnRfQ