using System;

namespace StructuralPatterns.Facade
{
    public class Bank
    {
        public bool HasSufficientSavings(Customer customer)
        {
            Console.WriteLine("Checking bank for " + customer.Name);

            if (customer.LoanAmount <= customer.BalanceAmount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
