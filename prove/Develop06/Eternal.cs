using System;
public abstract class Eternal:Goal
{
    

    public Eternal(string name, string description, int points): base ((name, description, points))
    {
    }

    public override void RecordEvent()
    {   
        _IsComplete = false;
    }
    public override bool IsComplete()
    {
        return _IsComplete;
    }
    public override string GetDetailsString()
    {
        return $"SimpleGoal: {GetTitle()}, {GetDescription()}, {GetPoints()}, IsComplete: {IsComplete()}";
    }
    public override string GetStringRepresentation()
    {
          return $"Name: {GetTitle()}, Description: {GetDescription()}, Points: {GetPoints()}";
    }
}