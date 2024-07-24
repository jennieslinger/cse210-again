public class Cycling : Activity
{
    private int _speed; //mph

    public Cycling(DateTime date, int duration, int speed)
        : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed; // mph
    }

    public override double GetPace()
    {
        return 60 / _speed; //min/mile
    }

    public override string GetSummary()
    {
        return $"Cycling - {base.GetSummary()} - Speed: {_speed} mph, Pace: {GetPace():F2} min/mile";
    }

    public override double GetDistance()
    {
        return _speed * (_duration / 60); // miles
    }
}