using System;


public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
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

    }




}