using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string userValue = Console.ReadLine();

        int gradePercentage = int.Parse(userValue);
        string letter = "";
        int lastDigit = gradePercentage % 10;
        string gradeSign = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (lastDigit >= 7 && !(letter == "A" || letter == "F"))
        {
            gradeSign = "+";
        }
        else if (lastDigit < 3 && letter != "F")
        {
            gradeSign = "-";
        }

        if (!(letter == "A" || letter == "F"))
        {
            Console.WriteLine($"You got a {letter}{gradeSign}");
        }
        else
        {
            Console.WriteLine($"You got an {letter}{gradeSign}");
        }

        if (gradePercentage >= 70)
            {
                Console.WriteLine("Congradulations, you passed the course!");
            }
            else
            {
                Console.WriteLine("You didn't pass the course, but you'll get it next time!");
            }
    }
}