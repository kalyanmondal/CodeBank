using System;

namespace PrimeNumber
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            PrintPrimeNumbers(Convert.ToInt32(Console.ReadLine()));

            Console.ReadLine();
        }

        private static void PrintPrimeNumbers(int endNumber)
        {
            for(int i = 1; i <= endNumber; i++)
            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }

                if (count == 2)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
