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
            Console.WriteLine("6. Record Event");
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
                case "6":
                    RecordGoalEvent();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            ShowSpinner(2);
            Console.WriteLine($"Press any key to continue");
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
    ShowSpinner(2);
    Console.WriteLine("Your Goal has been created");
}


 
//Animations
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
public void RecordGoalEvent()
{
    ListGoalNames();
    Console.Write("Select the goal to record progress (by index): ");
    int index = int.Parse(Console.ReadLine());

    if (index < 0 || index >= _goals.Count)
    {
        Console.WriteLine("Invalid index.");
        return;
    }
    
    _goals[index].RecordEvent();
    if (_goals[index].IsComplete())
    {
        Console.WriteLine("Goal completed!");
        _score += _goals[index].GetPoints();
    }
    else
    {
        Console.WriteLine("Progress recorded.");
    }
}



   
}