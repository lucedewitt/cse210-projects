using System.Data;
using System.Net.Quic;

class Scripture
{
    // attributes
    private string _scripture;
    private List<Word> _words = new List<Word>();
    private List<Word> _seenWords = new List<Word>();
    private string _reference;
    private string _input;
    // behaviors
    public Scripture(string scripture, Reference reference)
    {
        // splits the scripture's text into indivuals Words and stores variables
        _scripture = scripture;
        _reference = reference.GetReference();
        string[] pieces = scripture.Split(" ");
        foreach (string piece in pieces)
        {
            Word wordPiece = new Word(piece);
            _words.Add(wordPiece);
        }
    }
    public void Display()
    {
        // prints the Reference and _words (both hidden and shown)
        Console.Write(_reference);
        foreach (Word word in _words)
        {
            Console.Write($" {word.GetWord()}");
        }
    }
    public void HideWords()
    {
        // if there are more than 3 shown words, create a list of shown words, and choose
        // three random words from that list to hide (no duplicate hidden words), else hide
        // all remaining words
        if (_words.Count > 3)
        {
            _seenWords.Clear();
            foreach (Word word in _words)
            {
                // bool state = word.GetState();
                if (word.GetState() == true)
                {
                    _seenWords.Add(word);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                bool unique = false;
                while (unique == false)
                {
                    Random randomGenerator = new Random();
                    int randomNum = randomGenerator.Next(0, _seenWords.Count);
                    Word word = _seenWords[randomNum];
                    if (word.GetState() == true)
                    {
                        word.Hide();
                        unique = true;
                    }
                }
            }
        }
        else
        {
            foreach (Word word in _words)
            {
                word.Hide();
            }
        }
    }
    public void MemorizeLoop()
    {
        // Displays the scripture, triggers HideWords() on enter, ends with no seen
        // words are left (IsHidden()) or when user types 'quit'
        Console.Clear();
        Display();
        bool hidden = IsHidden();
        while (hidden == false)
        {
            Console.WriteLine($"\nPlease enter to continue or type 'quit' to finish:");
            _input = Console.ReadLine();
            if (_input != "quit")
            {
                Console.Clear();
                HideWords();
                Display();
                hidden = IsHidden();
            }
            else
            {
                break;
            }
        }
        if (_input != "quit")
        {
            Console.WriteLine($"\nPlease enter to continue or type 'quit' to finish:");
            string newInput = Console.ReadLine();
        }
    }
    public bool IsHidden()
    {
        // checks all the Words in _words and returns true if 
        // they're all hidden, false if not
        bool hidden = false;
        if (_words.All(w => w.GetState() == false))
        {
            hidden = true;
        }
        return hidden;
    }
}