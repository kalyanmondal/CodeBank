using System;
using System.Collections.Generic;

namespace PairsWithPositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTestCases = Convert.ToInt32(Console.ReadLine());
            List<SortedSet<int>> results = new List<SortedSet<int>>();

            for (int a = 0; a < numberOfTestCases; a++)
            {
                int numberOfElementInTheArray = Convert.ToInt32(Console.ReadLine());
                int[] mainArray = new int[numberOfElementInTheArray];

                string[] temp = Console.ReadLine().Split(' ');

                for (int i = 0; i < numberOfElementInTheArray; i++)
                {
                    mainArray[i] = Convert.ToInt32(temp[i]);
                }

                results.Add(PairsWithPositiveNegative(numberOfElementInTheArray, mainArray));
            }

            if (results.Count > 0)
            {
                foreach (var item in results)
                {
                    if (item.Count > 0)
                    {
                        foreach (var items in item)
                        {
                            Console.Write(-items + " ");
                            Console.Write(items + " ");
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("0");
                    }
                }
            }
            
            Console.ReadKey();
        }

        private static SortedSet<int> PairsWithPositiveNegative(int numberOfElementInTheArray, int[] mainArray)
        {
            SortedSet<int> result= new SortedSet<int>();
            SortedSet<int> negativeNumbers = new SortedSet<int>();
            SortedSet<int> positiveNumbers = new SortedSet<int>();

            for (int i = 0; i < numberOfElementInTheArray; i++)
            {
                if (mainArray[i] < 0)
                {
                    negativeNumbers.Add(mainArray[i]);
                }
                else
                {
                    positiveNumbers.Add(mainArray[i]);
                }
            }

            foreach (var item in negativeNumbers)
            {
                if (positiveNumbers.Contains(Math.Abs(item)))
                {
                    result.Add(Math.Abs(item));
                }
            }

            return result;
        }
    }
}
