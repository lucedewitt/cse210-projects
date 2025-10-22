class Reference
{
    // attributes
    private string _book;
    private int _chapter;
    private string _verse;
    private int _verseStart;
    private int _verseEnd;
    // behaviors
    public Reference(string book, int chap, int verse)
    {
        _book = book;
        _chapter = chap;
        _verse = $"{verse}";
    }
    public Reference(string book, int chap, int vStart, int vEnd)
    {
        // sets variables and combines vStart and vEnd with a - to make _verse
        _book = book;
        _chapter = chap;
        _verseStart = vStart;
        _verseEnd = vEnd;
        _verse = $"{_verseStart}-{_verseEnd}";
    }
    public string GetReference()
    {
        // returns the book, chapter and verse correctly formatted
        return $"{_book} {_chapter}:{_verse} ";
    }
}