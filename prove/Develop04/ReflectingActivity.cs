class ReflectingActivity : Activity
{
    List<string> _prompts =
    [
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    ];
    List<string> _questions =
    [
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    ];
    int _pauseDuration;

    public ReflectingActivity(string name, string description) : base(name, description)
    {
        StartReflecting();
    }
    
    public void StartReflecting()
    {
        Random random = new();
        StartMessage();
        Console.Write("\nHow long would you like the pause between questions? (seconds) ");
        _pauseDuration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine($"Your prompt is:\n{_prompts[random.Next(_prompts.Count)]}");
        Console.Write("Get ready");
        for (int i = 3; i > 0; i--)
        {
            Thread.Sleep(500);
            Console.Write(".");
        }
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write($"\n{_questions[random.Next(_questions.Count)]} {_pauseDuration}");
            for (int i = _pauseDuration; i >= 0; i--)
            {
                Thread.Sleep(1000);
                Console.Write($"\b \b{i}");
            }
        }
        EndMessage();
    }
}