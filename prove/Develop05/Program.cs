using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness App!");
        Console.WriteLine("Choose an activity to test:");
        Console.WriteLine("1. Start Breathing Activity");
        Console.WriteLine("2. Start Listing Activity");
        Console.WriteLine("3. Start Reflecting Activity");
        int choice;
        while (true)
        {
            Console.Write("Pick which one to do (1-3): ");
            if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 3)
                break;

            Console.WriteLine("please pick a number between 1-3 ");
        }

        
        switch (choice)
        {
            case 1:
                TestBreathingActivity();
                break;
            case 2:
                TestListingActivity();
                break;
            case 3:
                TestReflectingActivity();
                break;
        }
    }

    static void TestBreathingActivity()
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        breathingActivity.Run();
    }

    static void TestListingActivity()
    {
        ListingActivity listingActivity = new ListingActivity();
        listingActivity.Run();
    }

    static void TestReflectingActivity()
    {
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        reflectingActivity.Run();
    }
}

    
