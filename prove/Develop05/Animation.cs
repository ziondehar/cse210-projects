using System;
public class Animation
{
    public string _name;
    public string _description;
    public int _duration;


    public Animation(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

  
   public void ShowSpinner(int seconds)
{
    string spinner = "|/-\\"; 

    for (int i = 0; i < seconds * 4; i++)
    {
        string symbol = spinner[i % spinner.Length].ToString();
        Console.Write(symbol); 
        System.Threading.Thread.Sleep(250); 
        Console.Write("\b \b"); 
    }
    Console.WriteLine(); 
}


 
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b \b"); 
        }
    }

    
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting: {_name}");
        Console.WriteLine(_description);
        Console.WriteLine("");
        Console.Write("Beginning in...."); ShowCountDown(5);
        Console.WriteLine("");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Thank You, you completed the {_name}");
    
    }
}
