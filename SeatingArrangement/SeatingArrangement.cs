using System;

namespace SeatingArrangement
{
    class SeatingArrangement
    {
        static void Main(string[] args)
        {
            int numberOfTestCases = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberOfTestCases; i++)
            {
                int seatNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(FindFrontSeat(seatNumber) + " " + FindSeatType(seatNumber));
            }

            Console.ReadLine();
        }

        private static int FindFrontSeat(int seatNumber)
        {
            int a = seatNumber % 12;
            int b = seatNumber / 12;

            switch (a)
            {
                case 0: return -11 + 12 * b;
                default: return 13 - a + 12 * b;
            }
        }

        private static string FindSeatType(int seatNumber)
        {
            int a = seatNumber % 6;
            switch (a)
            {
                case 1:
                default:
                    return "WS";
                case 2:
                case 5:
                    return "MS";
                case 3:
                case 4:
                    return "AS";
            }
        }
    }
}
