
public class Simple : Goal
{
    private Boolean _IsComplete;
    public Simple(string name, string description, int points) : base (name, description, points)
    {
        _IsComplete = false;
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
        return $"SimpleGoal: {GetTitle()}, {GetDescription()}, {GetPoints()}, IsComplete: {IsComplete()}";
    }
    public override string GetStringRepresentation()
    {
          return $"Name: {GetTitle()}, Description: {GetDescription()}, Points: {GetPoints()}";
    }
}