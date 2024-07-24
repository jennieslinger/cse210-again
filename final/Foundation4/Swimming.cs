public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int duration, int laps)
        : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62; //miles
    }

    public override double GetSpeed()
    {
        if (_duration > 0)
        {
            return (GetDistance() / _duration) * 60; //mph
        }
        else
        {
            return 0.0;
        }

    }

    public override double GetPace()
    {
        if (_laps > 0 && _duration > 0)
        {
            return _duration / _laps; // miles/min
        }
        else
        {
            return 0.0;
        }
    }

    public override string GetSummary()
    {
        return $"Swimming - {base.GetSummary()} - Distance: {GetDistance():F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min/mile";
    }
}