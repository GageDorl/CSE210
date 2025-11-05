class Activity
{
    private string _name;
    private int _duration;
    private string _description;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public virtual void StartMessage()
    {
        Console.WriteLine($"Welcome to the {_name}\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public int GetDuration()
    {
        return _duration;
    }
    
    public void EndMessage()
    {
        Console.WriteLine($"\n\nWell Done!!\n\nYou have completed another {_duration} seconds of the {_name}");
        Thread.Sleep(3000);
    }
}