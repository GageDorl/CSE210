class ChecklistGoal : SimpleGoal
{
    int _timesComplete = 0;
    int _timesRequired;
    int _bonus;
    public ChecklistGoal(string title, string description, int points, int timesRequired, int bonus) : base(title, description, points)
    {
        _timesRequired = timesRequired;
        _bonus = bonus;
    }

    public ChecklistGoal(string title, string description, int points, int timesRequired, int bonus, int timesComplete) : base(title, description, points)
    {
        _timesRequired = timesRequired;
        _bonus = bonus;
        _timesComplete = timesComplete;
    }

    public override int Complete()
    {
        if (_timesComplete + 1 == _timesRequired)
        {
            _timesComplete++;
            setComplete(true);
            return _bonus;
        }
        else if (_timesComplete + 1 < _timesRequired)
        {
            _timesComplete++;
            return getPoints();
        }
        else
        {
            return 0;
        }
    }

    public override void Display()
    {
        Console.WriteLine($"[{(getComplete() ? "X" : " ")}] {getTitle()} ({getDescription()}) -- Currently completed: {_timesComplete}/{_timesRequired}");
    }

    public override string getStringRepresentation()
    {
        return $"ChecklistGoal|{getTitle()}|{getDescription()}|{getPoints()}|{_timesRequired}|{_bonus}|{_timesComplete}";
    }
}