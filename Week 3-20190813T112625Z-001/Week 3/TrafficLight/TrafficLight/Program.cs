using System;

namespace three
{
    public delegate void TrafficDelegate();
    class TrafficSignal
    {
        TrafficDelegate del;
        static void Yellow()
        {
            Console.WriteLine("Wait");
        }

        static void Green()
        {
            Console.WriteLine("Go");
        }

        static void Red()
        {
            Console.WriteLine("Stop");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Changing to yellow");
            TrafficSignal signal = new TrafficSignal();
            signal.del += Yellow;

            signal.del();
            signal.del -= Yellow;

            Console.WriteLine("Changed to yellow");

            Console.WriteLine("Changing to green");
            signal.del += Green;
            signal.del();
            signal.del -= Green;
            Console.WriteLine("Changed to green");
            Console.WriteLine("Changing to red");
            signal.del += Red;
            signal.del();
            signal.del -= Red;
            Console.WriteLine("Changed to red");
            Console.Read();
        }
    }
}