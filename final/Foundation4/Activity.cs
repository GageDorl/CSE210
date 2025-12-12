abstract class Activity
{
    private string _date;
    private int _length;
    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public string GetDate()
    {
        return _date;
    }
    public int GetLength()
    {
        return _length;
    }

    public abstract double GetDistance();
    public virtual double GetSpeed()
    {
        double distance = GetDistance();
        return distance/_length*60;
    }
    public virtual double GetPace()
    {
        double distance = GetDistance();
        return _length/distance;
    }
    public abstract void GetSummary();
    
}