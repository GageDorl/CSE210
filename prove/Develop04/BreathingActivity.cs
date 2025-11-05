class BreathingActivity : Activity
{
    private int _inDuration;
    private int _holdDuration;
    private int _outDuration;

    public BreathingActivity(string name, string description) : base(name, description)
    {
        StartBreathing();
    }

    public void StartBreathing()
    {
        StartMessage();
        Console.Write("\nHow long do you want to breathe in? (seconds) ");
        _inDuration = int.Parse(Console.ReadLine());
        Console.Write("\nHow long do you want to hold your breath? (seconds) ");
        _holdDuration = int.Parse(Console.ReadLine());
        Console.Write("\nHow long do you want to breathe out? (seconds) ");
        _outDuration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.Write("Get ready");
        for (int i = 3; i > 0; i--)
        {
            Thread.Sleep(500);
            Console.Write(".");
        }
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write($"\n\nBreathe in... {_inDuration}");
            for (int i = _inDuration - 1; i >= 0; i--)
            {
                Thread.Sleep(1000);
                Console.Write($"\b \b{i}");
            }
            Console.Write($"\nHold... {_holdDuration}");
            for (int i = _holdDuration - 1; i >= 0; i--)
            {
                Thread.Sleep(1000);
                Console.Write($"\b \b{i}");
            }
            Console.Write($"\nBreathe out... {_outDuration}");
            for (int i = _outDuration - 1; i >= 0; i--)
            {
                Thread.Sleep(1000);
                Console.Write($"\b \b{i}");
            }
        }
        EndMessage();
    }
}