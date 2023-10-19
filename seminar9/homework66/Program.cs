using System;

class Program
{
    static int CalculateSumOfNaturalNumbers(int m, int n)
    // метод CalculateSumOfNaturalNumbers, вычисляет сумму натуральных чисел в указанном диапазоне от M до N
    {
        if (m > n)
        {
            // Если M больше N, меняем их местами
            int temp = m;
            m = n;
            n = temp;
        }

        int sum = 0;
        for (int i = m; i <= n; i++)
        {
            sum += i;
        }

        return sum;
    }

    static void Main(string[] args)
    {
        Console.Write("Введите значение M: ");
        if (int.TryParse(Console.ReadLine(), out int m))
        {
            Console.Write("Введите значение N: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                int sum = CalculateSumOfNaturalNumbers(m, n);
                Console.WriteLine($"Сумма натуральных чисел в диапазоне от {m} до {n}: {sum}");
            }
            else
            {
                Console.WriteLine("N должно быть целым числом.");
            }
        }
        else
        {
            Console.WriteLine("M должно быть целым числом.");
        }
    }
}
