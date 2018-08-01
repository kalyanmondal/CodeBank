using System;

namespace ArrayRotation
{
    class ArrayRotation
    {
        private void PrintArray(int[] arr)
        {
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        private void RorateArrayOneByOne(int[] arr)
        {
            int i, temp = arr[0];

            for (i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }

            arr[i] = temp;
        }

        private void RorateArray(int[] arr, int d)
        {
            for (int i = 0; i < d; i++)
            {
                RorateArrayOneByOne(arr);
            }
        }

        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };

            ArrayRotation arrayRotation = new ArrayRotation();

            arrayRotation.PrintArray(arr);
            arrayRotation.RorateArray(arr, 4);
            arrayRotation.PrintArray(arr);
        }
    }
}
