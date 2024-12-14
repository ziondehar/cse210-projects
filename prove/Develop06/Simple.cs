using System;
public class Simple : Goal
{
    private Boolean _IsComplete;
    public Simple(string name, string description, int points) : base (name, description, points)
    {
        _IsComplete = false;
    }

    public override void RecordEvent();
    {
        _IsComplete = true;
    }
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();
}