using System;

namespace StructuralPatterns.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            LoanProcessor loanProcessor = new LoanProcessor();

            if (loanProcessor.ProcessLoanHavingSavingsBankAccount(new Customer("Kalyan", true, 1000, 5000, false, true)))
            {
                Console.WriteLine("Approved");
            }
            else
            {
                Console.WriteLine("Rejected");
            }

            if (loanProcessor.ProcessLoanNotHavingSavingsBankAccount(new Customer("Kalyan", true, 1000, 5000, true, true)))
            {
                Console.WriteLine("Approved");
            }
            else
            {
                Console.WriteLine("Rejected");
            }

            if (loanProcessor.ProcessLoanNotHavingSavingsBankAccount(new Customer("Kalyan", false, 1000, 500, false, true)))
            {
                Console.WriteLine("Approved");
            }
            else
            {
                Console.WriteLine("Rejected");
            }

            Console.ReadKey();
        }
    }
}
