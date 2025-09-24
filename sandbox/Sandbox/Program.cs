using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        Console.WriteLine(textInfo.ToTitleCase("Hello sandbox world!"));
    }
}