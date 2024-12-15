using System;
using System.Runtime.CompilerServices;

public class GoalManager 
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

      public void Start()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Goal Manager");
            Console.WriteLine("1. Create a Goal");
            Console.WriteLine("2. View Goals");
            Console.WriteLine("3. Save Goal");
            Console.WriteLine("4. View Score");
            Console.WriteLine("5. Load Goals");
            Console.Write("Choose an option: ");
            
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalNames();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    DisplayPlayerInfo();
                    break;
                case "5":
                    LoadGoals();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
    
    public void SaveGoals()
    {
       
    }

    public void LoadGoals()
    {
    
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your Score: {_score}");
    }
    
    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

   public void CreateGoal()
{
    Console.WriteLine("Select Type of GOal: 1. Simple 2. Checklist 3. Eternal");
    string goalType = Console.ReadLine();
    
    Console.Write("Type Goal Name: ");
    string name = Console.ReadLine();
    
    Console.Write("Type Description: ");
    string description = Console.ReadLine();
    
    Console.Write("Type Points: ");
    int points = int.Parse(Console.ReadLine());
    
    Goal goal = null;
    
    switch (goalType)
    {
        case "1": 
            goal = new Simple(name, description, points);
            break;
        case "2": 
            Console.Write("Type Target: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Type Bonus Points: ");
            int bonus = int.Parse(Console.ReadLine());
            goal = new Checklist(name, description, points, target, bonus);
            break;
        case "3": 
            goal = new Eternal(name, description, points);
            break;
        default:
            Console.WriteLine("Invalid goal type.");
            return;
    }
    
    _goals.Add(goal);
    Console.WriteLine("Your Goal has been created");
}


 

    


   
}