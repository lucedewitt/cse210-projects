using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation4 World!");
        List<Exercise> exercises = new List<Exercise>();
        Run running = new Run("04 April 2024", 45, 4);
        exercises.Add(running);

        Bike biking = new Bike("22 November 2022", 25, 11);
        exercises.Add(biking);

        Swim swimming = new Swim("13 July 2023", 33, 88);
        exercises.Add(swimming);

        Console.WriteLine("------------------------------------------------------");
        foreach (Exercise exercise in exercises)
        {
            exercise.Summary();
            Console.WriteLine("\n");
            Thread.Sleep(1500);
        }
        Console.WriteLine("------------------------------------------------------");
    }
}