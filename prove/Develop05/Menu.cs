using System.Runtime.CompilerServices;
using System.IO;

class Menu
{
    private bool _quit = false;
    private int _userchoice;
    private int _totalPoints = 0;
    private List<string> _options = new List<string>()
    {
        "Create New Goal",
        "List Goals",
        "Save Goals",
        "Load Goals",
        "Record Event",
        "Quit"
    };
    private List<Goal> _goals = new List<Goal>();
    private string _filename;
    public void DisplayMenu()
    {
        while (_quit == false) {
            Console.WriteLine($"\nYou have {_totalPoints} points");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            for (int i=0; i < _options.Count(); i++)
            {
                Console.WriteLine($" {i+1}. {_options[i]}");
            }
            Run();
        }
    }
    public void Run()
    {
        Console.Write("Select a choice from the menu: ");
        _userchoice = int.Parse(Console.ReadLine());
        if (_userchoice == 1)
        {
            GoalIntro();
            Console.Write("Which type of goal would you like to create? ");
            int goalChoice = int.Parse(Console.ReadLine());
            if (goalChoice == 1)
            {
                Simple goal = new Simple();
                _goals.Add(goal);
            }
            else if (goalChoice == 2)
            {
                Eternal goal = new Eternal();
                _goals.Add(goal);
            }
            else
            {
                Checklist goal = new Checklist();
                _goals.Add(goal);
            }
        }
        else if (_userchoice == 2)
        {
            Console.WriteLine("The goals are:");
            foreach (Goal goal in _goals)
            {
                Console.Write($"{_goals.IndexOf(goal) + 1}.");
                goal.Display();
            }
            Thread.Sleep(2000);
        }
        else if (_userchoice == 3)
        {
            Console.Write("What is the filename for the goal file? ");
            _filename = Console.ReadLine();
            using (StreamWriter outputFile  = new StreamWriter(_filename))
            {
                foreach (Goal goal in _goals) {
                    outputFile.WriteLine($"{goal.Save()}");
                }
                outputFile.WriteLine($"Points||{_totalPoints}");
            }
        }
        else if (_userchoice == 4)
        {
            Console.Write("What is the filename for the goal file? ");
            _filename = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(_filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split("||");
                string type = parts[0];
                if (type == "Simple")
                {
                    Simple goal = new Simple(parts);
                    goal.Load(parts);
                    _goals.Add(goal);
                }
                else if (type == "Eternal")
                {
                    Eternal goal = new Eternal(parts);
                    goal.Load(parts);
                    _goals.Add(goal);
                }
                else if (type == "Checklist")
                {
                    Checklist goal = new Checklist(parts);
                    goal.Load(parts);
                    _goals.Add(goal);
                }
                else
                {
                    _totalPoints = int.Parse(parts[1]);
                }
            }
        }
        else if (_userchoice == 5)
        {
            GoalsDisplayed();
            Console.Write("Which goal did you accomplish? ");
            int chosenGoal = int.Parse(Console.ReadLine());
            Goal goal = _goals[chosenGoal-1];
            _totalPoints += goal.CompleteGoal();
            if (goal is Checklist c)
            {
                bool miniComplete = c.GetMiniBonusState();
                bool state = c.GetState();
                if (miniComplete == true) {
                    Console.WriteLine($"Congradulations! You have earned {c.GetPoints() + c.GetMiniBonusPoints()} points!");
                }
                else if (state == true)
                {
                    Console.WriteLine($"Congradulations! You have earned {c.GetPoints() + c.GetBonusPoints()} points!");
                }
                else
                {
                    Console.WriteLine($"Congradulations! You have earned {goal.GetPoints()} points!");
                }
            }
            else
            {
                Console.WriteLine($"Congradulations! You have earned {goal.GetPoints()} points!");
            }
            Console.WriteLine($"You now have {_totalPoints} points");
            Thread.Sleep(2000);
        }
        else if (_userchoice == 6)
        {
            _quit = true;
        }
    }
    private void GoalIntro()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
    }
    private void GoalsDisplayed()
    {
        Console.WriteLine("The goals are:");
            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"{_goals.IndexOf(goal) + 1}. {goal.GetName()}");
            }
    }
}