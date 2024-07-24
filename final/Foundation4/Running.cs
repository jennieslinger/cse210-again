public class Running : Activity
{
    private double _distance; //in miles

    public Running(DateTime date, int duration, double distance)
        : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        if (_duration > 0)
        {
            return _distance / (_duration / 60); //speed in mph
        }
        else
        {
            return 0.0;
        }
    }

    public override double GetPace()
    {
        if (_distance > 0 && _duration > 0)
        {
            return (_duration / _distance) / 60; // miles/min
        }
        else
        {
            return 0.0;
        }
    }

    public override string GetSummary()
    {
        return $"Running - {base.GetSummary()} - Distance: {_distance:F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min/mile";
    }
}