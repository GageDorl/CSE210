using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int nextNum = -1;
        List<int> numsList = [];
        while (nextNum != 0)
        {
            Console.Write("Enter number: ");
            nextNum = int.Parse(Console.ReadLine());
            if (nextNum != 0)
            {
                numsList.Add(nextNum);
            }
        }
        Console.WriteLine($"The sum is: {numsList.Sum()}");
        Console.WriteLine($"The average is: {numsList.Average()}");
        Console.WriteLine($"The largest number is: {numsList.Max()}");
        int small = 999999;
        foreach (int num in numsList)
        {
            if (num < small && num > 0)
            {
                small = num;
            }
        }
        Console.WriteLine($"The smallest positive number is: {small}");
        numsList.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int num in numsList)
        {
            Console.WriteLine(num);
        }
    }
}