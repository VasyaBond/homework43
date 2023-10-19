using System;

class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Введите значение m: ");
        if (int.TryParse(Console.ReadLine(), out int m))
        {
            Console.Write("Введите значение n: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                int result = Ackermann(m, n);
                Console.WriteLine($"A({m}, {n}) = {result}");
            }
            else
            {
                Console.WriteLine("n должно быть целым числом.");
            }
        }
        else
        {
            Console.WriteLine("m должно быть целым числом.");
        }
    }
}
