public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public string GetRsvpEmail()
    {
        return _rsvpEmail;
    }

    public override string GetEventType()
    {
        return "Reception";
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\n" +
               $"RSVP Email: {_rsvpEmail}";
    }

    public override string GetShortDescription()
    {
        return base.GetShortDescription();
    }
}
