class ListingActivity : Activity
{
    private List<string> _prompts = [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    ];
    private List<string> _listedItems = [];

    public ListingActivity(string name, string description) : base(name, description)
    {
        StartListing();
    }

    public void StartListing()
    {
        Random random = new();
        StartMessage();
        Console.Clear();
        string currentPrompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"Your prompt is:\n{currentPrompt}");
        Console.Write("Get ready");
        for (int i = 3; i > 0; i--)
        {
            Thread.Sleep(500);
            Console.Write(".");
        }
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Clear();
            Console.WriteLine($"Your prompt is :\n{currentPrompt}");
            Console.Write("List your answers: ");
            _listedItems.Add(Console.ReadLine());
        }
        Console.Write("Times up");
        for (int i = 3; i > 0; i--)
        {
            Thread.Sleep(500);
            Console.Write(".");
        }
        Console.Write($"\nYou listed {_listedItems.Count} answers");
        for (int i = 3; i > 0; i--)
        {
            Thread.Sleep(500);
            Console.Write(".");
        }
        Console.Write("\nGood job!");
        Thread.Sleep(1000);
        EndMessage();
        }
}