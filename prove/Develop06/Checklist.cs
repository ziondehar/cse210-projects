using System;
public class Checklist : Goal
{
    protected string _title;
    protected string _description;
    protected int _points;

    public Checklist(string name, string description, int points, ta)
    {
        _title = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public override IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();
}