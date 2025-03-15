using System;
using System.Collections.Generic;

class Program
{
    private static List<Goal> _goals = new List<Goal>();
    private static int _totalScore = 0;

    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    DisplayGoals();
                    break;
                case "4":
                    FileHandler.SaveGoals("goals.txt", _goals, _totalScore);
                    Console.WriteLine("Goals and total score saved.");
                    break;
                case "5":
                    _totalScore = FileHandler.LoadGoals("goals.txt", out _goals);
                    Console.WriteLine("Goals and total score loaded.");
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("1. Checklist Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Simple Goal");
        Console.Write("Select goal type: ");
        string type = Console.ReadLine();

        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            Console.Write("Enter target count: ");
            int targetCount = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points: ");
            int bonusPoints = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (type == "3")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
    }

    static void RecordEvent()
    {
        DisplayGoals();
        Console.Write("Select goal index to record: ");
        int index = int.Parse(Console.ReadLine());
        _goals[index].RecordEvent();
        _totalScore += _goals[index]._points; // Update total score
    }

    static void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i}. {_goals[i]}");
        }
        Console.WriteLine($"Total Score: {_totalScore}");
    }
}