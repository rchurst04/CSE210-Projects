public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public string GetWeatherForecast()
    {
        return _weatherForecast;
    }

    public override string GetEventType()
    {
        return "Outdoor Gathering";
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\n" +
               $"Weather Forecast: {_weatherForecast}";
    }

    public override string GetShortDescription()
    {
        return base.GetShortDescription();
    }
}
