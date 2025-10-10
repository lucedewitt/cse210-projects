using System.Threading;
class Entry
{
    //atributes
    public List<string> _promptList = new List<string> { "Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", "What was the most beautiful thing you saw today?" };
    public string _prompt;
    public string _entry;
    public string _date;
    //behaviors
    public void DisplayEntry()
    {
        Console.WriteLine($"\nDate: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_entry}");
        Thread.Sleep(2000);
    }
    public void ChoosePrompt()
    {
        // asks if the user wants a prompt or to free write, and displays the chosen option
        while (true)
        {
            Console.Write("Do you want a prompt, or to free write? Type 'prompt' or 'free': ");
            string choice = Console.ReadLine();
            if (choice.ToLower() == "free")
            {
                Console.WriteLine("\n--Free Write--");
                _prompt = "Free Write";
                break;
            }
            else if (choice.ToLower() == "prompt")
            {
                // chooses a random number and prints the corresponding prompt from _prompts
                Random randomGenerator = new Random();
                int randomNum = randomGenerator.Next(0, _promptList.Count);
                _prompt = _promptList[randomNum];
                Console.WriteLine($"\n{_prompt}");
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid option.");
            }
        }
    }
    public string GetDate()
    {
        DateTime currentDate = DateTime.Now;
        string date = currentDate.ToShortDateString();
        return date;
    }
}