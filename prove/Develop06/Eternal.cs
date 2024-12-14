using System;
public abstract class Eternal
{
    protected string _title;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _title = name;
        _description = description;
        _points = points;
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