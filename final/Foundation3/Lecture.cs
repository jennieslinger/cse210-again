public class Lecture : Event
{
    private string _speaker;
    private double _capacity;

    public Lecture(string eventTitle, string description, DateTime date, int hour, Address eventAddress, string speaker, double capactity)
        : base(eventTitle, description, date, hour, eventAddress)
    {
        _speaker = speaker;
        _capacity = capactity;
    }

    public override string GetFullDetails()
    {
        return $"Event Type: Lecture | {base.GetStandardDetails()}\nSpeaker: {_speaker} | Capacity: {_capacity}";
    }

    public override string GetShortDescription()
    {
        return $"Event type: Lecture | Title: {_eventTitle} | Date: {_date.ToShortDateString()}";
    }
}