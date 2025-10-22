using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string usrInput = Console.ReadLine();
            int num = int.Parse(usrInput);
            return num;
        }

        static void PromptUserBirthYear(out int year)
        {
            Console.Write("Please enter the year you were born: ");
            year = int.Parse(Console.ReadLine());
        }

        static int SquareNumber(int num)
        {
            int squared = num * num;
            return squared;
        }

        static void DisplayResult(string name, int squared, int year)
        {
            Console.WriteLine($"{name}, the square of your number is {squared}");
            int age = 2025 - year;
            Console.WriteLine($"{name}, you will turn {age} this year.");
        }

        static void Main()
        {
            DisplayWelcome();
            string name = PromptUserName();
            int num = PromptUserNumber();
            int year;
            PromptUserBirthYear(out year);
            int squared = SquareNumber(num);
            DisplayResult(name, squared, year);
        }
        Main();
    }
}