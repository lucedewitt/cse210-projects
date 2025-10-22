using System.ComponentModel.DataAnnotations;

class Word
{
    // attributes
    private string _word;
    private int _length;
    private bool _state;
    // behaviors
    public Word(string word) //constructor
    {
        _word = word;
        _state = true;
        _length = word.Length;
    }
    public void Hide()
    {
        // changes the Word's state to false and replaces every
        // letter with an _
        _state = false;
        _word = "";
        for (int i=0; i < _length; i++)
        {
            _word += "_";
        }
    }
    public bool GetState()
    {
        return _state;
    }
    public string GetWord()
    {
        return _word;
    }
}