using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading.Channels;

namespace Csharp07_02NETCORE
{
    #region P316
    //internal class EnvironmentExit
    //{
    //    static void Main()
    //    {
    //        Console.WriteLine("출력됩니다.");
    //        Environment.Exit(0);
    //        Console.WriteLine("출력될까요?");
    //    }
    //}
    #endregion
    #region P318 exe파일 실행하기

    //class ProcessStartDemo
    //{
    //    static void Main()
    //    {
    //        Process.Start("Notepad.exe");
    //        Process.Start("Explorer.exe", "http://dotnetkorea.com");
    //    }
    //}

    #endregion
    #region P320 로또번호 생성기

    class RandomDemo
    {
        static void Main()
        {
            Console.Write("이번 주의 로또번호 : ");
            Random ran = new Random();
            int[] arr = new int[6];
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                temp = ran.Next(1, 46);
                bool flag = false;
                if (i > 0 && i < 6)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        if (arr[j] == temp)
                        {
                            flag = true;
                        }
                    }
                }
                if (flag)
                    --i;
                else
                    arr[i] = temp;
            }
            for (int i = 0;i < arr.Length; i++)
                Console.WriteLine($"{arr[i]}, ");
            Console.WriteLine();
        }
    }

    #endregion
}
