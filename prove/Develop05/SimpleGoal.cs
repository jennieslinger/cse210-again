public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
       : base(name, description, points)
    {
        _isComplete = false;//default
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true; //complete when simple goal is recorded
            return _points;
        }
        return 0;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"[Simple]: {_name}: {_description}: {_points}: {(_isComplete ? "Complete" : "Incomplete")}";
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "Complete" : "Incomplete";
        return $"[Simple]: {_name}: {_description} ({status})";
    }
}