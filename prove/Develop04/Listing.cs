class Listing : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "When have you felt the Holy Ghost this month?",
        "Who are people that you have helped this week?",
        "What are personal strengths of yours?",
        "Who are people that you appreciate?",
        "Who are some of your personal heroes?"
    };
    private string _prompt;
    private int _randint;
    private List<string> _usedPrompts = new List<string>();
    private List<string> _entries = new List<string>();
    private Dictionary<string, List<string>> _sessions = new Dictionary<string, List<string>>();
    public Listing(string name, string description) : base(3, name, description) { }
    public void SelectPrompt()
    {
        bool used = true;
        while (used == true)
        {
            Random randomGenerator = new Random();
            _randint = randomGenerator.Next(0, _prompts.Count);
            _prompt = _prompts[_randint];
            if (_usedPrompts.Count() < _prompts.Count())
            {
                if (!_usedPrompts.Contains(_prompt))
                {
                    used = false;
                }
            }
            else
            {
                used = false;
                _usedPrompts.Clear();
            }
        }
        _usedPrompts.Add(_prompt);
    }
    public void Display()
    {
        SelectPrompt();
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"---{_prompt}---");
        Console.Write("You may begin in: ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        Console.WriteLine();
        while (currentTime < futureTime)
        {
            Console.Write("> ");
            string userInput = Console.ReadLine();
            _entries.Add(userInput);
            currentTime = DateTime.Now;
        }
        _sessions.Add(_prompt, _entries);
    }
}