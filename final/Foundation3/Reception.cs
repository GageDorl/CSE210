class Reception : Event
{
    private string _rsvp;

    public Reception(string title, string description, string date, string time, Address address, string rsvp) : base(title, description, date, time, address)
    {
        _rsvp = rsvp;
        SetType("Reception");
    }

    public string GetFullDetails()
    {
        return GetStandardDetails() + $"\nRSVP Email: {_rsvp}";
    }
}