using System;

namespace StructuralPatterns.Facade
{
    public class Loan
    {
        public bool HasNoBadLoans(Customer customer)
        {
            Console.WriteLine("Checking loans for " + customer.Name);

            if (customer.HasBadLoan)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
