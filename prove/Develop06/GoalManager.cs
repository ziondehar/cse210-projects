using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO; 

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
            Console.WriteLine($"Press any key to continue");
            Console.ReadKey();
        }
    }
    
    public void SaveGoals()
    {
     try
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            // Write score
            writer.WriteLine(_score);

            // Write each goal
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals and score saved successfully to goals.txt.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error saving goals: {ex.Message}");
    }
    }

    public void LoadGoals()
    {
        try
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No save file found.");
            return;
        }

        using (StreamReader reader = new StreamReader("goals.txt"))
        {
            
            _score = int.Parse(reader.ReadLine());

            
            _goals.Clear();
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Goal goal = ParseGoalFromString(line);
                if (goal != null)
                {
                    _goals.Add(goal);
                }
            }
        }
        Console.WriteLine("Goals and score loaded successfully from goals.txt.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error loading goals: {ex.Message}");
    }
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
    if (_goals.Count == 0)
    {
        Console.WriteLine("No goals available to record progress.");
        return;
    }

    Console.WriteLine("Available Goals:");
    foreach (var goal in _goals)
    {
        Console.WriteLine(goal.GetDetailsString());
    }

    Console.Write("Enter the name of the goal to record progress: ");
    string goalName = Console.ReadLine();

    Goal selectedGoal = _goals.Find(g => g.GetTitle().Equals(goalName, StringComparison.OrdinalIgnoreCase));

    if (selectedGoal == null)
    {
        Console.WriteLine("Goal was not found. try again.");
        return;
    }

    selectedGoal.RecordEvent();

    if (selectedGoal.IsComplete())
    {
        Console.WriteLine("Goal completed!");
        _score += selectedGoal.GetPoints();
    }
    else
    {
        Console.WriteLine("Progress recorded.");
    }
}
private Goal ParseGoalFromString(string goalString)
{
    try
    {
        string[] parts = goalString.Split(',');

    
        if (parts.Length < 4)
        {
            Console.WriteLine($"Wrong goal format: {goalString}");
            return null;
        }

        string type = parts[0].Trim();
        string name = parts[1].Trim();
        string description = parts[2].Trim();
        int points = int.Parse(parts[3].Trim());

        switch (type)
        {
            case "Simple":
                return new Simple(name, description, points);

            case "Checklist":
                if (parts.Length < 7)
                {
                    Console.WriteLine($"Wrong goal format: {goalString}");
                    return null;
                }

                int target = int.Parse(parts[4].Trim());
                int bonus = int.Parse(parts[5].Trim());
                int amountCompleted = int.Parse(parts[6].Trim());
                var checklistGoal = new Checklist(name, description, points, target, bonus)
                {
                    _amountCompleted = amountCompleted 
                };
                return checklistGoal;

            case "Eternal":
                return new Eternal(name, description, points);

            default:
                Console.WriteLine($" goal type? : {type}");
                return null;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"trouble parsing goal: {goalString}. Exception: {ex.Message}");
        return null;
    }
}




   
}
   