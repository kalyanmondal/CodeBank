////using Newtonsoft.Json;
////using System;

////namespace CodeTester
////{
////    class Program
////    {
////        static void Main(string[] args)
////        {
////            Employee e = new Employee()
////            {
////                FirstName = "FN",
////                LastName = "LN",
////                Gender = "M",
////                Salary = 10000,
////                Id = 1
////            };

////            var settings = new JsonSerializerSettings()
////            {
////                NullValueHandling = NullValueHandling.Include,
////                TypeNameHandling = TypeNameHandling.All,
////                TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Full
////            };

////            string a = JsonConvert.SerializeObject(e, settings);
////            string b = JsonConvert.SerializeObject(e);

////            Employee e1 = DeSerialize<Employee>(a);
////        }

////        public static T DeSerialize<T>(string segment, bool includeType = false)
////        {
////            var settings = new JsonSerializerSettings()
////            {
////                NullValueHandling = NullValueHandling.Ignore,
////                TypeNameHandling = includeType ? TypeNameHandling.All : TypeNameHandling.None,
////                TypeNameAssemblyFormatHandling = includeType ? TypeNameAssemblyFormatHandling.Full : TypeNameAssemblyFormatHandling.Simple
////            };

////            return JsonConvert.DeserializeObject<T>(segment, settings);
////        }
////    }
////}

////using System;
////using System.Threading;

////namespace SecondChangeEvent
////{
////    /* ======================= Event Publisher =============================== */

////    // Our subject -- it is this class that other classes
////    // will observe. This class publishes one event:
////    // SecondChange. The observers subscribe to that event.
////    public class Clock
////    {
////        // Private Fields holding the hour, minute and second
////        private int _hour;
////        private int _minute;
////        private int _second;

////        // The delegate named SecondChangeHandler, which will encapsulate
////        // any method that takes a clock object and a TimeInfoEventArgs
////        // object as the parameter and returns no value. It's the
////        // delegate the subscribers must implement.
////        public delegate void SecondChangeHandler(
////           object clock,
////           TimeInfoEventArgs timeInformation
////        );

////        // The event we publish
////        public event SecondChangeHandler SecondChange;

////        // The method which fires the Event
////        protected void OnSecondChange(
////           object clock,
////           TimeInfoEventArgs timeInformation
////        )
////        {
////            // Check if there are any Subscribers
////            if (SecondChange != null)
////            {
////                // Call the Event
////                SecondChange(clock, timeInformation);
////            }
////        }

////        // Set the clock running, it will raise an
////        // event for each new second
////        public void Run()
////        {
////            for (; ; )
////            {
////                // Sleep 1 Second
////                Thread.Sleep(1000);

////                // Get the current time
////                System.DateTime dt = System.DateTime.Now;

////                // If the second has changed
////                // notify the subscribers
////                if (dt.Second != _second)
////                {
////                    // Create the TimeInfoEventArgs object
////                    // to pass to the subscribers
////                    TimeInfoEventArgs timeInformation =
////                       new TimeInfoEventArgs(
////                       dt.Hour, dt.Minute, dt.Second);

////                    // If anyone has subscribed, notify them
////                    OnSecondChange(this, timeInformation);
////                }

////                // update the state
////                _second = dt.Second;
////                _minute = dt.Minute;
////                _hour = dt.Hour;

////            }
////        }
////    }

////    // The class to hold the information about the event
////    // in this case it will hold only information
////    // available in the clock class, but could hold
////    // additional state information
////    public class TimeInfoEventArgs : EventArgs
////    {
////        public TimeInfoEventArgs(int hour, int minute, int second)
////        {
////            this.hour = hour;
////            this.minute = minute;
////            this.second = second;
////        }
////        public readonly int hour;
////        public readonly int minute;
////        public readonly int second;
////    }

////    /* ======================= Event Subscribers =============================== */

////    // An observer. DisplayClock subscribes to the
////    // clock's events. The job of DisplayClock is
////    // to display the current time
////    public class DisplayClock
////    {
////        // Given a clock, subscribe to
////        // its SecondChangeHandler event
////        public void Subscribe(Clock theClock)
////        {
////            theClock.SecondChange +=
////               new Clock.SecondChangeHandler(TimeHasChanged);
////        }

////        // The method that implements the
////        // delegated functionality
////        public void TimeHasChanged(
////           object theClock, TimeInfoEventArgs ti)
////        {
////            Console.WriteLine("Current Time: {0}:{1}:{2}",
////               ti.hour.ToString(),
////               ti.minute.ToString(),
////               ti.second.ToString());
////        }
////    }

////    // A second subscriber whose job is to write to a file
////    public class LogClock
////    {
////        public void Subscribe(Clock theClock)
////        {
////            theClock.SecondChange +=
////               new Clock.SecondChangeHandler(WriteLogEntry);
////        }

////        // This method should write to a file
////        // we write to the console to see the effect
////        // this object keeps no state
////        public void WriteLogEntry(
////           object theClock, TimeInfoEventArgs ti)
////        {
////            Console.WriteLine("Logging to file: {0}:{1}:{2}",
////               ti.hour.ToString(),
////               ti.minute.ToString(),
////               ti.second.ToString());
////        }
////    }

