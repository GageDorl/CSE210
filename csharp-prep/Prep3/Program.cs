using System;

class Program
{
    static void Main(string[] args)
    {
        string cont = "yes";
        while (cont == "yes")
        {
            int guess = 0;
            int guessCount = 0;
            Random randomGen = new Random();
            int magicNum = randomGen.Next(1, 100);
            while (guess != magicNum)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;
                if (guess > magicNum)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNum)
                {
                    Console.WriteLine("Higher");
                }
            }
            Console.WriteLine($"You guessed it in {guessCount} guesses!");
            Console.Write("Want to play again?(yes/no) ");
            cont = Console.ReadLine();
        }
    }
}