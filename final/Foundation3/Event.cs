public class Event
{
    public string _eventTitle;
    public string _description;
    public DateTime _date;
    public TimeSpan _time;
    public Address _eventAddress;

    public Event(string eventTitle, string description, DateTime date, int hour, Address eventAddress)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = TimeSpan.FromHours(hour);// military time
        _eventAddress = eventAddress;
    }

    public string GetStandardDetails()
    {
        return $"Event: {_eventTitle} | Description: {_description}\nDate & Time: {_date.ToShortDateString()} @ {_time}\nLocation: {_eventAddress.GetAddressString()}";
    }

    public virtual string GetFullDetails()
    {
        return $"Event Type: General | {GetStandardDetails()}";
    }

    public virtual string GetShortDescription()
    {
        return $"Event Type: General | Title: {_eventTitle} | Date: {_date.ToShortDateString()}";
    }
}