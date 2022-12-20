using System;

namespace IJRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int multipleNumberA = 3;
            int multipleNumberB = 5;
            int min = 0;
            int max = 101;
            int number = random.Next(min, max);
            int sumNumbers = 0;
            Console.WriteLine($"Рандомное число = {number}");
            Console.Write($"Числа кратные {multipleNumberA} и {multipleNumberB} = ");

            for (int i = 1; i <= number; i++)
            {
                if (i % multipleNumberA == 0 || i % multipleNumberB == 0)
                {
                    Console.Write(i + " ");
                    sumNumbers += i;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Сумма числа {number} кратная {multipleNumberA} и {multipleNumberB} ");
            Console.WriteLine(sumNumbers);
        }
    }
}
