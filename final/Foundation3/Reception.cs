public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, DateTime date, int hour, Address eventAddress, string rsvpEmail)
    : base(title, description, date, hour, eventAddress)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"Event Type: Reception | {base.GetStandardDetails()}\nRSVP Email: {_rsvpEmail}";
    }

    public override string GetShortDescription()
    {
        return $"Event type: Reception | Title: {_eventTitle} | Date: {_date.ToShortDateString()}";
    }
}