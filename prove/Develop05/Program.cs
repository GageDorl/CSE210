using System.IO;

class Program
{
    static List<SimpleGoal> _goals = [];
    static int _points = 0;
    static int _level = 1;
    static void Main(string[] args)
    {
        Menu();
    }
    static void Menu()
    {
        Console.WriteLine($"You have {_points} points.");
        Console.WriteLine($"You are Level {_level}!\n");
        Console.Write("Menu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit\nSelect a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                CreateGoal();
                break;
            case 2:
                Display();
                break;
            case 3:
                Save();
                break;
            case 4:
                Load();
                break;
            case 5:
                CompleteGoal();
                break;
            case 6:
                return;
            default:
                break;

        }
        Menu();
    }

    static void CreateGoal()
    {
        Console.Write("The types of Goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal\nWhich type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());
        Console.Write("What is the name of your goal? ");
        string title = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associeted with this goal? ");
        int points = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                _goals.Add(new SimpleGoal(title, description, points));
                break;
            case 2:
                _goals.Add(new EternalGoal(title, description, points));
                break;
            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int requirement = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(title, description, points, requirement, bonus));
                break;
            default:
                CreateGoal();
                break;
        }
    }

    static void Display()
    {
        int i = 1;
        Console.WriteLine("The goals are:");
        foreach(SimpleGoal goal in _goals)
        {
            Console.Write($"{i}. ");
            goal.Display();
            i++;
        }
    }

    static void Save()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new(filename))
        {
            outputFile.WriteLine(_points);
            outputFile.WriteLine(_level);
            foreach(SimpleGoal goal in _goals)
            {
                outputFile.WriteLine(goal.getStringRepresentation());
            }
        }
    }

    static void Load()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        _points = int.Parse(lines[0]);
        _level = int.Parse(lines[1]);
        lines = lines.Skip(2).ToArray();
        foreach(string line in lines)
        {
            string[] parts = line.Split("|");
            switch (parts[0])
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                    break;
                case "ChecklistGoal":
                    _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
                    break;
            }
        }
    }
    
    static void CompleteGoal()
    {
        Console.WriteLine("The goals are:");
        int i = 1;
        foreach (SimpleGoal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.getTitle()}");
            i++;
        }
        Console.Write("Which goal did you accomplish? ");
        int goalNum = int.Parse(Console.ReadLine()) - 1;
        int reward = _goals[goalNum].Complete();
        Console.WriteLine($"Congratulations! You have earned {reward} points!");
        _points += reward;
        if (_points >= 100)
        {
            _level+=1;
            _points-=100;
            Console.WriteLine($"You Leveled Up! You are now Level {_level}!");
        }
    }
}