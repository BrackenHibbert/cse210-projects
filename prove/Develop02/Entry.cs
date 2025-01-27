using System.ComponentModel.DataAnnotations;

public class Entry
{
    // attributes
    public string _prompt;

    public string _entryDateTime;

    public string _entryText;

    // behavior
    public void Display()
    {
        Console.WriteLine($"{_entryDateTime} {_prompt}");
        Console.WriteLine($"{_entryText}");
    }
}