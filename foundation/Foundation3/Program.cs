using System;

class Program
{
    static void Main(string[] args)
    {
         var activities = new List<Activity>
        {
            new Running("12 June 2024", 30, 4.8),
            new Bike ("13 December 2024", 45, 20),
            new Swimming("07 January 2023", 25, 30)
        };

       
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.Fullstring());
        }
    }
}
