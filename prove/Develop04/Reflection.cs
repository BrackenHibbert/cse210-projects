public class Reflection : Activities
{
    // Attributes
    private List<string> _prompts;
    private List<string> _questions;


    // Initiators
    public Reflection() : base("Reflection")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        _explanation = @"This activity will help you reflect on times in your life when you have shown strength and resilience. 
        This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _activity = "Reflection";
    }

    // Methods
    Random random = new Random();
    public string DisplayPrompt()
    {
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public void DisplayQuestion()
    {
        int index = random.Next(_questions.Count);
        Console.WriteLine(_questions[index]);
    }
    
    public void Reflect()
    {
        Beginning();

        Console.WriteLine("Consider the folllowing prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {DisplayPrompt()} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ThreeSeconds();
        Console.Clear();

        DateTime _end = GetFutureTime();
        while (DateTime.Now < _end)
        {
            DisplayQuestion();
            Spinner(8);
        }
    DisplayOutro();
    }

}