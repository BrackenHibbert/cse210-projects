public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true; // Mark as completed
        }
    }

    public override string GetProgress()
    {
        return IsComplete ? "Goal completed." : "Goal not completed.";
    }

    public override string ToString()
    {
        return base.ToString();
    }
}