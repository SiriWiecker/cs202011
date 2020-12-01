using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
            s.Start();
            Console.WriteLine("Start");

            Console.WriteLine("Sleep 1");
            Thread.Sleep(500);
            Console.WriteLine("Sleep 2");
            Thread.Sleep(500);
            Console.WriteLine("Sleep 3");
            Thread.Sleep(500);

            Console.WriteLine("Slut");
            s.Stop();
            Console.WriteLine($"Tid: {s.ElapsedMilliseconds}");

            Console.WriteLine("Tryk en tast for at afslutte");
            Console.ReadKey();

        }
    }
}