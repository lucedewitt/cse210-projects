class Activity
{
    protected int _duration;
    private string _name;
    private string _description;
    List<string> _loadingString = new List<string>()
    {
        "|",
        "/",
        "-",
        "\\",
        "|",
        "/",
        "-",
        "\\"
    };

    public Activity(int choice, string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void WelcomeMsg()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine($"\n{_description}");
        SetTime();
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner(DateTime.Now.AddSeconds(3));
    }
    public void SetTime()
    {
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }
    public void Spinner(DateTime endTime)
    {
        int i = 0;
        while (DateTime.Now < endTime) {
            string s = _loadingString[i];
            Console.Write(s);
            Thread.Sleep(700);
            Console.Write("\b \b");
            i++;
            if (i >= _loadingString.Count)
            {
                i = 0;
            }
        }
    }
    public void EndMsg()
    {
        Console.WriteLine("\nWell done!!");
        Spinner(DateTime.Now.AddSeconds(3));
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity.");
        Spinner(DateTime.Now.AddSeconds(3));
    }
}