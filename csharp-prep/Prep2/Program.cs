using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentString = Console.ReadLine();
        float percentage = float.Parse(percentString);
        string gradeLetter = "";
        bool passed = true;
        if (percentage >= 90)
        {
            gradeLetter = "A";
        }
        else if (percentage >= 80)
        {
            gradeLetter = "B";
        }
        else if (percentage >= 70)
        {
            gradeLetter = "C";
        }
        else if (percentage >= 60)
        {
            gradeLetter = "D";
            passed = false;
        }
        else
        {
            gradeLetter = "F";
            passed = false;
        }

        if (gradeLetter != "F")
        {
            if (percentage % 10 < 3)
            {
                gradeLetter += "-";
            }
            else if (percentage % 10 > 7 && gradeLetter != "A")
            {
                gradeLetter += "+";
            }
        }

        Console.WriteLine($"You {(passed ? "passed" : "failed")} with a grade of {gradeLetter}");
    }
}