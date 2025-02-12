using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");

    // Initialising Classes
        Reference reference = new Reference();
        string _reference = reference.GetReference();

        Replace replace = new Replace();

        Scripture processed = new Scripture();
        List<Word> wordlist = processed.GetWords();

    // Introduction
        Console.WriteLine("Welcome to the Scripture memorizing program. Press Enter to begin the program and move to the next step, type 'quit' to end the program.");
        string choice = Console.ReadLine();

        Console.Clear();
        Console.WriteLine(_reference);
        foreach (Word word in wordlist)
        {
            Console.Write(word.GetText() + " ");
        }

    // Loop for Scripture
        while (choice != "quit")
        {
            Console.Clear();
            Console.WriteLine(_reference);
            List<Word> _newList = replace.ReplaceRandomWord();
            Console.WriteLine(_newList);

            Console.ReadLine();

        }


        foreach (Word word in wordlist)
        {
            Console.Write(word.GetText() + " ");
        }

    }
}