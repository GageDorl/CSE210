using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new("Sameul Bennett", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment math1 = new("7.3", "8-19", "Roberto Rodriguez", "Fractions");
        Console.WriteLine(math1.GetHomeworkList());

        WritingAssignment write1 = new("The Causes of World War II", "Mary Waters", "European History");
        Console.WriteLine(write1.GetWritingInformation());
    }
}