public class Scripture
{
    // Attributes
    private string _sentence;
    private List<Word> _words;

    // Methods

    public Scripture()
    {
        _sentence = "And blessed are ye when men shall revile you and persecute, and shall say all manner of evil against you falsely, for my sake;";
        _words = new List<Word>();
        BreakSentence(_sentence);
    }

    public List<Word> GetWords()
    {
        return _words;
    }

    public void SetScripture(List<Word> list)
    {
        _words = list;
    }

    private void BreakSentence(string sentence)
    {
        string[] splitSentence = sentence.Split(' ');

        foreach (string word in splitSentence)
        {
            _words.Add(new Word(word));
        }
    }

    public void DisplaySentence()
    {
        foreach (Word word in _words)
        {
            Console.Write (word.GetText() + " ");
        }
        Console.WriteLine();
    }

}