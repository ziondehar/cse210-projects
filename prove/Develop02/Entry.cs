using System;

class Entry

{
    public string _date;
    public string _promptText;
    public string _promptEntry;
    
    public Entry(string _date, string _promptText, string _promptEntry)
    {
        _date = Date;
        
        _promptText = promptText;
       _promptEntry = promptEntry;

    }
    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {promptText}");
        Console.WriteLine($"Entry: {promptText}");
        Console.WriteLine();
    }
        
}