public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent() { /* Logic for tracking eternal goals */ }
    public override bool IsComplete() => false;
    public override string GetStringRepresentation() => $"EternalGoal:{ShortName}|{Description}|{Points}";
}
