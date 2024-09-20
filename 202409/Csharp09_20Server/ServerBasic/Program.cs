using System;
using System.Threading;

namespace ServerBasic
{
    internal class Program
    {
        static void MainThread()
        {
            while (true)
            {
                Console.WriteLine("ServerBasic.Program.MainThread()");
                Thread.Sleep(100);
            }
        }

        static void Main(string[] args)
        {
            Thread thread = new(MainThread);
            thread.IsBackground = true;
            thread.Start();     // Start는 새로운 스레드를 만들어서 MainThread()를 실행
            Console.WriteLine("Waiting for MainThread to finish");
            thread.Join();      // Join은 MainThread()가 끝날 때까지 기다림
            Console.WriteLine("Hello, Server Basic!");
        }
    }
}
