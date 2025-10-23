using System.Globalization;
using CsvHelper;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = [];
        using (StreamReader reader = new("scriptures.csv"))
        using (CsvReader csv = new(reader, CultureInfo.InvariantCulture))
        {
            scriptures = csv.GetRecords<Scripture>().ToList();
        }

        Random randomGen = new();
        scriptures[randomGen.Next(0, scriptures.Count)].Menu();
    }
}