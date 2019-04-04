using System;

namespace Palindrome
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfTestCases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numberOfTestCases; i++)
            {
                string inputString = Console.ReadLine();

                if(isPalindrome(inputString))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }

                Console.ReadKey();
            }
        }

        private static bool isPalindrome(string inputString)
        {
            inputString = inputString.ToLower();
            int i = 0;
            int j = inputString.Length - 1;

            while (i <= j)
            {
                char x = inputString[i];
                char y = inputString[j];

                if (!(x >= 48 && x <= 57) && !(x >= 65 && x <= 90) || !(x >= 97 && x <= 122))
                {
                    i++;
                }
                else if (!(y >= 48 && y <= 57) || !(y >= 65 && y <= 90) || !(y >= 97 && y <= 122))
                {
                    j--;
                }
                else if(x == y)
                {
                    i++;
                    j--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
