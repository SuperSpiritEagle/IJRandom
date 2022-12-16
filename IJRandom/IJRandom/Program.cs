using System;

namespace IJRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number = rand.Next(0, 101);
            int sumNumbers = 0;
            Console.WriteLine($"Рандомное число = {number}");
            Console.Write("Числа кратные 3 и 5 = ");

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.Write(i + " ");
                    sumNumbers += i;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Сумма числа {number} кратная 3 и 5 ");
            Console.WriteLine(sumNumbers);
        }
    }
}
