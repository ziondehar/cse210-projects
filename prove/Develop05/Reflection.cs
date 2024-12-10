using System;
public class ReflectingActivity : Animation
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Reflecting Activity", "This activity will you help you gain confidence in your own experiences.", 0)
    {
        _prompts = new List<string> { "Think about a time you were happy.", "Think about a challenge you overcame.","What is one thing I did today that brought me joy or fulfillment?" };
        _questions = new List<string> { "Why was this moment meaningful?", "What did you learn from this experience?" };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayQuestions()
    {
        foreach (var question in _questions)
        {
            Console.WriteLine(question);
            System.Threading.Thread.Sleep(3000); 
        }
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.Write(GetRandomPrompt()); ShowSpinner(9);
        Console.WriteLine("");
        Console.Write(GetRandomQuestion()); ShowSpinner(5);
        Console.WriteLine("");
        DisplayEndingMessage();
    }
}
