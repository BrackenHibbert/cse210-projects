using System.IO;
using System.Collections.Generic;

public static class FileHandler
{
    // Method to save goals and the total score
    public static void SaveGoals(string filePath, List<Goal> goals, int totalScore)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            // Save the total score as the first line
            writer.WriteLine(totalScore);

            // Save each goal in the list
            foreach (Goal goal in goals)
            {
                if (goal is ChecklistGoal checklist)
                {
                    writer.WriteLine($"Checklist|{checklist.Name}|{checklist.Description}|{checklist.Points}|{checklist.CurrentCount}|{checklist.TargetCount}|{checklist.BonusPoints}");
                }
                else if (goal is EternalGoal eternal)
                {
                    writer.WriteLine($"Eternal|{eternal.Name}|{eternal.Description}|{eternal.Points}");
                }
                else if (goal is SimpleGoal simple)
                {
                    writer.WriteLine($"Simple|{simple.Name}|{simple.Description}|{simple.Points}|{simple.IsComplete}");
                }
            }
        }
    }

    // Method to load goals and retrieve the total score
    public static int LoadGoals(string filePath, out List<Goal> goals)
    {
        goals = new List<Goal>();
        int totalScore = 0;

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);

            // Read the total score from the first line
            totalScore = int.Parse(lines[0]);

            // Read and process the goals from the subsequent lines
            for (int i = 1; i < lines.Length; i++) // Start from the second line
            {
                string[] parts = lines[i].Split('|');

                if (parts[0] == "Checklist")
                {
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    int currentCount = int.Parse(parts[4]);
                    int targetCount = int.Parse(parts[5]);
                    int bonusPoints = int.Parse(parts[6]);

                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, targetCount, bonusPoints)
                    {
                        CurrentCount = currentCount
                    };
                    goals.Add(checklistGoal);
                }
                else if (parts[0] == "Eternal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    EternalGoal eternalGoal = new EternalGoal(name, description, points);
                    goals.Add(eternalGoal);
                }
                else if (parts[0] == "Simple")
                {
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    bool isComplete = bool.Parse(parts[4]);

                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                    if (isComplete)
                    {
                        simpleGoal.RecordEvent(); // Mark as completed if loaded as complete
                    }
                    goals.Add(simpleGoal);
                }
            }
        }

        return totalScore; // Return the loaded total score
    }
}