using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число A: ");
        double A;
        try
        {
            A = Convert.ToDouble(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка ввода для числа A. Введите действительное число.");
            return;
        }

        Console.Write("Введите степень B: ");
        int B;
        try
        {
            B = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка ввода для степени B. Введите целое число.");
            return;
        }

        if (B < 0)
        {
            Console.WriteLine("Степень B должна быть неотрицательным целым числом.");
            return;
        }

        double result = 1;

        for (int i = 0; i < B; i++)
        {
            result *= A;
        }

        Console.WriteLine($"{A} в степени {B} = {result}");
    }
}
