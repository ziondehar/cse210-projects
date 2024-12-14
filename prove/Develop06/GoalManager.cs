using System;
using System.Runtime.CompilerServices;

public class GoalManager : Goal
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goals>();
        _score = 0;
    }



    public override void RecordEvent()
    {   
        _IsComplete = true;
    }
    public override bool IsComplete()
    {
        return _IsComplete;
    }
    public override string GetDetailsString()
    {
        Console.WriteLine($"Simple Goal = {_title}");
    }
    public override string GetStringRepresentation()
    {
         return $"Name: {_title}, Description: {_description}, Points: {_points}";
}