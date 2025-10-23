class Reference
{
    string _bookName;
    string _chapter;
    string _verse;

    public Reference(string reference)
    {
        string[] parts = reference.Split(" ");
        _bookName = parts[0];
        string[] chapterAndVerse = parts[1].Split(":");
        _chapter = chapterAndVerse[0];
        _verse = chapterAndVerse[1];
    }

    public Reference(string bookName, string chapter, string verse)
    {
        _bookName = bookName;
        _chapter = chapter;
        _verse = verse;
    }

    public void Display()
    {
        Console.Write($"{_bookName} {_chapter}:{_verse}");
    }
}