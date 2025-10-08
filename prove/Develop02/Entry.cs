using CsvHelper.Configuration.Attributes;

public class Entry()
{
    [Index(0)]
    public string _date{ get; set; }

    [Index(1)]
    public string _prompt{ get; set; }

    [Index(2)]
    public string _entry{ get; set; }

    [Index(3)]
    public string _mood { get; set; }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine($"Entry: {_entry}\n");
    }
}