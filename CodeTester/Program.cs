using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTester
{
    class Program
    {
        static void Main(string[] args)
        {
            ////string[] names = { "Flag", "Nest", "Cup", "Burg", "Yatch", "Next" };

            ////for (int i = 0; i < names.Length; i++)
            ////{
            ////    var x = names[i];
            ////    var j = i;
            ////    while (j > 0 && names[j - 1].CompareTo(x) > 0)
            ////    {
            ////        names[j] = names[j - 1];
            ////        j = j - 1;
            ////    }
            ////    names[j] = x;
            ////}
            ////Console.ReadKey();


            test();
        }

        public static string test()
        {
            try
            {
                Console.Write("A");
                return "ABC";
            }
            catch (Exception ex)
            {
                Console.Write("B");
                return "ABC";
            }
            finally
            {
                Console.Write("C");
            }
        }
    }
}
