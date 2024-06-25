using static System.Console;
/*
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/

namespace TestPrj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("이름 : "+"주현영\n");
            WriteLine("나이 : " + 32);
            WriteLine("키 : " + 167 + "cm");
            WriteLine("직업 : "+"영화배우 및 개그우먼");

            Write("이름 : ");WriteLine("주현영");
            WriteLine($"나이 : {32}");
            WriteLine($"키 : {167}cm");
            Write("직업 : "); WriteLine("영화배우 및 개그우먼");
        }
    }
}
