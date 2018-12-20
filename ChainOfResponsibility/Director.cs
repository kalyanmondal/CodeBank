using System;

namespace ChainOfResponsibility
{
    class Director : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 10000)
            {
                Console.WriteLine("{0} approved request# {1}", this.GetType().Name, purchase.Number);
            }
            else if (successor != null)
            {
                successor.ProcessRequest(purchase);
            }
        }

    }
}