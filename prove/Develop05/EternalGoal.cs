public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
        //intentionally left blank
    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override bool IsComplete()
    {
        return false; //default as they are never complete
    }

    public override string GetStringRepresentation()
    {
        return $"[Eternal]: {_name}: {_description} : {_points}";
    }

    public override string GetDetailsString()
    {
        return $"[Eternal]: {_name}: {_description} (On-Going)";
    }
}