using System;
using System.Threading;

namespace CodeTester
{
    class program
    {
        static ConsoleColor prevColor = Console.ForegroundColor;
        static AutoResetEvent autoReset = new AutoResetEvent(false);
        static ManualResetEvent manualReset = new ManualResetEvent(false);
        static void Main(string[] args)
        {
            Console.Title = "AutoResetEvent and ManualResetEvent";
            Thread t1 = new Thread(new ThreadStart(AutoResetMethod));
            Thread t2 = new Thread(new ThreadStart(ManualResetMethod));
            t1.Name = "Thread1";
            t2.Name = "Thread2";
            Thread.CurrentThread.Name = "Main Thread";

            //t1.Start();      // Please Uncomment this while using AutoResetEvent.  
            t2.Start();   // Please Uncomment this while using ManualResetEvent.  

            Console.ReadLine();
            Console.WriteLine("Thread1 Paused for Task1...");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t\t\tRunning Thread: {0}", Thread.CurrentThread.Name);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Executing Task on Main Thread....");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(" {0}", i);
                Thread.Sleep(1000);
            }
            Console.WriteLine();
            Console.WriteLine("Task Completed on Main Thread....");
            manualReset.Set();    // Please Uncomment this while using ManualResetEvent.  
            //autoReset.Set();        // Please Uncomment this while using AutoResetEvent.  

            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t\t\tRunning Thread: {0}", Thread.CurrentThread.Name);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Thread1 Paused for Task2...");
            Console.WriteLine("Doing some work in Main Thread......");
            manualReset.Set();     // Please Uncomment this while using ManualResetEvent.  
            //autoReset.Set();        // Please Uncomment this while using AutoResetEvent.  
            Console.ForegroundColor = prevColor;
        }

        static void ManualResetMethod()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t***************** ManualResetEvent ***************");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t\t\tRunning Thread: {0}", Thread.CurrentThread.Name);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Executing Task1......");
            Console.WriteLine("Press Enter to Pause Task1..");
            //Wait for first task:  
            manualReset.WaitOne();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t\t\tRunning Thread: {0}", Thread.CurrentThread.Name);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n===================================");
            Console.WriteLine("Executing Task1.....");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Task1 executing.....");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Execution of Task1 completed..");
            Console.WriteLine("===================================");
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine("Executing Task2......");
            Console.WriteLine("Press Enter to Pause Task2..");
            //Wait for second task:  
            manualReset.WaitOne();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t\t\tRunning Thread: {0}", Thread.CurrentThread.Name);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Execution of Task2 completed...");
            Console.WriteLine("===================================");
            Console.ForegroundColor = prevColor;
        }

        static void AutoResetMethod()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t***************** AutoResetEvent ***************");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t\t\tRunning Thread: {0}", Thread.CurrentThread.Name);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Executing Task1......");
            Console.WriteLine("Press Enter to Pause Task1..");
            //Wait for first task:  
            autoReset.WaitOne();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t\t\tRunning Thread: {0}", Thread.CurrentThread.Name);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n===================================");
            Console.WriteLine("Executing Task1.....");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Task1 executing.....");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Execution of Task1 completed..");
            Console.WriteLine("===================================");
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine("Executing Task2......");
            Console.WriteLine("Press Enter to Pause Task2..");
            //Wait for second task:  
            autoReset.WaitOne();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t\t\tRunning Thread: {0}", Thread.CurrentThread.Name);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Execution of Task2 completed...");
            Console.WriteLine("===================================");
            Console.ForegroundColor = prevColor;
        }
    }
}
