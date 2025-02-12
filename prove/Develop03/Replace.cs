public class Replace
{
    // Attributes
    private Random random;
    Scripture scripture = new Scripture();

    // Methods
    public List<Word> ReplaceRandomWord()
    {
        List<Word> _words = scripture.GetWords();
        int randomIndex = random.Next(_words.Count);
        Word randomWord = _words[randomIndex];
        string underlines = new string('_', randomWord.GetText().Length);

        _words[randomIndex] = new Word(underlines);

        return _words;
    }
}