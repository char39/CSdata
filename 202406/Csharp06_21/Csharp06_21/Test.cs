using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Csharp06_21
{
    internal class Test
    {
        #region 구구단 함수
        //static int Max(int x, int y)
        //{
        //    return (x > y) ? x : y;
        //}
        //static int Min(int x, int y)
        //{
        //    return (x < y) ? x : y;
        //}
        //static void gugu(int x, int y)
        //{
        //    for (int i = x; i <= y; i++)
        //    {
        //        for (int j = 1; j <= 9; j++)
        //        {
        //            Console.WriteLine($"{i}×{j}={i*j}");
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("구구단을 몇단부터 몇단까지 출력할까요?");
        //    int input1 = Int32.Parse(Console.ReadLine());
        //    int input2 = Int32.Parse(Console.ReadLine());
        //    int MaxDan = Max(input1, input2), MinDan = Min(input1, input2);
        //    gugu(MinDan, MaxDan);
        //}

        #endregion
        #region 의도된 답

        //static void PrintDan(int startDan, int endDan)
        //{
        //    for (int i = startDan; i <= endDan; i++)
        //    {
        //        for (int j = 1; j <= 9; j++)
        //        {
        //            Console.WriteLine($"{i}×{j}={i * j}");
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //public static void Main(string[] args)
        //{
        //    Console.Write("시작 단 입력 : "); int startdan = Int32.Parse(Console.ReadLine());
        //    Console.Write("종료 단 입력 : "); int enddan = Int32.Parse(Console.ReadLine());
        //    if (startdan > enddan)
        //    {
        //        int temp = startdan;
        //        startdan = enddan;
        //        enddan = temp;
        //    }
        //    PrintDan(startdan, enddan);
        //}

        #endregion


    }
}
