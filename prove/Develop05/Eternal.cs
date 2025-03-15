public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        _points += 10; // Add points for every recording
    }

    public override string GetProgress()
    {
        return "Eternal goals have no completion state.";
    }
}