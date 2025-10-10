class Journal
{
    //atributes
    public string _name;
    public List<Entry> _entries = new List<Entry>();
    //behaviors
    public void AppendEntry(Entry e)
    {
        _entries.Add(e);
    }
    // public List<Entry> ReturnEntries()
    // {
    //     return _entries;
    // }
    public void MakeJournal(string filename)
    {
        // reads the contents of the file and creates entries and a journal
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");

            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];

            Entry entry = new Entry();
            entry._prompt = prompt;
            entry._date = date;
            entry._entry = response;

            _entries.Add(entry);
        }
    }
}