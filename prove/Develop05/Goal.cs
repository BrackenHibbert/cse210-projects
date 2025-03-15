public class Goal
{
    // Attributes
    protected string _goal;
    protected string _description;
    protected int _points;
    protected bool _status;
    private int _totalScore;
    private List<Goal> _goalList;
    protected string _fullGoal;

    // Initializors
public Goal()
{
    Console.WriteLine("What is your goal? ");
    _goal = Console.ReadLine();
    Console.WriteLine();

    Console.WriteLine("Give a brief description of your goal: ");
    _description = Console.ReadLine();
    Console.WriteLine();

    Console.WriteLine("How many points is it worth? ");
    _points = int.Parse(Console.ReadLine());
    Console.WriteLine();

    _status = false;
    _totalScore = 0;
    _goalList = new();
    _fullGoal = AssembleGoal();
}


    // Methods
public string AssembleGoal()
{
    string status;
    if (_status)
    {
        status = "[X]";
    }
    else
    {
        status = "[ ]";
    }

    return ($"{status} - {_goal} - {_description} - {_points}");
}

public void RecordEvent()
{

}

}