////    /* ======================= Test Application =============================== */

////    // Test Application which implements the
////    // Clock Notifier - Subscriber Sample
////    public class Test
////    {
////        public static void Main()
////        {
////            // Create a new clock
////            Clock theClock = new Clock();

////            // Create the display and tell it to
////            // subscribe to the clock just created
////            DisplayClock dc = new DisplayClock();
////            dc.Subscribe(theClock);

////            // Create a Log object and tell it
////            // to subscribe to the clock
////            LogClock lc = new LogClock();
////            lc.Subscribe(theClock);

////            // Get the clock started
////            theClock.Run();
////        }
////    }
////}

////using System;
////using System.IO;

////namespace CodeTester
////{
////    public class PrintHelper
////    {
////        // declare delegate 
////        public delegate void BeforePrint();

////        //declare event of type delegate
////        public event BeforePrint beforePrintEvent;

////        public PrintHelper()
////        {

////        }

////        public void PrintNumber(int num)
////        {
////            //call delegate method before going to print
////            if (beforePrintEvent != null)
////                beforePrintEvent();

////            Console.WriteLine("Number: {0,-12:N0}", num);
////        }

////        public void PrintDecimal(int dec)
////        {
////            if (beforePrintEvent != null)
////                beforePrintEvent();

////            Console.WriteLine("Decimal: {0:G}", dec);
////        }

////        public void PrintMoney(int money)
////        {
////            if (beforePrintEvent != null)
////                beforePrintEvent();

////            Console.WriteLine("Money: {0:C}", money);
////        }

////        public void PrintTemperature(int num)
////        {
////            if (beforePrintEvent != null)
////                beforePrintEvent();

////            Console.WriteLine("Temperature: {0,4:N1} F", num);
////        }

////        public void PrintHexadecimal(int dec)
////        {
////            if (beforePrintEvent != null)
////                beforePrintEvent();

////            Console.WriteLine("Hexadecimal: {0:X}", dec);
////        }
////    }

////    class Number
////    {
////        private PrintHelper _printHelper;

////        public Number(int val)
////        {
////            _value = val;

////            _printHelper = new PrintHelper();
////            //subscribe to beforePrintEvent event
////            _printHelper.beforePrintEvent += printHelper_beforePrintEvent;
////        }
////        //beforePrintevent handler
////        void printHelper_beforePrintEvent()
////        {
////            Console.WriteLine("BeforPrintEventHandler: PrintHelper is going to print a value");
////        }

////        private int _value;

////        public int Value
////        {
////            get { return _value; }
////            set { _value = value; }
////        }

////        public void PrintMoney()
////        {
////            _printHelper.PrintMoney(_value);
////        }

////        public void PrintNumber()
////        {
////            _printHelper.PrintNumber(_value);
////        }
////    }

////    class mainProgram
////    {
////        public static void Main(string[] args)
////        {
////            Number n = new Number(5);

////            n.PrintMoney();
////        }
////    }
////}



////using System;
////using System.ComponentModel;
////using Microsoft.Practices.Unity;
////using Unity;
////using Unity.Attributes;
////using Unity.Injection;

////namespace CodeTester
////{
////    public interface ICar
////    {
////        int Run();
////    }

////    public interface ICarKey
////    {

////    }

////    public class BMW : ICar
////    {
////        private int _miles = 0;

////        public int Run()
////        {
////            return ++_miles;
////        }
////    }

////    public class Ford : ICar
////    {
////        private int _miles = 0;

////        public int Run()
////        {
////            return ++_miles;
////        }
////    }

////    public class Audi : ICar
////    {
////        private int _miles = 0;

////        public int Run()
////        {
////            return ++_miles;
////        }

////    }

////    public class BMWKey : ICarKey
////    {

////    }

////    public class test
////    {
////        public test(string test)
////        {

////        }
////    }

////    public class AudiKey : ICarKey
////    {
////        public AudiKey(test test)
////        {
////        }
////    }

////    public class FordKey : ICarKey
////    {

////    }

////    public class Driver
////    {
////        private ICar _car = null;

////        public Driver(AudiKey audiKey)
////        {
////            _car = new Audi();
////        }

////        ////[InjectionMethod]
////        ////public void UseCar(ICar car)
////        ////{
////        ////    _car = car;
////        ////}

////        public void RunCar()
////        {
////            Console.WriteLine("Running {0} - {1} mile ", _car.GetType().Name, _car.Run());
////        }
////    }

////    class Test
////    {
////        static IUnityContainer container = new UnityContainer();

////        static void test()
////        {
////            ////container.RegisterType<ICarKey, AudiKey>();
////            ////container.RegisterType<ICar, BMW>();

////            ////container.RegisterType<Driver>(new InjectionConstructor(container.Resolve<ICarKey>()));
////        }

////        public static void Main(string[] args)
////        {
////            test();

////            ////AudiKey j = container.Resolve<AudiKey>();
////            Driver drv1 = container.Resolve<Driver>();

////            ////Driver drv = container.Resolve<Driver>("LuxuryCarDriver");

////            drv1.RunCar();

////            ////drv.RunCar();
////        }
////    }
////}
