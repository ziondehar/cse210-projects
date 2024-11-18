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
                    AddEntry(journal, promptGenerator);
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
                    Console.WriteLine("bye!");
                    return;
                default:
                    Console.WriteLine("not an option. Please try again.");
                    break;
            }
        }
        
    }

    static void AddEntry(Journal journal, PromptGenerator promptGenerator)
    {
        string prompt = promptGenerator.GetPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        Entry newEntry = new Entry(date, prompt, response);
        journal.AddEntry(newEntry);
    }

    static void SaveToFile(Journal journal)
    {
        Console.Write("Enter the file name to save to: ");
        string fileName = Console.ReadLine();
        journal.SaveToFile(fileName);
    }

    static void LoadFromFile(Journal journal)
    {
        Console.Write("Enter the file name to load from: ");
        string fileName = Console.ReadLine();
        journal.LoadFromFile(fileName);
    }
}

//https://www.youtube.com/watch?v=wxznTygnRfQ