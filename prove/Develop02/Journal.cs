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
        Console.WriteLine("Added");


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


    public void LoadFromFile(string file)
    {
        _entries.Clear(); //clears entries

            // Read all lines from the file
            foreach (string line in File.ReadAllLines(file))
            {
                string[] parts = line.Split('|'); // Split line into 3
                if (parts.Length == 3)
                {
                    _entries.Add(new Entry(parts[0], parts[1], parts[2])); // Add them together
                }
            }

            Console.WriteLine($"Journal loaded from {file}");
    }


    public void SaveToFile(string file)
    {
         using (StreamWriter writer = new StreamWriter(file)) // Opens the file for writing
         
        {
            foreach (var entry in _entries)
            {
                
                writer.WriteLine($"{entry.GetDate()}|{entry.GetPrompt()}|{entry.GetEntryText()}");
                // This produces writing order
            }
        }

        Console.WriteLine($"Journal saved to {file}");
    }
}

//https://www.w3schools.com/cs/cs_files.php
//https://learn.microsoft.com/en-us/dotnet/api/system.io.file?view=net-6.0


