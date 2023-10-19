using System;

class Program
{
    static void PrintNumbersFromNto1(int n) 
    // функция PrintNumbersFromNto1 рекурсивно вызывает себя для вывода чисел от N до 1
    {
        if (n > 0)
        {
            Console.Write(n + ", ");
            PrintNumbersFromNto1(n - 1);
        }
        else if (n == 1)
        {
            Console.Write("1");
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number (N): ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            Console.Write("Numbers from " + n + " to 1: ");
            PrintNumbersFromNto1(n);  
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }
    }
}
