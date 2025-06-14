class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) {}

    public override int RecordEvent() => _points;

    public override bool IsComplete() => false;

    public override string GetStatus() => "[∞] " + _name;

    public override string GetSaveString() =>
        $"EternalGoal|{_name}|{_description}|{_points}";

    public override void LoadFromString(string data)
    {
        string[] parts = data.Split('|');
        _name = parts[1];
        _description = parts[2];
        _points = int.Parse(parts[3]);
    }
}
