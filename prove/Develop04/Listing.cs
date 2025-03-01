public class Listing : Activities
{
    // Attributes
    private List<string> _prompts;

    // Initiators
    public Listing() : base("Listing")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        _explanation = @"This activity will help you reflect on the good things in your life by having you 
        list as many things as you can in a certain area.";
        _activity = "Listing";
        }

    // Methods
    Random random = new Random();
    public string DisplayPrompt()
    {
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public void List()
    {
        Beginning();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {DisplayPrompt()} ---");
        Console.WriteLine();
        Console.WriteLine("You may begin in:");
        ThreeSeconds();
        
        int responseCounter = 0;

        DateTime _end = GetFutureTime();
        while (DateTime.Now < _end)
        {
            Console.ReadLine();
            responseCounter++;
        }

        Console.WriteLine($"You listed {responseCounter} items!");
        
        DisplayOutro();
    }

}