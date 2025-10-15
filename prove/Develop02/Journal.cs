using System.Globalization;
using CsvHelper;

public class Journal()
{
    public List<Entry> _entries = [];
    public List<string> _prompts = [
        "How are you feeling today?",
        "What made you happy today?",
        "What is something that stuck out to you today?",
        "Who did you see today?",
        "What did you eat today?",
        "What animal would you choose to be for a day?",
        "What superpower do you wish you had today?"
    ];

    public void Write()
    {
        Entry entry = new();
        Random randomGen = new();
        entry._date = DateTime.Now.ToString();
        entry._prompt = _prompts[randomGen.Next(0, _prompts.Count - 1)];
        Console.Write("Current Mood: ");
        entry._mood = Console.ReadLine();
        Console.WriteLine($"Prompt: {entry._prompt}");
        Console.Write("Entry: ");
        entry._entry = Console.ReadLine();
        _entries.Add(entry);
        Menu();
    }

    public void Save()
    {
        Console.Write("Enter a name for the file (no extension): ");
        string filename = Console.ReadLine()+".csv";
        using (StreamWriter writer = new(filename))
        using (CsvWriter csv = new(writer, CultureInfo.InvariantCulture))
        {
            csv.WriteRecords(_entries);
            Console.WriteLine($"Journal Saved to {filename}");
        }
        Menu();
    }

    public void Load()
    {
        Console.Write("Enter filename to load (no extension): ");
        string filename = Console.ReadLine()+".csv";
        using (StreamReader reader = new(filename))
        using (CsvReader csv = new(reader, CultureInfo.InvariantCulture))
        {
            _entries = csv.GetRecords<Entry>().ToList();
            Display();
        }
        Menu();
    }

    public void Display()
    {
        Console.WriteLine("\nJournal Display: ");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
        Menu();
    }

    public void Menu()
    {
        ConsoleColor original = Console.ForegroundColor;
        int choice = 0;
        Boolean enter = false;
        Console.WriteLine("\n\n\n\n");
        while (!enter)
        {
            Console.ForegroundColor = original;
            Console.SetCursorPosition(0, Console.CursorTop - 5);
            Console.WriteLine("Choose an option: ");
            switch (choice)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Write");
                    Console.ForegroundColor = original;
                    Console.WriteLine("Save\nLoad\nQuit");
                    break;
                case 1:
                    Console.ForegroundColor = original;
                    Console.WriteLine("Write");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Save");
                    Console.ForegroundColor = original;
                    Console.WriteLine("Load\nQuit");
                    break;
                case 2:
                    Console.ForegroundColor = original;
                    Console.WriteLine("Write\nSave");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Load");
                    Console.ForegroundColor = original;
                    Console.WriteLine("Quit");
                    break;
                case 3:
                    Console.ForegroundColor = original;
                    Console.WriteLine("Write\nSave\nLoad");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Quit");
                    Console.ForegroundColor = original;
                    break;
            }

            ConsoleKeyInfo pressed = Console.ReadKey();
            ConsoleKey pressedKey = pressed.Key;
            switch (pressedKey)
            {
                case ConsoleKey.DownArrow:
                    choice++;
                    choice = choice % 4;
                    break;
                case ConsoleKey.UpArrow:
                    if (choice > 0)
                    {
                        choice--;
                    }
                    else
                    {
                        choice = 3;
                    }
                    break;
                case ConsoleKey.Enter:
                    enter = true;
                    break;
            }
        }
        
        switch (choice)
        {
            case 0:
                Write();
                break;
            case 1:
                Save();
                break;
            case 2:
                Load();
                break;
            case 3:
                Console.WriteLine("Bye bye");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Option not recognized.");
                Menu();
                break;
        }
    }
}