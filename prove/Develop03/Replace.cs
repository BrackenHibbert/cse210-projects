public class Replace
{
    // Attributes
    private Random random = new Random();
    private Scripture scripture;
    private HashSet<int> replacedIndexes = new HashSet<int>();
    
    public Replace(Scripture scripture)
    {
        this.scripture = scripture;
    }

    // Methods
    public List<Word> ReplaceRandomWord()
    {
        List<Word> _words = scripture.GetWords();
        int randomIndex;

        do
        {
            randomIndex = random.Next(_words.Count);
        } while (replacedIndexes.Contains(randomIndex) && replacedIndexes.Count < _words.Count);

        replacedIndexes.Add(randomIndex);

        Word randomWord = _words[randomIndex];
        string underlines = new string('.', randomWord.GetText().Length);

        _words[randomIndex] = new Word(underlines);

        return _words;
    }

    public bool CanReplace()
    {
        List<Word> _words = scripture.GetWords();
        return replacedIndexes.Count < _words.Count;
    }

    public void Reset()
    {
        replacedIndexes.Clear();
    }
}