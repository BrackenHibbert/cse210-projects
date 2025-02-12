public class Replace
{
    // Attributes
    private Random random;
    Scripture scripture = new Scripture();

    // Methods
    public List<Word> ReplaceRandomWord()
    {
        List<Word> _words = scripture.GetWords();
        int randomIndex = random.Next(_words.Count);   // Unhandled exception. System.NullReferenceException: Object reference not set to an instance of an object.
                                                       // at Replace.ReplaceRandomWord() in C:\Users\brack\OneDrive - BYU-Idaho\School Work\Winter 2025\Classes 
                                                       //CSE210 C#\cse210-projects\prove\Develop03\Replace.cs:line 11
        Word randomWord = _words[randomIndex];
        string underlines = new string('_', randomWord.GetText().Length);

        _words[randomIndex] = new Word(underlines);

        return _words;
    }
}