using System;
public class BreathingActivity : Animation
{

    public BreathingActivity() : base("Breathing Activity", "Focus on your breathing and take deep breaths", 0) { }//

      public void Run()
    {

        DisplayStartingMessage();
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Breathe in... "); ShowCountDown(5);  
            Console.WriteLine("");
            Console.Write("Breathe out... "); ShowCountDown(3); 
            Console.WriteLine("");
            
        }
        ShowSpinner(5);
        Console.WriteLine("Good work on the Breathing Activity!");
    }
}