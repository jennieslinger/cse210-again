public class Cycling : Activity
{
    private double _speed; //mph

    public Cycling(DateTime date, int duration, int speed)
        : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed; //in mph
    }

    public override double GetPace()
    {
        return 60 / _speed; //min/mile
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Speed: {_speed:} mph, Pace: {GetPace():} min/mile";
    }

    public double GetDistance()
    {
        return _speed * (_duration / 60);
    }
}