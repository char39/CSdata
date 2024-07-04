using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp07_04NETCORE
{
    internal class MainApp3
    {
        static void DoSomeThing(int arg)
        {
            if (arg < 10)
                Console.WriteLine($"{arg}");
            else throw new Exception("arg가 10보다 큽니다.");
        }
        static void Main(string[] args)
        {
            try
            {
                for (int i = 1; i <= 15; i++)
                    DoSomeThing(i);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
