public class Running : Activity
{
    private double _distance; //in miles

    public Running(DateTime date, int duration, double distance)
    : base(date, duration)
    {
        _distance = distance;
    }

    public double GetDistance()
    {
        return _distance;
    }

    public double GetSpeed()
    {
        return _distance / (_duration / 60); //speed in mph
    }

    public double GetPace()
    {
        return _duration / _distance; // miles/min
    }

    public string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {_distance:} miles, Speed: {GetSpeed():} mph, Pace: {GetPace():} min/mile";
    }
}