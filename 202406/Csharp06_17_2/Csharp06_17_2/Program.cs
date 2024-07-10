using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp06_17_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("본인 인적사항과 성적을 입력하세요.");
            Console.Write("이름 : ");     string name = Console.ReadLine();
            Console.Write("학년(숫자만) : ");    int grade = int.Parse(Console.ReadLine());
            Console.Write("학과 : ");     string sub = Console.ReadLine();
            Console.Write("C언어 성적(숫자만) : "); float Grade_C = float.Parse(Console.ReadLine());
            Console.Write("C++ 성적(숫자만) : "); float Grade_Cplus = float.Parse(Console.ReadLine());
            Console.Write("C# 성적(숫자만) : "); float Grade_Csharp = float.Parse(Console.ReadLine());

            float sum = Grade_C + Grade_Cplus + Grade_Csharp;
            float average = sum / 3;
            double aver = Math.Round(average, 2);

            Console.Write($"이름 : {name}\n학년 : {grade}학년\n학과 : {sub}\n합계 : {sum}\n평균 : {aver}\n\n");

        }
    }
}
