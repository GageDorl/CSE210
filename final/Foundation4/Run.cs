class Run : Activity
{
    private double _distance;

    public Run(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{GetDate()} Running ({GetLength()} min) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile");
    }
}