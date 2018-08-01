using System;

namespace ArrayRotationReversalAlogorithm
{
    class ArrayRotationReversalAlogorithm
    {
        private void RorateArray(int[] arr, int d)
        {
            int n = arr.Length;
            ReverseArray(arr, 0, d - 1);
            ReverseArray(arr, d, n - 1);
            ReverseArray(arr, 0, n - 1);
        }

        private void ReverseArray(int[] arr, int start, int end)
        {
            int temp;
            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                start++;
                end--;
            }
        }

        private void PrintArray(int[] arr)
        {
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };

            ArrayRotationReversalAlogorithm arrayRotationReversalAlogorithm = new ArrayRotationReversalAlogorithm();

            arrayRotationReversalAlogorithm.PrintArray(arr);
            arrayRotationReversalAlogorithm.RorateArray(arr, 4);
            arrayRotationReversalAlogorithm.PrintArray(arr);
        }
    }
}
