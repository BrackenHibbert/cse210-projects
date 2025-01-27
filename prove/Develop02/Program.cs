using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!");
        Entry userEntry = new();
        userEntry._prompt = "How was your day?";
        userEntry._entryDateTime = "January 27, 2025";
        userEntry._entryText = "Good.";

        userEntry.Display();
    }
}