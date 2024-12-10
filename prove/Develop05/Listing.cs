using System;
public class ListingActivity : Animation
{
    private List<string> _prompts;

       public ListingActivity() : base("Listing Activity", "This listing out activity can help your to explore your mind", 0)
    {
        _prompts = new List<string> { "List your favorite foods.", "List things you are grateful for." };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        List<string> userInputs = new List<string>();
        Console.WriteLine("Enter into the list (type 'done' when you're finished):");
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done")
                break;
            userInputs.Add(input);
        }
        return userInputs;
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("");
        Console.Write(GetRandomPrompt()); ShowSpinner(2);
        Console.WriteLine("");
        List<string> items = GetListFromUser();
        Console.WriteLine($"You listed {items.Count} items!");
        DisplayEndingMessage();
    }
}
