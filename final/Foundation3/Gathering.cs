class Gathering : Event
{
    private string _forecast;

    public Gathering(string title, string description, string date, string time, Address address, string forecast) : base(title, description, date, time, address)
    {
        _forecast = forecast;
        SetType("Outdoor Gathering");
    }

    public string GetFullDetails()
    {
        return GetStandardDetails() + $"\nForecast: {_forecast}";
    }
}