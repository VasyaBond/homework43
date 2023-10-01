using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        string? input = Console.ReadLine();

        long number;
        try
        {
            number = Convert.ToInt64(input);
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка ввода. Введите целое число.");
            return;
        }
        catch (OverflowException)
        {
            Console.WriteLine("Ошибка: введено слишком большое или слишком маленькое число.");
            return;
        }

        long sum = 0;
        long tempNumber = Math.Abs(number);

        while (tempNumber > 0)
        {
            long digit = tempNumber % 10;
            sum += digit;
            tempNumber /= 10;
        }

        Console.WriteLine("Сумма цифр в числе: " + sum);
    }
}
