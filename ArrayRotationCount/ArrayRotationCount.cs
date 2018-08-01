using System;

namespace ArrayRotationCount
{
    class ArrayRotationCount
    {
        internal int CountRotations(int[] arr)
        {

            int min = arr[0], index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                    index = i;
                }
            }
            return arr.Length - index;
        }

        static void Main(string[] args)
        {
            int[] arrRotated = { 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            ArrayRotationCount arrayRotationCount = new ArrayRotationCount();

            Console.WriteLine("The Input array has been rotated {0} time from the orginal array", arrayRotationCount.CountRotations(arrRotated));
        }
    }
}
