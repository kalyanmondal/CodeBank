using System;
using System.Collections.Generic;
using System.Linq;

namespace TallestStudent
{
    class TallestStudent
    {
        static void PrintHighest(int n, int[] arr)
        {
            int i, j, k;
            List<CountAndPosition> CP = new List<CountAndPosition>();

            for (i = 0; i < n; i++)
            {
                k = 0;
                for (j = i + 1; j < n; j++)
                {
                    k = k + 1;
                    if (arr[i] < arr[j])
                    {
                        break;
                    }
                }

                CP.Add(new CountAndPosition(i + 1, k));
            }

            int position = CP.OrderByDescending(x => x.CountOfStudent).ThenByDescending(x => x.Position).ToList().First().Position;

            Console.WriteLine(position);
        }

        public static void Main()
        {
            int numOfTestCase = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numOfTestCase; i++)
            {
                int numOfStudent = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[numOfStudent];

                string[] a = Console.ReadLine().Split(' ');

                PrintHighest(numOfStudent, a.Select(int.Parse).ToArray());

                Console.ReadKey();
            }
        }

        public class CountAndPosition
        {
            public CountAndPosition(int position, int count)
            {
                this.Position = position;
                this.CountOfStudent = count;
            }

            public int Position { get; set; }

            public int CountOfStudent { get; set; }
        }
    }
}
