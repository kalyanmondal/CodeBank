using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            double c = new double();

            MathProxy mathProxy = new MathProxy("Full");

            Console.WriteLine("Add (4,2) : - " + (mathProxy.Add(4, 2, out c).Equals("You have access!", StringComparison.OrdinalIgnoreCase) ? c.ToString() : mathProxy.Add(4, 2, out c)));
            Console.WriteLine("Sub (4,2) : - " + (mathProxy.Sub(4, 2, out c).Equals("You have access!", StringComparison.OrdinalIgnoreCase) ? c.ToString() : mathProxy.Sub(4, 2, out c)));
            Console.WriteLine("Mul (4,2) : - " + (mathProxy.Mul(4, 2, out c).Equals("You have access!", StringComparison.OrdinalIgnoreCase) ? c.ToString() : mathProxy.Mul(4, 2, out c)));
            Console.WriteLine("Div (4,2) : - " + (mathProxy.Div(4, 2, out c).Equals("You have access!", StringComparison.OrdinalIgnoreCase) ? c.ToString() : mathProxy.Div(4, 2, out c)));

            MathProxy mathProxy2 = new MathProxy();

            Console.WriteLine("Add (4,2) : - " + (mathProxy2.Add(4, 2, out c).Equals("You have access!", StringComparison.OrdinalIgnoreCase) ? c.ToString() : mathProxy2.Add(4, 2, out c)));
            Console.WriteLine("Sub (4,2) : - " + (mathProxy2.Sub(4, 2, out c).Equals("You have access!", StringComparison.OrdinalIgnoreCase) ? c.ToString() : mathProxy2.Sub(4, 2, out c)));
            Console.WriteLine("Mul (4,2) : - " + (mathProxy2.Mul(4, 2, out c).Equals("You have access!", StringComparison.OrdinalIgnoreCase) ? c.ToString() : mathProxy2.Mul(4, 2, out c)));
            Console.WriteLine("Div (4,2) : - " + (mathProxy2.Div(4, 2, out c).Equals("You have access!", StringComparison.OrdinalIgnoreCase) ? c.ToString() : mathProxy2.Div(4, 2, out c)));

            Console.ReadKey();
        }
    }
}
