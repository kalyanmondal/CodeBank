using System;

namespace StructuralPatterns.Facade
{
    public class Credit
    {
        public bool HasGoodCredit(Customer customer)
        {
            Console.WriteLine("Checking Credit for " + customer.Name);

            if (customer.HasGoodCredit)
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
