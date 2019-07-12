using System;

namespace FindMinInsertionsNeededToPalindrome
{
    class Program
    {
        static int findMinInsertionsNeeded(char[] actualWord, int left, int right)
        {
            if (left > right)
            {
                return int.MaxValue;
            }
            if (left == right)
            {
                return 0;
            }
            if (left == right - 1)
            {
                return (actualWord[left] == actualWord[right]) ? 0 : 1;
            }

            return (actualWord[left] == actualWord[right]) ? findMinInsertionsNeeded(actualWord, left + 1, right - 1) : (Math.Min(findMinInsertionsNeeded(actualWord, left, right - 1), findMinInsertionsNeeded(actualWord, left + 1, right)) + 1);
        }

        public static void Main()
        {
            int NoOfChracter = Convert.ToInt32(Console.ReadLine());
            string actualWord = Console.ReadLine();
            Console.WriteLine(findMinInsertionsNeeded(actualWord.ToCharArray(), 0, NoOfChracter - 1));
            Console.ReadLine();
        }
    }
}
