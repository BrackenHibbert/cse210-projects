public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public int TargetCount { get => _targetCount; }
    public int CurrentCount
    {
        get => _currentCount;
        set => _currentCount = value;
    }
    public int BonusPoints { get => _bonusPoints; }

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _currentCount++;
            if (_currentCount >= _targetCount)
            {
                _isComplete = true;
                _points += _bonusPoints; // Grant bonus points
            }
        }
    }

    public override string GetProgress()
    {
        return $"Completed {CurrentCount}/{TargetCount} times.";
    }

    public override string ToString()
    {
        return base.ToString() + $" - {GetProgress()}";
    }
}