using System.ComponentModel;
using System.IO;
using System.IO.Enumeration;
using System.Threading;

class StartMenu
{
    //attributes
    public List<Entry> _entries = new List<Entry>();
    public int _selection;
    public List<Journal> _journals = new List<Journal>();
    public Journal _journal = new Journal();
    //behaviors
    public void Display()
    {
        Console.WriteLine("\nWelcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1) Write");
        Console.WriteLine("2) Display");
        Console.WriteLine("3) Load");
        Console.WriteLine("4) Save");
        Console.WriteLine("5) Quit");
        Console.Write("What would you like to do? ");
        _selection = int.Parse(Console.ReadLine());
    }
    public void Options()
    {
        while (true)
        {
            Display();
            if (_selection == 1)
            {
                // Option: Write
                // creates a new entry, prints prompt & records response + date
                Thread.Sleep(500);

                Entry entry = new Entry();
                entry.ChoosePrompt();
                entry._entry = Console.ReadLine();
                _journal._entries.Add(entry);
                entry._date = entry.GetDate(); ;
                _entries.Add(entry);

                Thread.Sleep(500);
                //add a free-write option for above & beyond?
            }
            else if (_selection == 2)
            {
                // Option: Display
                // cycles through every entry and displays it
                Thread.Sleep(500);

                foreach (Entry entry in _journal._entries)
                {
                    entry.DisplayEntry();
                }
            }
            else if (_selection == 3)
            {
                // Option: Load
                // asks for the name of a file and loads it
                Console.Write("\nWhat is the name of the file you want to load? ");
                string filename = Console.ReadLine();
                _journal.MakeJournal(filename);

                Thread.Sleep(2000);
            }
            else if (_selection == 4)
            {
                // Option: Save
                // asks for the name of the csv file to save to and saves it
                Console.WriteLine("\nSaving...");
                Thread.Sleep(500);

                Console.Write("What is the name of the csv file? ");
                string filename = Console.ReadLine();
                _journal._name = filename;
                using (StreamWriter outputfile = new StreamWriter(filename))
                {
                    foreach (Entry entry in _journal._entries)
                    {
                        outputfile.WriteLine($"{entry._date}~|~{entry._prompt}~|~{entry._entry}");
                    }
                }
                _journals.Add(_journal);

                Thread.Sleep(2000);
            }
            else if (_selection == 5)
            {
                // Option: Quit
                // ends the program
                break;
            }
            else
            {
                // asks for a valid number
                Console.WriteLine("\nPlease enter a valid number.");
                Thread.Sleep(2000);
            }
        }
    }
}