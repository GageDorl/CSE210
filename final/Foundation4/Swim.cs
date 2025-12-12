class Swim : Activity
{
    private int _laps;

    public Swim(string date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps*50/1000*.62;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{GetDate()} Swimming ({GetLength()} min) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile");
    }
}