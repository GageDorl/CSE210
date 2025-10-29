class MathAssignment : Assignment
{
    string _textbookSection;
    string _problems;

    public MathAssignment(string textbookSection, string problems, string sectionName, string topic) : base(sectionName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{GetSummary()}\nSection {_textbookSection} Problems {_problems}";
    }
}