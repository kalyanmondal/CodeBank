using System;
using System.Collections.Generic;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Page> twoPages = new TwoPageDocument().Pages;

            List<Page> threePages = new ThreePageDocument().Pages;

            foreach (var item in twoPages)
            {
                Console.WriteLine(item.GetType().Name.ToString());
            }

            Console.WriteLine("---------------------------------------------------------------------");

            foreach (var item in threePages)
            {
                Console.WriteLine(item.GetType().Name.ToString());
            }

            Console.ReadLine();
        }
    }
}
