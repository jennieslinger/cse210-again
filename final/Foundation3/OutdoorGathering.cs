public class OutdoorGathering : Event
{
    public int _weatherForecast;
    public OutdoorGathering(string eventTitle, string description, DateTime date, int hour, Address eventAddress, int weatherForecast)
    : base(eventTitle, description, date, hour, eventAddress)
    {
        _weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"Event type: Outdoor Gathering | {base.GetStandardDetails()}\nWeather Forecast: {_weatherForecast} degrees and sunny";
    }

    public override string GetShortDescription()
    {
        return $"Event type: Outdoor Gathering | Title: {_eventTitle} | Date: {_date.ToShortDateString()}";
    }
}