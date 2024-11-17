using System;

class Entry

{
    public string _date;
    public string _promptText;
    public string _promptEntry;
    
    public Entry(string _date, string _promptText, string _promptEntry)
    {
        Date = _date;
        
        promptText = _promptText;
        promptEntry = _promptEntry;

    }
    public void Display();
    {
        Console.WriteLine("Date")
    }
        
}