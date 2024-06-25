using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp06_19_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if문 

            //Console.Write("영문 대문자 또는 소문자 하나를 입력하세요. : ");
            //char input = Convert.ToChar(Console.ReadLine());
            //if (input >= 'A' && input <= 'Z')
            //{
            //    Console.WriteLine($"{input}는 대문자입니다.");
            //}
            //else if (input >= 'a' && input <= 'z')
            //{
            //    Console.WriteLine($"{input}는 소문자입니다.");
            //}
            //else
            //{
            //    Console.WriteLine("영문이 아닙니다..");
            //}



            //Console.Write("문자를 입력하세요. (y/n/c) : ");
            //char input = Convert.ToChar(Console.ReadLine());
            //if (input == 'y') 
            //    Console.WriteLine("Yes");
            //else
            //{
            //    if (input == 'n')
            //        Console.WriteLine("No");
            //    else
            //        Console.WriteLine("Cancel");
            //}

            /*  tryparse
            string strA = "10";
            string strB = "12.345";
            string strC = null;

            int i;
            Int32.TryParse(strA, out i); Console.WriteLine("{0}", i);   // true (10)
            Int32.TryParse(strB, out i); Console.WriteLine("{0}", i);   // false (0)
            Int32.TryParse(strC, out i); Console.WriteLine("{0}", i);   // false (0)
            */

            //int score = 0;
            //string grade = "";
            //Console.Write("점수 : "); Int32.TryParse(Console.ReadLine(), out score);
            //if (score >= 90)
            //    grade = "금메달";
            //else
            //{
            //    if (score >= 80)
            //        grade = "은메달";
            //    else
            //    {
            //        if (score >= 70)
            //            grade = "동메달";
            //        else
            //            grade = "메달 X";
            //    }
            //}
            //Console.WriteLine($"{grade}을 수상했습니다.");



            //Console.Write("정수 입력 : _\b");
            //int a = Int32.Parse(Console.ReadLine());

            //if (a % 2 == 0)
            //{
            //    Console.WriteLine("짝수");
            //}

            //if (a % 2 != 0)
            //{
            //    Console.WriteLine("홀수");
            //}
            //else
            //{
            //    Console.WriteLine("짝수");
            //}

            //if (a % 3 == 0)
            //{
            //    Console.WriteLine("3의 배수");
            //}
            //else if (a % 5 == 0)
            //{
            //    Console.WriteLine("5의 배수");
            //}
            //else if (a % 7 == 0)
            //{
            //    Console.WriteLine("7의 배수");
            //}
            //else
            //{
            //    Console.WriteLine("3, 5, 7의 배수가 아닌 수");
            //}



            #endregion
            #region switch문

            //Console.WriteLine("정수를 입력하세요.");
            //int answer = Int32.Parse(Console.ReadLine());

            //switch (answer)
            //{
            //    case 0:
            //        Console.WriteLine("0을 선택");
            //        break;
            //    case 1:
            //        Console.WriteLine("1을 선택");
            //        break;
            //    case 2:
            //        Console.WriteLine("2를 선택");
            //        break;
            //    case 3:
            //        Console.WriteLine("3을 선택");
            //        break;
            //    default:
            //        Console.WriteLine("저런");
            //        break;
            //}



            //char ch;
            //Console.WriteLine("아침은 g 입력, 점심은 h 입력, 저녁은 e 입력");
            //ch = Convert.ToChar(Console.ReadLine());

            //switch (ch) //조건 간단, 나열할게 많으면 switch       //조건 복잡하면 if, 둘다 간단하면 () ? x:y
            //{
            //    case 'g':
            //    case 'G':
            //        Console.WriteLine("아침");
            //        break;
            //    case 'h':
            //    case 'H':
            //        Console.WriteLine("점심");
            //        break;
            //    case 'e':
            //    case 'E':
            //        Console.WriteLine("저녁");
            //        break;

            //}


            //Console.WriteLine("오늘 날씨는 어떤가요? (맑음, 흐림, 비, 눈, 등등)");
            //string weather = Console.ReadLine();

            //switch (weather)
            //{
            //    case "맑음":
            //        Console.WriteLine("오늘 날씨는 맑군요.");
            //        break;
            //    case "흐림":
            //        Console.WriteLine("오늘 날씨는 흐리군요.");
            //        break;
            //    case "비":
            //        Console.WriteLine("오늘 날씨는 비가 오는군요.");
            //        break;
            //    case "눈":
            //        Console.WriteLine("오늘 날씨는 눈이 오는군요.");
            //        break;
            //    default:
            //        Console.WriteLine("날씨가 좀 이상한가 보네요.");
            //        break;
            //}



            #endregion
            #region for문

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("안녕");
            //}

            //int num = 100;
            //int total = 0;
            //for (int i = 0; i < 100; i++)
            //{
            //    num--;
            //    total += i + 1;
            //}
            //Console.WriteLine(num);
            //Console.WriteLine(total);


            //Write("구구단 중 몇단을 출력 할까요? : ");
            //int dan = int.Parse(Console.ReadLine());
            //for (int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine($"{dan}×{i} = {dan*i}");
            //}
            //Write("\n");
            //for (int i = 9; i > 0; i--)
            //{
            //    Console.WriteLine($"{dan}×{i} = {dan * i}");
            //}


            //int sum = 0;
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine($"1부터 100까지 짝수의 합 : {sum}");


            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.Write($"{i}\t");
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine();
            //    }
            //}
            //Console.WriteLine();
            //int sum1 = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    sum1 += i;
            //}
            //Console.WriteLine($"1부터 100까지의 합 : {sum1}");
            //int sum2 = 0;
            //for (int i = 1; i < 100; ++i)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum2 += i;
            //    }
            //}
            //Console.WriteLine($"1부터 100까지 짝수의 합 : {sum2}");





            #endregion

            #region 테스트

            //// 1.
            //Console.WriteLine("사각형의 너비를 입력하세요.");
            //string width = Console.ReadLine();
            //Console.WriteLine("사각형의 높이를 입력하세요.");
            //string height = Console.ReadLine();

            //int width_int = int.Parse(width);
            //int height_int = int.Parse(height);
            //int area_int = width_int * height_int;
            //Console.WriteLine($"사각형의 넓이는 : {area_int}");

            //// 2.
            //int a = 7.3;
            //float b = 3.14;
            //double c = a * b;
            //char d = "abc";
            //string e = '한';



            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("＊");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 5; i > 0; i--)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("＊");
            //    }
            //    Console.WriteLine();
            //}






            #endregion

        }
    }
}
