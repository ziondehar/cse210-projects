using System;

public class Entry

{
    public string _date;
    public string _promptText;
    public string _promptEntry;
    
    public Entry(string date, string promptText, string promptEntry)
    {
        _date = date;
        
        _promptText = promptText;
       _promptEntry = promptEntry;

    }
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_promptEntry}");
        Console.WriteLine();
    }
        
    public string GetDate() => _date;
    public string GetPrompt() => _promptText;
    public string GetEntryText() => _promptEntry;
}