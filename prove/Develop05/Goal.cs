public abstract class Goal
{
    // Encapsulated fields with public properties
    protected string _name;
    protected string _description;
    public int _points;
    protected bool _isComplete;

    public string Name { get => _name; }
    public string Description { get => _description; }
    public int Points { get => _points; }
    public bool IsComplete { get => _isComplete; }

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    // Abstract methods for polymorphism
    public abstract void RecordEvent();
    public abstract string GetProgress();

    public override string ToString()
    {
        return $"{(IsComplete ? "[X]" : "[ ]")} {Name} - {Description} - {Points} points";
    }
}