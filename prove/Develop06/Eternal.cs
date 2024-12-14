using System;
public class Eternal: Goal
{
    

    public Eternal(string name, string description, int points): base (name, description, points)
    {
    }

    public override void RecordEvent()
    {   
       
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetDetailsString()
    {
        return $"EternalGoal: {GetTitle()}, {GetDescription()}, {GetPoints()}";
    }
    public override string GetStringRepresentation()
    {
         return $"Name: {GetTitle()}, Description: {GetDescription()}, Points: {GetPoints()}";
    }
}