public class Actitity
{
    private DateTime _date;
    private int _duration;//in minutes

    public Activity(DateTime date, int duration);
    {
        _date = date;
        _duration = duration;
    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{_date.ToShortDateString()} - {_duration} mins";
    }
}