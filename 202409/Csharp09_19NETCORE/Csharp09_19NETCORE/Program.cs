using System;
using System.Threading;

namespace Csharp09_19NETCORE
{
/*     internal class Program
    {
        static void DoSomething()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(100);  // ms
                Console.WriteLine("DoSomething: " + i);   
            }
        }

        static void Main()
        {
            var t1 = new Thread(new ThreadStart(DoSomething));
            Console.WriteLine("Starting thread t1");
            t1.Start();
            
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(100);  // ms
                Console.WriteLine("Main: " + i);
            }

            Console.WriteLine("Main: waiting for t1 to finish");
            t1.Join();
            Console.WriteLine("Main: t1 has finished");
        }
    } */

    class SideTask
    {
        int count;
        public SideTask(int count)
        {
            this.count = count;
        }
        public void KeepAlive(CancellationToken token)
        {
            try
            {
                while (count > 0)
                {
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Cancellation requested.");
                        break;
                    }
                    Console.WriteLine($"{count--} left");
                    Thread.Sleep(10);
                }
                Console.WriteLine("Count: 0");
            }
            finally
            {
                Console.WriteLine("Clearing resource...");
            }
        }
    }

    internal class Program
    {
        static void Main()
        {
            SideTask task = new SideTask(100);
            CancellationTokenSource cts = new CancellationTokenSource();
            Thread t1 = new Thread(() => task.KeepAlive(cts.Token));
            t1.IsBackground = false;

            Console.WriteLine("Starting thread...");
            t1.Start();

            Thread.Sleep(100);

            Console.WriteLine("Requesting cancellation...");
            cts.Cancel();

            Console.WriteLine("Main: waiting for t1 to finish");
            t1.Join();
            Console.WriteLine("Main: t1 has finished");
        }
    }

}
