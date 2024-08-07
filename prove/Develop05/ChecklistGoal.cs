public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;

    }
    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target)
        {
            return _points + _bonus;//bonus awarded upon completion of checklist goal
        }
        return _points;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetStringRepresentation()
    {
        return $"[Checklist]: {_name}: {_description} ({_amountCompleted}/{_target})";
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "Complete" : "Incomplete";
        return $"[Checklist]: {_name}: {_description}: ({_amountCompleted}/{_target}: {_bonus}: {status})";
    }
}