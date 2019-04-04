using System;

namespace ArrayContainsContiguousInteger
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfTestCases = Convert.ToInt32(Console.ReadLine());
            bool[] resultArray = new bool[numberOfTestCases];

            for (int a = 0; a < numberOfTestCases; a++)
            {
                int numberOfElementInTheArray = Convert.ToInt32(Console.ReadLine());
                int[] mainArray = new int[numberOfElementInTheArray];
                
                string[] temp = Console.ReadLine().Split(' ');

                for (int i = 0; i < numberOfElementInTheArray; i++)
                {
                    mainArray[i] = Convert.ToInt32(temp[i]);
                }

                resultArray[a] = ContiguousInteger(numberOfElementInTheArray, mainArray);
            }

            for(int a = 0; a < numberOfTestCases; a++)
            {
                if (resultArray[a])
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }

            Console.ReadKey();
        }

        private static bool ContiguousInteger(int numberOfElementInTheArray, int[] mainArray)
        {
            QuickSort(mainArray, 0, numberOfElementInTheArray - 1);

            for (int i = 0; i < mainArray.Length - 1; i++)
            {
                if (mainArray[i + 1] - mainArray[i] < 2)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        private static void QuickSort(int[] mainArray, int left, int right)
        {
            if (left < right)
            {
                int mid = Partition(mainArray, left, right);

                if (mid > 1)
                {
                    QuickSort(mainArray, left, mid - 1);
                }

                if(mid + 1 < right)
                {
                    QuickSort(mainArray, mid + 1, right);
                }
            }
        }

        private static int Partition(int[] mainArray, int left, int right)
        {
            int pivot = mainArray[right];

            int i = (left - 1);

            for (int j = left; j < right; j++)
            {
                if (mainArray[j] <= pivot)
                {
                    i++;

                    int temp = mainArray[i];
                    mainArray[i] = mainArray[j];
                    mainArray[j] = temp;
                }
            }

            int temp1 = mainArray[i + 1];
            mainArray[i + 1] = mainArray[right];
            mainArray[right] = temp1;

            return i + 1;
        }
    }
}
