using System;

namespace IJRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int numberThree = 3;
            int numberFive = 5;
            int min = 0;
            int max = 101;
            int number = rand.Next(min, max);
            int sumNumbers = 0;
            Console.WriteLine($"Рандомное число = {number}");
            Console.Write("Числа кратные 3 и 5 = ");

            for (int i = 1; i <= number; i++)
            {
                if (i % numberThree == 0 || i % numberFive == 0)
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
