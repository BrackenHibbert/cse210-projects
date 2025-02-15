using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");

    // Initialising Classes
        Reference reference = new Reference();
        string _reference = reference.GetReference();

        Scripture scripture = new Scripture();


    // Introduction
        Console.WriteLine("Welcome to the Scripture memorizing program. Press Enter to begin the program and move to the next step, type 'quit' to end the program.");
        string choice = Console.ReadLine();

        Console.Clear();
        Console.WriteLine(_reference);
        scripture.DisplaySentence();

        Replace replace = new Replace(scripture);
        replace.Reset();

    // Loop for Scripture
        while (choice != "quit" && replace.CanReplace())
        {
            Console.Clear();
            Console.WriteLine(_reference);
            List<Word> _newList = replace.ReplaceRandomWord();  
            scripture.SetScripture(_newList);
            scripture.DisplaySentence();

            choice = Console.ReadLine();
        }

    }
}