using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numList = new List<int>();
        Console.WriteLine("Enter a list of numbers, and type 0 when finished.");

        string stringNum = "";
        int num = -1;
        int sum = 0;
        int count = 0;
        int max = 0;

        while (num != 0)
        {
            Console.Write("Enter a number: ");
            stringNum = Console.ReadLine();
            num = int.Parse(stringNum);

            sum = sum + num;
            if (num > max)
            {
                max = num;
            }

            if (num != 0)
            {
                numList.Add(num);
                count++;
            }
        }
        double average = (sum*1.0) / count;
        // count = numList.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}