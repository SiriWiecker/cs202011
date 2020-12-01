using System;
using System.Threading;
using System.Threading.Tasks;

namespace StopWatch__async_
{
    class Program
    {
        static async Task Main(string[] args)
        {

            System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
            s.Start();
            Console.WriteLine("Start");

            Task t1 = Task.Run(() =>
            {
                Console.WriteLine("Sleep 1");
                Thread.Sleep(500);
            });

            Task t2 = Task.Run(() =>
            {
                Console.WriteLine("Sleep 2");
                Thread.Sleep(500);
            });

            Task t3 = Task.Run(() =>
            {
                Console.WriteLine("Sleep 3");
                Thread.Sleep(500);
            });

            await t1;
            await t2;
            await t3;

            // eller
            // await Task.WhenAll(t1, t2, t3);

            Console.WriteLine("Slut");
            s.Stop();
            Console.WriteLine($"Tid: {s.ElapsedMilliseconds}");

            Console.WriteLine("Tryk en tast for at afslutte");
            Console.ReadKey();
        }
    }
}