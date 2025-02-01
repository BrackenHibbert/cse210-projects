using System;
using System.Collections;

public class Journal
{
    public Entry JournalEntry()
    {
        PromptGenerator prompt = new PromptGenerator();

        // Gets the date and random prompt
        DateTime today = DateTime.Today;
        string entry_prompt = prompt.RandomPrompt();

        // Makes a new entry and assigns the prompt and date to it
        Entry userEntry = new Entry();
        userEntry._prompt = entry_prompt;
        userEntry._entryDateTime = today.ToString("MM/dd/yyyy");

        // Prints out the random prompt and gets the users entry
        Console.WriteLine(entry_prompt);
        userEntry._entryText = Console.ReadLine();

        Console.WriteLine(userEntry);
        return userEntry;
    }
}