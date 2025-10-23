using System.ComponentModel.DataAnnotations;

class Scripture
{
    Reference _reference;
    List<Word> _listOfWords;

    public Scripture (string reference, string listOfWords)
    {
        string[] separateWords = listOfWords.Split(" ");
        List<Word> formattedList = [];
        foreach(string word in separateWords)
        {
            formattedList.Add(new(word));
        }
        _reference = new(reference);
        _listOfWords = formattedList;
    }

    public Scripture(Reference reference, string listOfWords)
    {
        string[] separateWords = listOfWords.Split(" ");
        List<Word> formattedList = [];
        foreach(string word in separateWords)
        {
            formattedList.Add(new Word(word));
        }
        _reference = reference;
        _listOfWords = formattedList;
    }

    public void Display()
    {
        _reference.Display();
        foreach(Word word in _listOfWords)
        {
            word.Display();
        }
    }
    public void Menu()
    {
        Boolean allHidden = false;
        string userInput = "";
        while (userInput != "quit" && !allHidden)
        {
            Display();
            Console.WriteLine("\n\nPress enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();
            int hiddenCount = 0;
            foreach (Word word in _listOfWords)
            {
                if (word.IsHidden())
                {
                    hiddenCount++;
                }
            }
            if (hiddenCount == _listOfWords.Count)
            {
                allHidden = true;
                Console.WriteLine("All words are hidden.");
            } else
            {    
                Hide();
            }
        }
        Console.WriteLine("\nThanks for playing");
    }

    public int RandomGenerator(int minValue, int maxValue)
    {
        Random randomNum = new();
        return randomNum.Next(minValue, maxValue);
    }
    
    public void Hide()
    {
        for(int i = 0; i<RandomGenerator(1,3); i++)
        {
            int randomNum = RandomGenerator(0,_listOfWords.Count);
            while (_listOfWords[randomNum].IsHidden())
            {
                randomNum = RandomGenerator(0,_listOfWords.Count);
            }
            _listOfWords[randomNum].SetHidden(true);
        }
    }
}