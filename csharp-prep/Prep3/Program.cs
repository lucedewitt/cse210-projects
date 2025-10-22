using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 101);

        string guess = "";
        int numGuess = -1;

        int guesses = 0;

        do
        {
            Console.Write("What is your guess? ");
            guess = Console.ReadLine();
            numGuess = int.Parse(guess);
            guesses++;

            if (numGuess > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else if (numGuess < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (!(magicNum == numGuess));
        Console.WriteLine($"It took you {guesses} guesses");
    }
}