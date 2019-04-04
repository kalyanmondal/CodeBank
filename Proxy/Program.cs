using System;

namespace StructuralPatterns.Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            MathProxy mathProxy = new MathProxy();

            Console.WriteLine("Add (4,2) : -> " + mathProxy.Add(4, 2));

            Console.WriteLine("Sub (4,2) : -> " + mathProxy.Sub(4, 2));

            Console.WriteLine("Mul (4,2) : -> " + mathProxy.Mul(4, 2));

            Console.WriteLine("Div (4,2) : -> " + mathProxy.Div(4, 2));

            Console.ReadKey();
        }
    }
}
