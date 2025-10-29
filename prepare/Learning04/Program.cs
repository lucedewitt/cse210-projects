using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning04 World!");
        Assignment simpleAssignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(simpleAssignment.GetSummary());

        MathAssignment simpleMath = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(simpleMath.GetSummary());
        Console.WriteLine(simpleMath.GetHomeworkList());

        WritingAssignment simpleWriting = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(simpleWriting.GetSummary());
        Console.WriteLine(simpleWriting.GetWritingInformation());
    }
}