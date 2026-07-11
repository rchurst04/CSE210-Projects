public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent() => _amountCompleted++;
    public override bool IsComplete() => _amountCompleted >= _target;
    public override string GetStringRepresentation() => $"ChecklistGoal:{ShortName}|{Description}|{Points}|{_target}|{_bonus}|{_amountCompleted}";
}
