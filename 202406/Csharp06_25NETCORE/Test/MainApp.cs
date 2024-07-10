using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class MainApp
    {
        static decimal Sqrt(uint num)
        {
            if (num == 0) return 1;
            else return 2 * Sqrt(num - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"2의 몇승을 입력할까요?");
            uint SqNum =  UInt32.Parse(Console.ReadLine());
            
            Console.WriteLine(Sqrt(SqNum));
        }
    }
}
