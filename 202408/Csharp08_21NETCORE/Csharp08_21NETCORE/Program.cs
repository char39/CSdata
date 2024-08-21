using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Csharp08_21NETCORE
{
    class A
    {
        public A() => Console.WriteLine("A");
        public void F() => Console.WriteLine("A.F");
        ~A() => Console.WriteLine("A.Destructor");
    }

    internal class Program
    {
        static async Task Main(string[] args)
        {
            A a = new A();
            a.F();
            for (int i = 0; i < 1000; i++)
            {
                await DelayExample();
            }
        }

        public static async Task DelayExample()
        {
            Console.Write("Waiting for 2 seconds...   ");
            await Task.Delay(2000); // 2초 지연
            Console.WriteLine("2 seconds have passed.");
        }
    }

}
