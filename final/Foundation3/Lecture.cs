public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetSpeaker()
    {
        return _speaker;
    }

    public int GetCapacity()
    {
        return _capacity;
    }

    public override string GetEventType()
    {
        return "Lecture";
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\n" +
               $"Speaker: {_speaker}\n" +
               $"Capacity: {_capacity}";
    }

    public override string GetShortDescription()
    {
        return base.GetShortDescription();
    }
}
