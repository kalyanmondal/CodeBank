using System;

namespace ChainOfResponsibility
{
    class President : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 1000000)
            {
                Console.WriteLine("{0} approved request# {1}",this.GetType().Name, purchase.Number);
            }
            else
            {
                Console.WriteLine("Request# {0} requires an executive meeting!", purchase.Number);
            }
        }
    }
}
