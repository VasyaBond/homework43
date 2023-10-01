using System;

class Program
{
    static void Main()
    {
        // Создаем массив из 8 элементов
        int[] numbers = new int[8];

        // Заполняем массив элементами
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Введите элемент " + (i + 1) + ": ");
            string input = Console.ReadLine();

            try
            {
                int number = Convert.ToInt32(input);
                numbers[i] = number;
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка ввода. Введите целое число.");
                return;
            }
        }

        // Выводим массив на экран
        Console.Write("Массив: [");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i]);
            if (i < numbers.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}
