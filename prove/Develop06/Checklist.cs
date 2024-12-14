using System;
public class Checklist : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public Checklist(string name, string description, int points, int target,int bonus) : base (name, description, points)
    {
       _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    
    public override void RecordEvent()
    {   
         if (_amountCompleted < _target)
        {
            _amountCompleted++;
        }
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    {
        return $"ChecklistGoal: {GetTitle()}, {GetDescription()}, {GetPoints()}, Completed: {_amountCompleted}/{_target}, Bonus: {_bonus}";
    }
    public override string GetStringRepresentation()
    {
        return $"Name: {GetTitle()}, Description: {GetDescription()}, Points: {GetPoints()}, Target: {_target}, Bonus: {_bonus}";
    }
}
