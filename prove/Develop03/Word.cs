class Word
{
    string _word;
    Boolean _hidden;

    public Word(string word)
    {
        _word = word;
    }
    public Boolean IsHidden()
    {
        return _hidden;
    }

    public void SetHidden(Boolean hidden)
    {
        _hidden = hidden;
    }

    public void Display()
    {
        if (_hidden)
        {
            Console.Write(" ");
            for (int i = 0; i < _word.Length; i++)
            {
                Console.Write("_");
            }
        }
        else
        {
            Console.Write($" {_word}");
        }
    }

}