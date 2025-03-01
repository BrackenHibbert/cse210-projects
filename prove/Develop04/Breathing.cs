public class Breathing : Activities
{
    // Attributes
    private string _in;
    private string _out;

    // Initiators
    public Breathing( ) : base("Breathing")
    {
        _in = "Breathe in...";
        _out = "Now breathe out...";
        _explanation = @"This activity will help you relax by walking your through breathing in and out slowly. 
            Clear your mind and focus on your breathing.";
        _activity = "Breathing";
    }

    // Methods
    public void FiveSeconds()
    {
        DateTime start = DateTime.Now;
        DateTime stop = start.AddSeconds(5);
        
        while (DateTime.Now < stop)
        {
            Console.Write("5");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("4");
            Thread.Sleep(1000);
            Console.Write("\b \b");
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

    public void SevenSeconds()
    {
        DateTime start = DateTime.Now;
        DateTime stop = start.AddSeconds(5);
        
        while (DateTime.Now < stop)
        {
            Console.Write("7");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("6");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("5");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("4");
            Thread.Sleep(1000);
            Console.Write("\b \b");
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

    public void Breathe()
    {
        Beginning();

        DateTime _end = GetFutureTime();
        
        while (DateTime.Now < _end)
        {
            Console.WriteLine(_in);
            FiveSeconds();
            Console.WriteLine(_out);
            SevenSeconds();
            Console.WriteLine();
        }

        DisplayOutro();
    }
}