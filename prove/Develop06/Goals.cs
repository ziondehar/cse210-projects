using System;
public abstract class Goal
{
    private string _title;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _title = name;
        _description = description;
        _points = points;
    }
    public string GetTitle()
    {
        return _title;
    }
    
    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public abstract void RecordEvent();
    
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();
}
