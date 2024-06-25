using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Csharp06_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for문은 배열에 최적화된 반복문
            #region for문 구구단

            //for (int i = 2; i < 10; i++)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        Console.WriteLine($"{i}×{j} = {i * j}");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 9; i > 1; i--)
            //{
            //    for (int j = 9; j >= 1; j--)
            //    {
            //        Console.WriteLine($"{i}×{j} = {i * j}");
            //    }
            //    Console.WriteLine();
            //}

            #endregion
            #region 2, 7을 입력 하면 2단에서 7단이 출력

            //int numb1, numb2;
            //Console.Write("몇단부터 몇단까지 구구단을 출력할까요?\n");
            //numb1 = Int32.Parse(Console.ReadLine());
            //numb2 = Int32.Parse(Console.ReadLine());
            //for (int i = numb1; i <= numb2; i++)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        Console.WriteLine($"{i}×{j} = {i*j}");
            //    }
            //    Console.WriteLine();
            //}

            #endregion
            #region 무한루프

            //for (; ; )
            //{
            //    Console.WriteLine("무한루프");
            //}

            #endregion
            #region 팩토리얼

            //int fact;
            //for (int i = 1; i <= 4; i++)
            //{
            //    Console.Write($"{i}! = ");
            //    fact = 1;
            //    for (int j = 1; j <= i; j++)
            //    {
            //        fact = fact * j;
            //    }
            //    Console.WriteLine($"{fact,2}");
            //}

            #endregion
            #region 구구단 가로 출력

            //for (int i = 2; i <= 9; i++)
            //{
            //    Console.Write($"{i,5}단  ");
            //}
            //Console.WriteLine();

            //for (int i = 1; i <= 9; i++)
            //{
            //    for(int j = 2; j <= 9; j++)
            //    {
            //        Console.Write($"{j}×{i}={j * i,2}  ");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region while문

            //int count = 0;
            //while (count < 3)
            //{
            //    Console.WriteLine("Hello");
            //    count++;
            //}


            //int count = 0;
            //while (count++ < 3)
            //{
            //    Console.WriteLine($"카운트 : {count}");
            //}

            #endregion
            #region while문 구구단

            //int dan = 2;
            //int i = 1;

            //while (dan < 10)
            //{
            //    while (i < 10)
            //    {
            //        Console.WriteLine($"{dan}×{i}={dan * i,2}");
            //        i++;
            //    }
            //    dan++;
            //    i = 1;
            //    Console.WriteLine();
            //}


            //int i = 2, j = 1;
            //while (i < 10)
            //{
            //    Console.Write($"{i,5}단  ");
            //    i++;
            //}
            //Console.WriteLine();
            //i = 1;
            //j = 2;
            //while (i < 10)
            //{
            //    while (j < 10)
            //    {
            //        Console.Write($"{j}×{i}={i*j,2}  ");
            //        j++;
            //    }
            //    j = 2; i++;
            //    Console.WriteLine();
            //}






            #endregion
            #region while문 숫자합, 피보나치

            //const int N = 100;
            //int sum = 0;
            //int i = 1;

            //while (i <= N)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine($"1부터 {N}까지의 합 : {sum}");


            //int sum = 0, i = 1;

            //while (i <= 100)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum += i;
            //    }
            //    i++;
            //}
            //Console.WriteLine($"1부터 100까지 짝수의 합 : {sum}");


            //int first = 0;
            //int second = 1;

            //while (second <= 20) 
            //{
            //    Console.WriteLine(second);
            //    int temp = first + second;
            //    first = second;
            //    second = temp;
            //}


            #endregion

            #region do while문

            //int count = 0;
            //do
            //{
            //    Console.WriteLine("안녕");
            //    count++;
            //}while (count < 3);


            //int sum = 0;
            //int i = 1;
            //do
            //{
            //    if (i % 3 == 0 && i % 4 == 0)
            //    {
            //        sum += i;
            //        //Console.WriteLine(i);
            //    }
            //    i++;
            //} while (i <= 100);
            //Console.WriteLine(sum);


            #endregion
            #region foreach문, 1차원 배열, 배열 초기화 for문으로

            // 자료형 다음에 [] 배열선언
            // C, C++은 배열 선언을 char str[]; 와 같이 함.
            // Java, C#은 선언을 string[] str; 와 같이 함.
            // 배열은 참조형 데이터이다. 주소 위치 정보만 갖고있음.

            //string[] names = new string[3]; // 3개 동적 할당. 0,1,2 총 3개. 주로 아래보다 이걸 실무에서 사용.
            //names[0] = "C#";
            //names[1] = "ASP.NET";
            //names[2] = "유니티 엔진";
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //string[] wri = { "C#", "ASP.NET", "유니티 엔진" }; // 3개 동적 할당은 같으나 몇개인지 개발자는 바로 알기 힘들다.
            //Console.WriteLine("foreach 출력");
            //foreach (string name in wri)
            //{
            //    Console.WriteLine(name);
            //}


            //string str = "안녕 ASDF asdf 22222222";
            //foreach (char c in str) 
            //{
            //    Console.Write($"{c}  ");
            //}
            //Console.WriteLine();

            //var str = "안녕 ASDF asdf 22222222";
            //foreach (var c in str)
            //{
            //    Console.Write($"{c}  ");
            //}
            //Console.WriteLine();


            //int[] arr = new int[10]; //array 배열이란 뜻.

            //for (int i = 0; i < arr.Length; i++) //배열값을 수정할때
            //{
            //    arr[i] = (i + 1) * 10;
            //}
            //foreach (int i in arr)              //배열을 출력할때
            //{
            //    Console.WriteLine(i);
            //}


            #endregion

            // 1차원 배열을 100으로 선언하고
            // 배열 숫자를 1부터 100까지 채운다
            // 배열안에 값을 3의 배수와 7의 배수만 출력
            #region 3,7 배수 출력
            //int[] number = new int[100];
            //for (int i = 0; i < number.Length; i++)
            //{
            //    number[i] = i + 1;
            //}
            //foreach (int i in number)
            //{
            //    if (number[i] % 3 == 0 && number[i] % 7 == 0)
            //        Console.WriteLine($"{number[i]} : 3, 7의 공배수");
            //    else if (number[i] % 3 == 0)
            //        Console.WriteLine($"{number[i]} : 3의 배수");
            //    else if (number[i] % 7 == 0)
            //        Console.WriteLine($"{number[i]} : 7의 배수");
            //}
            #endregion

            #region break, continue 반복문 제어

            //int sum = 0;
            //while (true)
            //{
            //    sum++;
            //    if (sum >= 500)
            //    {
            //        break;  // 반복문을 빠져나갈때 break;로 나감
            //    }
            //}
            //Console.WriteLine(sum);


            //int goal = 22;
            //int sum = 0;

            //int i = 1;
            //while (i <= 10)
            //{
            //    sum += i;
            //    if (sum >= goal)
            //    {
            //        break;
            //    }
            //    i++;
            //}
            //Console.WriteLine($"1부터 {i}까지의 합은 {sum}이고, 목표치 {goal}이상을 달성.");


            //for (int i = 1; i <= 5; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}


            //int sum = 0;
            //for(int i =0;i<=100;i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        continue;
            //    }
            //    sum += i;
            //}
            //Console.WriteLine($"Sum : {sum}");



            #endregion

            // 구구단을 1단부터 9단까지 출력하세요.
            // 짝수의 단만 출력하고
            // 짝수의 단은 아래와 같이 출력 되어야 한다.
            // 2x1=2    4x1=4
            // 2x2=4    4x2=8
            //          4x3=12
            //          
            #region
            //Console.WriteLine("구구단 중 짝수의 단만 출력합니다.");


            //for (int dan = 1; dan < 10; dan++)
            //{
            //    if (dan % 2 != 0)
            //        continue; //홀수는 아래 구문 패스하고 다음 반복문 시작
            //    for (int num = 1; num <10; num++)
            //    {
            //        if (dan < num) break; //이건 반복문 자체를 탈출
            //        Console.WriteLine($"{dan}×{num}={dan * num,2}");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            //쪽지시험 0620_1 1번
            #region 내 풀이
            //int money = 3500;
            //int cr = 500, sh = 700, co = 400;

            //Console.WriteLine($"현재 당신이 소유하고 있는 금액 : {money}");

            //for (int a = 1; a <= (money / cr); a++)
            //{
            //    for (int b = 1; b <= (money / sh); b++)
            //    {
            //        for (int c = 1; c <= (money / co); c++)
            //        {
            //            if (a * cr + b * sh + c * co == money)
            //                Console.WriteLine($"크림빵 {a}개, 새우깡 {b}개, 콜라 {c}개");
            //        }
            //    }
            //}
            #endregion
            #region 의도된 답 //상수, 입력 추가됨

            //int money = 0;
            //const int CR = 500;
            //const int SH = 700;
            //const int CO = 400;
            //money = Int32.Parse(Console.ReadLine());

            //for (int a = 1; a <= (money / CR); a++)
            //{
            //    for (int b = 1; b <= (money / SH); b++)
            //    {
            //        for (int c = 1; c <= (money / CO); c++)
            //        {
            //            if (a * CR + b * SH + c * CO == money)
            //                Console.WriteLine($"크림빵 {a}개, 새우깡 {b}개, 콜라 {c}개");
            //        }
            //    }
            //}

            #endregion
            //쪽지시험 0620_1 2번
            #region 내 풀이

            //int[] number = new int[10];
            //for (int i = 0; i < 10; i++)
            //    number[i] = Int32.Parse(Console.ReadLine());
            //Console.Write("홀수 출력 : ");
            //for (int i = 0; i < 10; i++)
            //{
            //    if (number[i] % 2 != 0)
            //        Console.Write($"{number[i]} ");
            //}
            //Console.Write("\n짝수 출력 : ");
            //for (int i = 0; i < 10; i++)
            //{
            //    if (number[i] % 2 == 0)
            //        Console.Write($"{number[i]} ");
            //}
            #endregion
            //쪽지시험 0620_1 3번
            #region 내 풀이[2진수 그대로 출력]

            //Console.Write("10진수 정수를 입력하세요 : ");
            //int input = Int32.Parse(Console.ReadLine());
            //string output = Convert.ToString(input, 2).PadLeft(8, '0');
            //Console.Write($"10진수 정수를 2진수로 출력 : {output}\n");

            //  테스트중
            /*
            Console.Write("10진수 정수를 입력하세요 : ");
            int input = Int32.Parse(Console.ReadLine());
            string output = (input < 256) ?
                Convert.ToString(input, 2).PadLeft(8, '0') :
                Convert.ToString(input, 2).PadLeft(16, '0');
            int temp = 1;
            foreach (char output2 in output)
            {
                if (temp % 8 == 0)
                    Console.Write($"{output2}");
                temp++;
            }
            Console.Write($"10진수 정수를 2진수로 출력 : {output}\n");
            */
            #endregion
            #region 의도된 답[2진수 거꾸로 출력]
            //int N;
            //string binStr;

            //N = Int32.Parse(Console.ReadLine());
            //binStr = Convert.ToString(N, 2);
            //for (int j = binStr.Length - 1; j >= 0; j--)
            //{
            //    Console.Write(binStr[j] + " ");
            //}
            #endregion


            #region 배열[컬렉션]

            //// 배열.
            //string[] array = { "Array", "List", "Dictionary" };
            //foreach (string item in array)
            //{
            //    Console.WriteLine(item);
            //}
            //// 리스트. 형변환이 자유롭다.
            //var list = new List<string> { "Array", "List", "Dictionary" }; // 자료형에 따라 <내부>를 int 등 바꿀수 있다.
            //foreach (string itemlist in list)
            //{
            //    Console.WriteLine(itemlist);
            //}
            //// 사전. 한 쌍의 키와 값을 갖고 있다.
            //var dictionary = new Dictionary<int, string>
            //{
            //    {0, "Array"}, {1, "List"}, {2, "Dictionary"}
            //};
            //foreach (var pair in dictionary)
            //{
            //    Console.WriteLine($"{pair.Key}, {pair.Value}");
            //}




            #endregion

            // p177~211 쪽지시험






        }
    }
}
