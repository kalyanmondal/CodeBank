using System;
using System.Collections.Generic;

namespace StarElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTestCases = Convert.ToInt32(Console.ReadLine());
            List<List<int>> starResultArrays = new List<List<int>>();
            List<int> superStarResultArrays = new List<int>();
            int superStar;

            for (int j = 0; j < numberOfTestCases; j++)
            {
                int numberOfElementInTheArray = Convert.ToInt32(Console.ReadLine());
                int[] mainArray = new int[numberOfElementInTheArray];

                string[] temp = Console.ReadLine().Split(' ');

                for (int i = 0; i < numberOfElementInTheArray; i++)
                {
                    mainArray[i] = Convert.ToInt32(temp[i]);
                }

                starResultArrays.Add(findStarItems(numberOfElementInTheArray, mainArray, out superStar));
                superStarResultArrays.Add(superStar);
            }

            int k = -1;
            foreach (var item in starResultArrays)
            {
                k++;

                for (int i = item.Count; i > 0; i--)
                {
                    Console.Write(item[i - 1] + " ");
                }

                Console.WriteLine();
                Console.WriteLine(superStarResultArrays[k]);
            }

            Console.ReadKey();
        }

        private static List<int> findStarItems(int numberOfElementInTheArray, int[] mainArray, out int superStar)
        {
            List<int> stars = new List<int>();
            superStar = -1;
            int k = numberOfElementInTheArray - 1;
            int flag = mainArray[k];
            int lastFlagPosition = k;

            for (;k >= 0; k--)
            {
                if (k >= 1)
                {
                    if (mainArray[k - 1] > flag)
                    {
                        stars.Add(flag);
                        flag = mainArray[k - 1];
                        lastFlagPosition = k - 1;
                    }
                }
            }

            stars.Add(flag);

            if (lastFlagPosition == 0)
            {
                superStar = flag;
            }
            else
            {
                for (int j = 0; j < lastFlagPosition; j++)
                {
                    if (mainArray[j] < flag)
                    {
                        superStar = flag;
                    }
                    else if (mainArray[j] == flag && lastFlagPosition != j) 
                    {
                        superStar = -1;
                        break;
                    }
                }
            }

            return stars;
        }
    }
}
