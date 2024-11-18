using System;


public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        
        if (newEntry == null) 
        {
            Console.WriteLine("Cannot add nothing");
            return;
        }
        _entries.Add(newEntry);


    }

    public void DisplayAll()
     {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries.");
            return;
        }

        foreach (var entry in _entries)
        {
            entry.Display();
        }
     }


    public LoadFromFile(string file)
    {

    }


    public SaveToFile(string file)
    {
         using (StreamWriter writer = new StreamWriter(file)) // Open the file for writing
        {
            foreach (var entry in _entries)
            {
                
                writer.WriteLine($"{entry.getDate()}|{entry.GetPrompt()}|{entry.GetEntryText()}");
                // This produces writing order
            }
        }

        Console.WriteLine($"Journal saved to {file}");
    }
    }




}