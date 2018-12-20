using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Approver director = new Director();
            Approver vicePresident = new VicePresident();
            Approver president = new President();

            director.SetSuccessor(vicePresident);
            vicePresident.SetSuccessor(president);

            Purchase p = new Purchase(1, 7000, "Assets");
            director.ProcessRequest(p);

            p = new Purchase(2, 35000, "Project X");
            director.ProcessRequest(p);

            p = new Purchase(3, 950000, "Project Y");
            director.ProcessRequest(p);

            p = new Purchase(4, 1100000, "Project Y");
            director.ProcessRequest(p);

            Console.ReadKey();
        }
    }
}
