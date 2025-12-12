class Event
{
    private string _type;
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        SetType("Event");
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void SetType(string type)
    {
        _type = type;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.GetAddress()}";
    }

    public string GetShortDescription()
    {
        return $"Event Type: {_type}\nTitle: {_title}\nDate: {_date}";
    }
}