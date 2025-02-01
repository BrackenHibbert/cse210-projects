using System.ComponentModel.DataAnnotations;

public class Entry
{
    // attributes
    public string _prompt;

    public string _entryDateTime;

    public string _entryText;

    // behaviord
    public override string ToString()
    {
        return ($"{_entryDateTime}: {_prompt} -- {_entryText}");
    }

}