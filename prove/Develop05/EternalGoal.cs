class EternalGoal : SimpleGoal
{
    public EternalGoal(string title, string description, int points) : base(title, description, points)
    {

    }

    public override int Complete()
    {
        return getPoints();
    }

    public override string getStringRepresentation()
    {
        return $"EternalGoal|{getTitle()}|{getDescription()}|{getPoints()}";
    }
}