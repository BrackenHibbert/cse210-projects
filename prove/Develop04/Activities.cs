using System.Net.NetworkInformation;

public class Activities
{
    // Attributes
    private string _intro;
    private string _outro;
    protected string _explanation;
    private int _timer;
    protected string _activity;

    // Intializor
    public Activities(string activity)
    {
        _activity = activity;
        _intro =$"Welcome to the {_activity} Activity.";
        _outro = $"You have completed another {_timer} seconds of the {_activity} Activity.";
    }

    // Get/Setters
    public void SetActivity(string activity)
    {
        _activity = activity;
    }
    
    public void SetTimer()
    {
        Console.WriteLine("How many seconds would you like to do this activity for? ");
        string time = Console.ReadLine();
        _timer = int.Parse(time);
        _outro = $"You have completed another {_timer} seconds of the {_activity} Activity.";
    }

    // Methods
    public void DisplayIntro()
    {
        Console.WriteLine(_intro);
    }

    public void DisplayOutro()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!");
        Spinner(3);
        Console.WriteLine();
        Console.WriteLine(_outro);
        Spinner(5);
        Console.Clear();
    }

    public void DisplayExplanation()
    {
        Console.WriteLine(_explanation);
    }

    public DateTime GetFutureTime()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_timer);
        return futureTime;
    }

    public void Beginning()
    {
        Console.Clear();
        DisplayIntro();
        Console.WriteLine();
        Console.WriteLine(_explanation);
        Console.WriteLine();
        SetTimer();
        Console.Clear();
        Console.WriteLine("Get Ready");
        Spinner(3);
        Console.WriteLine();
    }

    public bool IsTimerUp()
    {
        return DateTime.Now >= GetFutureTime();
    }

    public void Spinner(int time)
    {
        DateTime start = DateTime.Now;
        DateTime stop = start.AddSeconds(time);
        
        while (DateTime.Now < stop)
        {
            Console.Write("<");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("^");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write(">");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("_");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    public void ThreeSeconds()
    {
        DateTime start = DateTime.Now;
        DateTime stop = start.AddSeconds(3);
        
        while (DateTime.Now < stop)
        {
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }


}