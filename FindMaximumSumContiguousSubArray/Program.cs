using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumSumContiguousSubArray
{
    class Program
    {
        public static void Main()
        {
            int numberOfTestCases = Convert.ToInt32(Console.ReadLine());
            int[] resultArray = new int[numberOfTestCases];

            for (int a = 0; a < numberOfTestCases; a++)
            {
                int numberOfElementInTheArray = Convert.ToInt32(Console.ReadLine());
                int[] mainArray = new int[numberOfElementInTheArray];

                string[] temp = Console.ReadLine().Split(' ');

                for (int i = 0; i < numberOfElementInTheArray; i++)
                {
                    mainArray[i] = Convert.ToInt32(temp[i]);
                }

                resultArray[a] = findMaximumSumContiguousSubArray(mainArray, 0, numberOfElementInTheArray - 1);
            }

            for (int a = 0; a < numberOfTestCases; a++)
            {
                Console.WriteLine(resultArray[a]);
            }
        }

        static int findMaximumSumContiguousSubArray(int[] inputArray, int startingPoint, int numberOfElement)
        {
            if (startingPoint == numberOfElement)
            {
                return inputArray[startingPoint];
            }

            int mid = (startingPoint + numberOfElement) / 2;

            return Math.Max(Math.Max(findMaximumSumContiguousSubArray(inputArray, startingPoint, mid), findMaximumSumContiguousSubArray(inputArray, mid + 1, numberOfElement)), sumOfSubArrayWhichIsSpreadedBothSideOfMidElement(inputArray, startingPoint, mid, numberOfElement));
        }

        static int sumOfSubArrayWhichIsSpreadedBothSideOfMidElement(int[] inputArray, int startingPoint, int mid, int numberOfElement)
        {
            int sum = 0;
            int leftSideElementsSum = int.MinValue;

            for (int i = mid; i >= startingPoint; i--)
            {
                sum = sum + inputArray[i];
                if (sum > leftSideElementsSum)
                    leftSideElementsSum = sum;
            }

            sum = 0;

            int rightSideElementsSum = int.MinValue;

            for (int i = mid + 1; i <= numberOfElement; i++)
            {
                sum = sum + inputArray[i];
                if (sum > rightSideElementsSum)
                    rightSideElementsSum = sum;
            }

            return leftSideElementsSum + rightSideElementsSum;
        }
    }
}
