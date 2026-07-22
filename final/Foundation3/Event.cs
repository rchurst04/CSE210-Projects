public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetDate()
    {
        return _date;
    }

    public virtual string GetEventType()
    {
        return "Event";
    }

    public string GetStandardDetails()
    {
        return $"Title: {_title}\n" +
               $"Description: {_description}\n" +
               $"Date: {_date}\n" +
               $"Time: {_time}\n" +
               $"Address:\n{_address.GetFullAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return $"{GetStandardDetails()}\n" +
               $"Type: {GetEventType()}";
    }

    public virtual string GetShortDescription()
    {
        return $"Type: {GetEventType()}\n" +
               $"Title: {_title}\n" +
               $"Date: {_date}";
    }
}
