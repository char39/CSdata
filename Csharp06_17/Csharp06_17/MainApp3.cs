using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Csharp06_17
{
    internal class MainApp3
    {
        public static void Main(string[] args)
        {
            #region readline, writeline 점수 평균, 합계
            //int kor, eng, math, sum;
            //WriteLine("각 국어, 영어, 수학 점수를 입력하세요.");
            //Write("국어 점수 : ");
            // kor = int.Parse(ReadLine());
            //Write("영어 점수 : ");
            // eng = int.Parse(ReadLine());
            //Write("수학 점수 : ");
            // math = int.Parse(ReadLine());
            //sum = kor + eng + math;
            //WriteLine($"\n총 점수 : {sum}");
            //WriteLine($"평균 : {(float)sum/3}");
            #endregion
            #region 사칙연산
            //Console.WriteLine("양의 정수를 입력해주세요.");
            //Console.Write("첫 번째 양수 : "); double num1 = int.Parse(Console.ReadLine());
            //Console.Write("두 번째 양수 : "); double num2 = int.Parse(Console.ReadLine());
            //Console.Write("두 양의 정수로 사칙연산을 시행합니다.\n\n");
            //double add, sub, multi, divis, divid;
            //add = num1 + num2;
            //sub = num1 - num2;
            //multi = num1 * num2;
            //divis = num1 / num2;
            //divid = num1 % num2;
            //Console.WriteLine("{0}+{1}={2}", num1, num2, add);
            //Console.WriteLine("{0}-{1}={2}", num1, num2, sub);
            //Console.WriteLine("{0}*{1}={2}", num1, num2, multi);
            //Console.WriteLine("{0}/{1}={2}", num1, num2, divis);
            //Console.WriteLine("{0}%{1}={2}", num1, num2, divid);



            #endregion
            #region
            int x = Console.Read(); //문자를 정수로 묵시적 변환
            Console.WriteLine(x);
            Console.WriteLine(Convert.ToChar(x)); //정수를 문자로 명시적 변환
            #endregion
        }
    }
}
