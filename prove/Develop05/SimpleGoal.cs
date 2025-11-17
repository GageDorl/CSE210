using System.Reflection;

class SimpleGoal
{
    string _title;
    string _description;
    int _points;
    bool _complete = false;

    public SimpleGoal(string title, string description, int points)
    {
        _title = title;
        _description = description;
        _points = points;
    }

    public SimpleGoal(string title, string description, int points, bool complete)
    {
        _title = title;
        _description = description;
        _points = points;
        _complete = complete;
    }

    public virtual int Complete()
    {
        if (!_complete)
        {
            _complete = true;
            return _points;
        } else
        {
            return 0;
        }
    }

    public virtual void Display()
    {
        Console.WriteLine($"[{(_complete ? "X" : " ")}] {_title} ({_description})");
    }

    public int getPoints()
    {
        return _points;
    }

    public void setComplete(bool complete)
    {
        _complete = complete;
    }

    public bool getComplete()
    {
        return _complete;
    }

    public string getTitle()
    {
        return _title;
    }

    public string getDescription()
    {
        return _description;
    }

    public virtual string getStringRepresentation()
    {
        return $"SimpleGoal|{_title}|{_description}|{_points}|{_complete}";
    }
}