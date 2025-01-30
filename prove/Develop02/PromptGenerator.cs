public class PromptGenerator
{
    public List<string> _prompts;
    public Random random;

    public PromptGenerator()
    {
        _prompts = new List<string>()
        {
            "Who was the most interesting person you intereacted with today?",
            "What was the best part of your day",
            "How did you see the hand of the Lord in your life today?",
            "What was the strongest emotion you felt today?",
            "If you had on thing you could do over today, what would it be?"
        };
    }

    public string RandomPrompt()
    {
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}