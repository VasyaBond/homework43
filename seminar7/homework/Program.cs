using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a series of numbers separated by commas:");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("No numbers entered.");
            return;
        }

        string[] numberStrings = input.Split(',');

        int count = 0;

        foreach (string numberString in numberStrings)
        {
            if (IsPositiveNumber(numberString.Trim()))
            {
                count++;
            }
        }

        Console.WriteLine("Count of numbers greater than 0: " + count);
    }

    public static bool IsPositiveNumber(string value)
    {
        if (double.TryParse(value, out double number))
        {
            return number > 0;
        }
        return false;
    }
}
