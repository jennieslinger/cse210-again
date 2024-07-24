public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int duration, int laps)
        : base{ date, duration}
    {
        _laps = laps;
    }

public override double GetDistance()
{
    return _laps * 50 / 1609.34;//50 meter pool, 1609.34 meters/mile
}

public override double GetSpeed()
{
    return GetDistance() / (_duration / 60); //mph
}

public override double GetPace()
{
    return (_duration * 1609.34) / (_laps * 50); //mins/mile
}

public override string GetSummary()
{
    return $"{base.GetSummary()} - Distance: {GetDistance():} miles, Speed: {GetSpeed():} mph, Pace: {GetPace():} min/mile";
}
}