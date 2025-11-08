class Reflecting : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private List<string> _mainPrompts = new List<string>()
    {
        "Think of a time when you stood up for someone else",
        "Think of a time when you did something really difficult",
        "Think of a time when you helped someone in need",
        "Think of a time when you did something truly selfless",
    };
    private List<string> _usedPrompts = new List<string>();
    private List<string> _usedMainPrompts = new List<string>();
    private int _randint;
    private string _prompt;
    private string _mainPrompt;
    public Reflecting(string name, string description) : base(2, name, description) { }
    public void GetRandomPrompt()
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
    public void GetRandomMainPrompt()
    {
        bool used = true;
        while (used == true)
        {
            Random randomGenerator = new Random();
            _randint = randomGenerator.Next(0, _mainPrompts.Count);
            _mainPrompt = _mainPrompts[_randint];
            if (_usedMainPrompts.Count() < _mainPrompts.Count())
            {
                if (!_usedMainPrompts.Contains(_mainPrompt))
                {
                    used = false;
                }
            }
            else
            {
                used = false;
                _usedMainPrompts.Clear();
            }
        }
        _usedMainPrompts.Add(_prompt);
    }
    public void Display()
    {
        GetRandomMainPrompt();
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n--{_mainPrompt}--");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        Console.Clear();
        while (currentTime < futureTime)
        {
            GetRandomPrompt();
            Console.Write($"\n> {_prompt} ");
            _usedPrompts.Add(_prompt);
            Spinner(DateTime.Now.AddSeconds(10));
            currentTime = DateTime.Now;
        }
        Console.WriteLine();
    }
}