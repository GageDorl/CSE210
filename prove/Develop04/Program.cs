class Program
{
    static void Main(string[] args)
    {
        Menu();
    }
    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("   1. Start breathing activity");
        Console.WriteLine("   2. Start reflecting activity");
        Console.WriteLine("   3. Start listing activity");
        Console.WriteLine("   4. Quit");
        Console.Write("Select a choice from the menu: ");
        string userChoice = Console.ReadLine();
        Console.Clear();
        switch (userChoice)
        {
            case "1":
                BreathingActivity breathe = new("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                Menu();
                break;
            case "2":
                ReflectingActivity reflect = new("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                Menu();
                break;
            case "3":
                ListingActivity list = new("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                Menu();
                break;
            case "4":
                Console.WriteLine("Bye bye!");
                break;
        }
    }
}