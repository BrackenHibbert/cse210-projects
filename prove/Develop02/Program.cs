using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator prompt = new PromptGenerator();
        // Console.WriteLine("Hello Develop02 World!");
        Entry userEntry = new();
        userEntry._prompt = prompt.RandomPrompt();
        userEntry._entryDateTime = "January 27, 2025";
        userEntry._entryText = "Good.";

        userEntry.Display();
    }
}