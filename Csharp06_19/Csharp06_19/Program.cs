using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Xml.Schema;

namespace Csharp06_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 2진수 표현 양수 음수 계산원리 [★★★★★개인적으로 따로 연습하기★★★★★]

            //byte a = 255;
            //sbyte b = 127;
            //Console.WriteLine($"{a}\n{b}");
            //b=(sbyte)a;
            //Console.WriteLine($"{a}\n{b}");


            //  2진 -16~15 표현식

            /*
            short i;
            string s;
            for (i = -16; i <= 15; i++)
            {
                s = Convert.ToString(i, 2).PadLeft(16, '0');

                Console.WriteLine($"{s} : {i}");

                if (i == 127)
                {
                    break;
                }
            }
            */


            //★★★★  2진수에서 3, -3끼리 더하면 0이 되어야 하기에
            //          00000011 = 3 에서 반전하면  11111100 = -4가 된다.
            //          여기서 1을 더해주면         11111101 = -3이 된다.
            //          
            //          11111101 = -3 에서 반전하면 00000010 = 2가 된다.
            //          여기서도 1을 더해주면       00000011 = 3이 된다.
            //
            //       ★ 결론. 2진수에서 0, 1을 서로 반전하고 1을 더해주면 된다.

            #endregion
            #region 논리연산자 !, 전부활용

            //Console.WriteLine($"!true = {!true}");
            //Console.WriteLine($"!false = {!false}");

            //var i = 3;
            //var j = 5;
            //var r = false;
            //r = (i == 3) && (j != 3); //r = true && true => true
            //WriteLine(r);
            //r = (i != 3) || (j == 3); //r = false || false => false


            #endregion
            #region 비트 연산자

            //byte x = 0b1010; //10
            //byte y = 0b1100; //12
            //Console.WriteLine($"  {Convert.ToString(x, 2)} -> {x}"); // x를 2진->10진
            //Console.WriteLine($"  {Convert.ToString(y, 2)} -> {y}"); // y를 2진->10진
            //Console.WriteLine($"& {Convert.ToString(x & y, 2)} -> {x & y, 2}"); // x & y를 2진으로->10진으로 2칸 잡고 표현
            //Console.WriteLine($"| {Convert.ToString(x | y, 2)} -> {x | y,2}");
            //Console.WriteLine($"^ {Convert.ToString(x ^ y, 2).PadLeft(4, '0')} -> {x ^ y,2}");

            // 1010 > 10        1번째 수
            // 1100 > 12        2번째 수

            // 1000 > 8     &   AND    10이랑 12 이진수 위아래 1과 0이 같은지 다른지로 논리 계산.
            // 1110 > 14    |   OR
            // 0110 > 6     ^   XOR

            //byte x2 = 0b_0000_1010;
            //Console.WriteLine($"  {Convert.ToString(x2, 2).PadLeft(8, '0')} -> {x2,0}"); // 바로옆 ,0은 띄어쓰기
            //Console.WriteLine($"~ {Convert.ToString((byte)~x2, 2).PadLeft(8, '0')} -> {~x2}"); // ~은 비트값 반전


            //var x = Convert.ToInt32("1010", 2);     Console.Write($" x = {Convert.ToString(x, 2)}\n");
            //var y = Convert.ToInt32("0110", 2);     Console.Write($" y = {Convert.ToString(y, 2).PadLeft(4,'0')}\n");
            //var and = x & y;
            //Console.WriteLine($"{and} : {Convert.ToString(and, 2).PadLeft(4,'0')}");
            //var or = x | y;
            //Console.WriteLine($"{or} : {Convert.ToString(or, 2).PadLeft(4,'0')}");
            //var xor = x ^ y;
            //Console.WriteLine($"{xor} : {Convert.ToString(xor, 2).PadLeft(4, '0')}");
            //var not = ~x;
            //Console.WriteLine($"{not} : {Convert.ToString(not, 2)}");


            #endregion
            #region 비트 연산자 [시프트 연산자]


            //sbyte number = 32;
            //sbyte numSqrtLeft = 2;
            //sbyte numSqrtRight = 2;

            //Console.WriteLine($"{Convert.ToString(number, 2).PadLeft(16, '0')} = {number} 기본값");
            //Console.WriteLine($"{Convert.ToString(number << numSqrtLeft, 2).PadLeft(16, '0')} = {number << numSqrtLeft} << {numSqrtLeft}"); //시프트 연산자는 음수를 다루지 않음.
            //Console.WriteLine($"{Convert.ToString(number >> numSqrtRight, 2).PadLeft(16, '0')} = {number >> numSqrtRight} >> {numSqrtRight}");

            //byte num1 = 4;  // 0000_0100
            //num1 &= 5;      // 5(0101) AND 4(0100) => 4(0100)
            //Console.WriteLine(num1);
            //byte num2 = 4;  // 0000_0100
            //num2 |= 1;      // 1(0001) AND 4(0100) => 5(0101)
            //Console.WriteLine(num2);
            //byte num3 = 4;  // 0000_0100
            //num3 ^= 2;      // 2(0010) AND 4(0100) => 6(0110)
            //Console.WriteLine(num3);
            //byte num4 = 4;  // 0000_0100
            //num4 <<= 1;     // 4(0100) << 1 => 8(1000)
            //Console.WriteLine(num4);
            //byte num5 = 4;  // 0000_0100
            //num5 >>= 1;     // 4(0100) >> 1 => 2(0010)
            //Console.WriteLine(num5);


            #endregion
            #region 기타 연산자[조건 연산자, 등등]

            //int number = 33;

            ////number가 짝수이면 result 변수에 "짝수"를 담고, 그렇지 않으면 "홀수" 담기
            //string result = (number % 2 == 0) ? "짝수" : "홀수"; // ?는 if, else의 축약형
            //Console.WriteLine($"{number}은(는) {result}입니다.");

            //const int max_size = 20;
            //int pageSize = 0;

            //pageSize = 10;
            //pageSize = (pageSize > max_size) ? max_size : pageSize; // () ? x : y 는     if() {x} else {y}와 같음
            //Console.WriteLine(pageSize);

            //pageSize = 50;
            //pageSize = (pageSize > max_size) ? max_size : pageSize; // 비교적 간단한 조건일때 사용하는게 좋으며, 복잡한 조건은 비추. 가독성 별로
            //Console.WriteLine(pageSize);

            //var num = -21;
            //var abs = (num < 0) ? num*(-1) : num;

            //Console.WriteLine($"{num}의 절대값 = {abs}");

            //Console.WriteLine("sizeof(데이터 형식)");
            //Console.WriteLine($"  char 형식 : {sizeof(char)}byte");
            //Console.WriteLine($" short 형식 : {sizeof(short)}byte");
            //Console.WriteLine($"   int 형식 : {sizeof(int)}byte");
            //Console.WriteLine($"  long 형식 : {sizeof(long)}byte");
            //Console.WriteLine($" float 형식 : {sizeof(float)}byte");
            //Console.WriteLine($"double 형식 : {sizeof(double)}byte");



            #endregion
            #region 제어문 [if/else문]

            ////순차문
            //int kor = 100;
            //int eng = 90;
            //int math = 75;
            //int tot = 0;
            //double avg = 0.0;

            //tot = kor + eng + math;
            //avg = tot / 3.0;
            //Console.WriteLine($"총점 : {tot}");
            //Console.WriteLine($"평균 : {avg:f1}"); //f1은 소수점 1자리

            //if (avg >= 90)
            //    Console.WriteLine("90 ~   ");
            //else if (avg >= 80)
            //    Console.WriteLine("80 ~ 90");
            //else if (avg >= 70)
            //    Console.WriteLine("70 ~ 80");
            //else if (avg >= 60)
            //    Console.WriteLine("60 ~ 70");
            //else if (avg >= 50)
            //    Console.WriteLine("50 ~ 60");
            //else
            //    Console.WriteLine("   ~ 50");




            //double Kor, Eng, Math, Sum, Aver;

            //Console.WriteLine("국어, 영어, 수학 점수를 입력하세요.");

            //Console.Write("국어 점수 입력 : "); Kor = Convert.ToDouble(Console.ReadLine());
            //Console.Write("영어 점수 입력 : "); Eng = Convert.ToDouble(Console.ReadLine());
            //Console.Write("수학 점수 입력 : "); Math = Convert.ToDouble(Console.ReadLine());

            //Sum = Kor + Eng + Math;
            //Aver = Sum / 3;
            //Console.Write($"총점 : {Sum,1}, 평균 : {Aver,1}\n");

            //if (Aver >= 90)
            //    Console.WriteLine("A학점");
            //else if (Aver >= 80)
            //    Console.WriteLine("B학점");
            //else if (Aver >= 70)
            //    Console.WriteLine("C학점");
            //else if (Aver >= 60)
            //    Console.WriteLine("D학점");
            //else
            //    Console.WriteLine("F학점(재수강)");



            //bool bln = false;
            //if (!bln) //if문 () 안에는 true값(1)이 되어야 실행된다.
            //{
            //    Console.WriteLine("bln : false -> ! -> true");
            //}



            //int number = 1234;
            //if (number == 1234 && number >= 1000)
            //{
            //    Console.WriteLine("둘다 맞아야 참");
            //}
            //if (number == 1234 || number <= 1000)
            //{
            //    Console.WriteLine("하나라도 맞으면 참");
            //}


            //int num;
            //Console.Write("정수 입력 : ");     num = int.Parse(Console.ReadLine());
            //if (num >= 0)
            //    Console.WriteLine($"양수 출력 : {num}");
            //else
            //    Console.WriteLine($"음수 출력 : {num}");

            //string s = (num >= 0) ? $"양수 : {num}" : $"음수 : {num}";
            //Console.WriteLine(s);


            //int num1, num2, num3;
            //string str1, str2, str3;
            //Console.Write("정수 입력 : "); num1 = Convert.ToInt32(Console.ReadLine());
            //str1 = (num1 % 2 == 0) ? $"짝수 출력 : {num1}" : $"홀수 출력 : {num1}";
            //Console.WriteLine(str1);

            //Console.Write("정수 입력 : "); num2 = Convert.ToInt32(Console.ReadLine());
            //str2 = (num2 % 2 == 0) ? $"짝수 출력 : {num2}" : $"홀수 출력 : {num2}";
            //Console.WriteLine(str2);

            //Console.Write("정수 입력 : "); num3 = Convert.ToInt32(Console.ReadLine());
            //str3 = (num3 < 0) ? $"절대값 : {-num3}" : $"절대값 : {num3}";
            //Console.WriteLine(str3);

            



            #endregion


        }
    }
}
