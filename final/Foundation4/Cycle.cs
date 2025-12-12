class Cycle : Activity
{
    private double _speed;

    public Cycle(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return GetLength()*_speed/60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{GetDate()} Cycling ({GetLength()} min) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile");
    }
}