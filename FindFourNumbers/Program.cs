using System;
using System.Collections.Generic;

namespace FindFourNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int numberOfTestCases = 0; numberOfTestCases < Convert.ToInt32(Console.ReadLine()); numberOfTestCases++)
            {
                int numberOfElementInTheArray = Convert.ToInt32(Console.ReadLine());
                int[] mainArray = new int[numberOfElementInTheArray];

                string[] temp = Console.ReadLine().Split(' ');

                for (int i = 0; i < numberOfElementInTheArray; i++)
                {
                    mainArray[i] = Convert.ToInt32(temp[i]);
                }

                Console.WriteLine(findFourItems(numberOfElementInTheArray, mainArray, Convert.ToInt32(Console.ReadLine())));
            }
        }

        public static bool findFourItems(int length, int[] mainArray, int sum)
        {
            List<HashSet<int>> addition = new List<HashSet<int>>(4);

            addition.Add(new HashSet<int>());
            addition.Add(new HashSet<int>());
            addition.Add(new HashSet<int>());
            addition.Add(new HashSet<int>());

            for (int i = 0; i < length; i++)
            {
                if (mainArray[i] <= sum)
                {
                    addition[0].Add(mainArray[i]);
                }

            }

            return true;
        }
    }
}
