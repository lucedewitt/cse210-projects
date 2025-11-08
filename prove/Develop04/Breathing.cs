class Breathing : Activity
{
    public Breathing(string name, string description) : base(1, name, description) { }
    public void BreatheIn()
    {
        Console.Write("\nBreath in...5");
        for (int i = 4; i > 0; i--)
        {
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write($"{i}");
        }
        Thread.Sleep(1000);
        Console.Write("\b \b");
    }
    public void BreatheOut()
    {
        Console.Write("\nBreath out...5");
        for (int i = 4; i > 0; i--)
        {
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write($"{i}");
        }
        Thread.Sleep(1000);
        Console.Write("\b \b");
    }
    public void Run()
    {
        int rounds = _duration / 10;
        if (rounds == 0)
        {
            rounds = 1;
        }
        for (int i = 0; i < rounds; i++)
        {
            BreatheIn();
            BreatheOut();
            Console.WriteLine();
        }
        EndMsg();
    }
}