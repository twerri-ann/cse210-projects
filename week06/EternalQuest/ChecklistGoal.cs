class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _currentCount = 0;
    }

    public override int RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            int total = _points;
            if (_currentCount == _targetCount)
            {
                total += _bonus;
            }
            return total;
        }
        return 0;
    }

    public override bool IsComplete() => _currentCount >= _targetCount;

    public override string GetStatus() =>
        $"[{(IsComplete() ? "X" : " ")}] {_name} -- Completed {_currentCount}/{_targetCount} times";

    public override string GetSaveString() =>
        $"ChecklistGoal|{_name}|{_description}|{_points}|{_targetCount}|{_bonus}|{_currentCount}";

    public override void LoadFromString(string data)
    {
        string[] parts = data.Split('|');
        _name = parts[1];
        _description = parts[2];
        _points = int.Parse(parts[3]);
        _targetCount = int.Parse(parts[4]);
        _bonus = int.Parse(parts[5]);
        _currentCount = int.Parse(parts[6]);
    }
}
