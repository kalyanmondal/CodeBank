using System;

namespace FindingPairOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int numberOfElementInTheArray = Convert.ToInt32(Console.ReadLine());
            int[] mainArray = new int[numberOfElementInTheArray];

            string[] temp = Console.ReadLine().Split(' ');

            for (int i = 0; i < numberOfElementInTheArray; i++)
            {
                mainArray[i] = Convert.ToInt32(temp[i]);
            }

            int max = mainArray[0];

            for (int j = 0; j < mainArray.Length; j++)
            {
                if (mainArray[j] > max)
                {
                    max = mainArray[j];
                }
            }

            int[] subArray = new int[max];

            for (int k = 0; k < mainArray.Length; k++)
            {
                subArray[mainArray[k] - 1] += 1;
            }

            for (int l = 0; l < subArray.Length; l++)
            {
                if (subArray[l] != 0)
                {
                    result += subArray[l] / 2;
                }
            }
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
