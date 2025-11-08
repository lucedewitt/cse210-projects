using System.Net;

class Menu
{
    private bool _continue = true;
    private List<string> _names = new List<string>()
    {
        "Breathing",
        "Reflecting",
        "Listing"
    };
    private List<string> _descriptions = new List<string>()
    {
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
        "This activity will help you reflect on good things in your life by having you list as many things as you can in a certain area."
    };
    public void Run()
    {
        while (_continue == true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Quit");
            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                string name = _names[0];
                string description = _descriptions[0];
                Breathing activity1 = new Breathing(name, description);
                activity1.WelcomeMsg();
                activity1.Run();
                activity1.EndMsg();
            }
            else if (choice == 2)
            {
                string name = _names[1];
                string description = _descriptions[1];
                Reflecting activity2 = new Reflecting(name, description);
                activity2.WelcomeMsg();
                activity2.Display();
                activity2.EndMsg();
            }
            else if (choice == 3)
            {
                string name = _names[2];
                string description = _descriptions[2];
                Listing activity3 = new Listing(name, description);
                activity3.WelcomeMsg();
                activity3.Display();
                activity3.EndMsg();
            }
            else if (choice == 4)
            {
                _continue = false;
            }
        }
    }
}