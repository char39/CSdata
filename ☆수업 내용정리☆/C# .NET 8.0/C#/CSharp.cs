﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///////////////////////////////////////////////////////////////////////////////
//                                                                           //
//                              ReadMe.md 필독!                               //
//                                                                           //
///////////////////////////////////////////////////////////////////////////////

/*  ★ static void Main() ★
namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
        }
    }
}
    - 프로그램의 시작점을 나타내는 메서드
    - Main() 메서드는 프로그램이 시작되면 가장 먼저 호출되는 메서드
    - Main() 메서드는 프로그램의 진입점(Entry Point)이라고도 함
    - Main() 메서드는 반드시 static으로 선언되어야 하며, 반환형은 void 또는 int만 가능
    - Main() 메서드는 매개변수를 가질 수 있으며, string[] args를 매개변수로 받음
    - Main() 메서드는 클래스 내부에 선언되어야 하며, 클래스 내에 여러 개의 Main() 메서드를 선언할 수 없음
    - Main() 메서드는 프로그램 내에 단 하나만 존재해야 함
*/

#region ★ C# 기초 ★   」(￣▽￣」)
#region 1. Console.WriteLine() [p64~67]

/*  1.1 WriteLine()의 이스케이프 시퀀스(Escape Sequence) :
        \n(줄바꿈), \t(탭), \\(역슬래시), \"(큰따옴표), \'(작은따옴표)
        \u(유니코드), \U(유니코드), \x(16진수), \a(경고음), \b(백스페이스), \r(캐리지 리턴)

    1.2 WriteLine()의 서식 지정자(Format Specifier) :
        {0}, {1}, {2}... : 인덱스 위치에 매개변수를 출력
        {0, 10} : 10자리 확보 후 정렬
        {0, -10} : 10자리 확보 후 정렬(왼쪽 정렬)

        1.2.1 서식 지정자 예시 :
            int var1 = 100, var2 = 200, var3 = 300;
            Console.WriteLine("Hello, World! + {0}", var1);
            Console.WriteLine("{0}, {1}, {2}", var1, var2, var3);
            Console.WriteLine("{0, 10}, {1, 10}, {2, 10}", var1, var2, var3);
            Console.WriteLine($"{var1}, {var2}, {var3}");

*/

#endregion
#region 2. 데이터 형식 [p81~101]

/*  2.1 숫자 데이터 형식 :
        byte(1), short(2), int(4), long(8), float(4), double(8), decimal(16)
        sbyte(1), ushort(2), uint(4), ulong(8)

        2.1.1 예시 :
            int var1 = 100;
            float var2 = 3.14f;
            decimal var3 = 3.14m;

        2.1.2 최대값, 최소값 : 
            byte(0 ~ 255), sbyte(-128 ~ 127)
            short(-32,768 ~ 32,767), ushort(0 ~ 65,535)
            int(-2,147,483,648 ~ 2,147,483,647), uint(0 ~ 4,294,967,295)
            long(-9,223,372,036,854,775,808 ~ 9,223,372,036,854,775,807)
            ulong(0 ~ 18,446,744,073,709,551,615)
            float(±1.5 x 10^-45 ~ ±3.4 x 10^38)
            double(±5.0 x 10^-324 ~ ±1.7 x 10^308)
            decimal(±1.0 x 10^-28 ~ ±7.9 x 10^28)

    2.2 문자 데이터 형식 :
        char(2), string(가변)

        2.2.1 예시 :
            char var1 = 'A';
            string var2 = "Hello, World!";

    2.3 논리 데이터 형식 :
        bool(1)

        2.3.1 예시 :
            bool var1 = true;

    2.4 객체 데이터 형식 :
        object(가변)

        2.4.1 예시 :
            object var1 = 100;                      // var1은 참조형 데이터형식으로, int형식 값의 주소를 저장
            object var2 = 3.14;                     // var2는 참조형 데이터형식으로, float형식 값의 주소를 저장
            object var3 = "Hello, World!";          // var3은 참조형 데이터형식으로, string형식 값의 주소를 저장

    2.5 변하지 않는 데이터 형식 (상수) :
        const 데이터형식 상수명 = 값;

        2.5.1 예시 :
            const int var1 = 100;                   // var1은 100으로 고정. 변경 불가
            const float var2 = 3.14f;               // var2는 3.14로 고정. 변경 불가
            const string var3 = "Hello, World!";    // var3은 "Hello, World!"로 고정. 변경 불가

*/

#endregion
#region 3. 형식 변환 [p102~111]

/*  3.1 암시적 형식 변환(Implicit Conversion) :
        작은 데이터 형식에서 큰 데이터 형식으로 변환
        byte -> short -> int -> long
        float -> double -> decimal

    3.2 명시적 형식 변환(Explicit Conversion) :
        큰 데이터 형식에서 작은 데이터 형식으로 변환
        long -> int -> short -> byte

    3.3 ★ 형식 변환 메서드 :
        Convert.ToByte(), Convert.ToInt16(), Convert.ToInt32(), Convert.ToInt64()
        Convert.ToSingle(), Convert.ToDouble(), Convert.ToDecimal(), Convert.ToString()

        3.3.1 예시 :
            int var1 = 100;
            byte var2 = Convert.ToByte(var1);       // var1을 byte로 변환
            string var3 = Convert.ToString(var1);   // var1을 string으로 변환

    3.4 ★ 형식 변환 .NET :
        byte.Parse(), short.Parse(), int.Parse(), long.Parse(), float.Parse()
        double.Parse(), decimal.Parse(), bool.Parse()

        3.4.1 예시 :
            int var1 = 100;
            byte var2 = byte.Parse(var1);        // var1을 byte로 변환
            string var3 = string.Parse(var1);    // var1을 string으로 변환

*/

#endregion
#region 4. 진수 변환 [p112~115]

/*  4.1 10진수 -> 2진수, 8진수, 16진수 변환 :
        Convert.ToString(10진수, 2)
        Convert.ToString(10진수, 8)
        Convert.ToString(10진수, 16)

        4.1.1 예시 :
            int var1 = 100;
            Console.WriteLine(Convert.ToString(var1, 2));   // 1100100
            Console.WriteLine(Convert.ToString(var1, 8));   // 144
            Console.WriteLine(Convert.ToString(var1, 16));  // 64

    4.2 2진수, 8진수, 16진수 -> 10진수 변환 :
        Convert.ToInt32(2진수, 2)
        Convert.ToInt32(8진수, 8)
        Convert.ToInt32(16진수, 16)

        4.2.1 예시 :
            string binary = "1010"; // 2진수
            string octal = "12";    // 8진수
            string hex = "A";       // 16진수

            int decimalFromBinary = Convert.ToInt32(binary, 2);
            int decimalFromOctal = Convert.ToInt32(octal, 8);
            int decimalFromHex = Convert.ToInt32(hex, 16);

            Console.WriteLine($"2진수 {binary} -> 10진수 {decimalFromBinary}"); // 2진수 1010 -> 10진수 10
            Console.WriteLine($"8진수 {octal} -> 10진수 {decimalFromOctal}");   // 8진수 12 -> 10진수 10
            Console.WriteLine($"16진수 {hex} -> 10진수 {decimalFromHex}");      // 16진수 A -> 10진수 10
    
    4.3 2진수, 8진수, 16진수 리터럴 : 
        2진수 : 0b, 8진수 : 0, 16진수 : 0x
        int var1 = 0b1100100;
        int var2 = 0144;
        int var3 = 0x64;

    4.4 언더스코어(_) :
        int var1 = 1_000_000;
        long var2 = 100_000_000_000;
            언더스코어는 숫자 사이에 위치할 수 있으며, 숫자의 시작과 끝에 위치할 수 없음.
            주로 가독성을 높이기 위해 사용하며, 컴파일 시 무시됨.

*/

#endregion
#region 5. 연산자 (대입, 증감, 산술, 관계) [p121~136]

/*  5.1 연산자 개요 :
        단항 연산자, 이항 연산자, 삼항 연산자로 구분.
        대입 연산자, 증감 연산자, 산술 연산자, 관계 연산자, 논리 연산자, 비트 연산자
        조건 연산자, 시프트 연산자, 타입 변환 연산자, is 연산자, as 연산자 등

    5.2 대입 연산자 :
        =, +=, -=, *=, /=, %=

        5.2.1 예시 :
            int var1 = 100;
            var1 += 100;    // var1 = var1 + 100;
            var1 -= 100;    // var1 = var1 - 100;
            var1 *= 100;    // var1 = var1 * 100;
            var1 /= 100;    // var1 = var1 / 100;
            var1 %= 100;    // var1 = var1 % 100;
    
    5.3 증감 연산자 :
        ++, --

        5.3.1 예시 :
            int var1 = 100;
            var1++;     // var1 = var1 + 1;
            var1--;     // var1 = var1 - 1;
        
        5.3.2 전위 연산자와 후위 연산자 :
            int var1 = 100;
            int var2 = 200;
            Console.WriteLine(++var1);   // 전위 연산자 : 1 증가 후 var1 출력   // 101
            Console.WriteLine(var2++);   // 후위 연산자 : var1 출력 후 1 증가   // 200
        
    5.4 산술 연산자 :
        +, -, *, /, %

        5.4.1 설명 : 
            + : 덧셈
            - : 뺄셈
            * : 곱셈
            / : 나눗셈
            % : 나머지

        5.4.2 예시 :
            int var1 = 100, var2 = 200;
            Console.WriteLine(var1 + var2);     // 300
            Console.WriteLine(var1 - var2);     // -100
            Console.WriteLine(var1 * var2);     // 20000
            Console.WriteLine(var1 / var2);     // 0  (int형이므로 소수점 이하 버림)
            Console.WriteLine(var1 % var2);     // 100
    
    5.5 관계 연산자 :
        ==, !=, >, <, >=, <=

        5.5.1 설명 : 
            == : 두 값이 같으면 참, 다르면 거짓
            != : 두 값이 다르면 참, 같으면 거짓
            > : 왼쪽 값이 오른쪽 값보다 크면 참, 작으면 거짓
            < : 왼쪽 값이 오른쪽 값보다 작으면 참, 크면 거짓
            >= : 왼쪽 값이 오른쪽 값보다 크거나 같으면 참, 작으면 거짓
            <= : 왼쪽 값이 오른쪽 값보다 작거나 같으면 참, 크면 거짓

        5.5.2 예시 :
            int var1 = 100, var2 = 200;
            Console.WriteLine(var1 == var2);    // False
            Console.WriteLine(var1 != var2);    // True
            Console.WriteLine(var1 > var2);     // False
            Console.WriteLine(var1 < var2);     // True
            Console.WriteLine(var1 >= var2);    // False
            Console.WriteLine(var1 <= var2);    // True
        
*/

#endregion
#region 5. 연산자 (논리, 비트, 조건, 시프트, 타입 변환) [p137~151]

/*  5.6 논리 연산자 :
        &&, ||, !

        5.6.1 설명 : 
            && : 두 조건이 모두 참일 때 참, 하나라도 거짓이면 거짓
            || : 두 조건 중 하나라도 참이면 참, 모두 거짓이면 거짓
            ! : 논리값을 반전
        
        5.6.2 예시 :
            bool var1 = true, var2 = false;
            Console.WriteLine(var1 && var2);    // False
            Console.WriteLine(var1 || var2);    // True
            Console.WriteLine(!var1);           // False
            Console.WriteLine(!var2);           // True

    5.7 비트 연산자 :
        &, |, ^, ~, <<, >>

        5.7.1 설명 :
            & : 두 비트가 모두 1일 때 1, 나머지 0
            | : 두 비트 중 하나라도 1일 때 1, 모두 0일 때 0
            ^ : 두 비트가 서로 다르면 1, 같으면 0
            ~ : 비트 반전.
            << : 비트를 왼쪽으로 이동
            >> : 비트를 오른쪽으로 이동

        5.7.2 예시 :
            int var1 = 100, var2 = 200;
            Console.WriteLine(var1 & var2);     // 64   (100 & 200 : 0110 0100 & 1100 1000 = 0100 0000 = 64)
            Console.WriteLine(var1 | var2);     // 236  (100 | 200 : 0110 0100 | 1100 1000 = 1110 1100 = 236)
            Console.WriteLine(var1 ^ var2);     // 172  (100 ^ 200 : 0110 0100 ^ 1100 1000 = 1010 1100 = 172)
            Console.WriteLine(~var1);           // -101 (100 : 0110 0100 -> 1001 1011 -> -101)
            Console.WriteLine(var1 << 2);       // 400  (100 << 2 : 100 * 2^2 = 400)
            Console.WriteLine(var1 >> 2);       // 25   (100 >> 2 : 100 / 2^2 = 25)

    5.8 조건 연산자 :
        조건식 ? 참일 때 값 : 거짓일 때 값
        주로 if-else 문을 대체하여 사용

        5.8.1 예시 :
            int var1 = 100, var2 = 200;
            int var3 = (var1 > var2) ? var1 : var2;  // var1이 var2보다 크면 var1, 아니면 var2
            Console.WriteLine(var3);                 // 200

    5.9 시프트 연산자 :
        <<, >>

        5.9.1 설명 :
            << : 비트를 왼쪽으로 이동
            >> : 비트를 오른쪽으로 이동

        5.9.2 예시 :
            int var1 = 100;
            Console.WriteLine(var1 << 2);   // 100 << 2 : 100 * 2^2 = 400
            Console.WriteLine(var1 >> 2);   // 100 >> 2 : 100 / 2^2 = 25

    5.10 타입 변환 연산자 :
        값의 자료형을 다른 자료형으로 변환

        5.10.1 예시 : 
            int var1 = 100;
            long var2 = (long)var1;     // int -> long
            float var3 = (float)var1;   // int -> float

*/

#endregion
#region 5. 연산자 (sizeof, typeof, is, as, 우선순위) [p152~153]

/*  5.11 sizeof 연산자 :
        데이터 형식의 크기를 반환

        5.11.1 예시 :
            int var1 = 100;
            Console.WriteLine(sizeof(int));     // 4

    5.12 typeof 연산자 :
        데이터 형식을 반환

        5.12.1 예시 :
            int var1 = 100;
            Console.WriteLine(typeof(int));     // System.Int32

    5.13 is 연산자 :
        객체가 특정 형식인지 확인

        5.13.1 예시 :
            int var1 = 100;
            Console.WriteLine(var1 is int);     // True
        
        5.13.2 foreach 문과 is 연산자 :
            int[] arr = { 10, 20, 30, 40, 50 };     // 배열 선언 및 초기화
            foreach (var i in arr)                  // foreach 문으로 배열 요소 출력
            {
                if (i is int)                           // i가 int형식이면 출력
                {
                    Console.WriteLine(i);               // 10, 20, 30, 40, 50
                }
            }

    5.14 as 연산자 :
        형식 변환 연산자와 유사하나, 변환 실패 시 null 반환

        5.14.1 예시 :
            object var1 = 100;
            int? var2 = var1 as int?;
            Console.WriteLine(var2);            // 100

        5.14.2 예시 :
            object var1 = 100;
            string? var2 = var1 as string;
            Console.WriteLine(var2);            // null

    5.15 연산자 우선순위 :
        위로 갈수록 우선순위가 높음, 같은 줄에서는 왼쪽으로 갈수록 우선순위가 높음.

        5.15.1 다음 항목별로 우선순위가 높음 :
            괄호(), 증감++, --, 단항+, -, !, ~, 캐스트, new, sizeof, typeof, is, as
            산술 *, /, %
            산술 +, -
            시프트 <<, >>
            관계 <, <=, >, >=
            관계 ==, !=
            비트 AND &
            비트 XOR ^
            비트 OR |
            논리 AND &&
            논리 OR ||
            조건 ? :
            대입 =, +=, -=, *=, /=, %=, &=, ^=, |=, <<=, >>=

*/

#endregion
#region 6. 제어문 {조건문} (if, switch) [p154~181]

/*  6.1 제어문이란 :
        프로그램의 흐름을 제어하는 명령문
        조건문, 반복문, 분기문으로 구분

        6.1.1 조건문 : if, switch
        6.1.2 반복문 : for, while, do-while, foreach
        6.1.3 분기문 : break, continue, return, goto

    6.2 if 조건문 :
        조건식이 참일 때 명령문을 실행

        6.2.1 if 조건문 형식 :
            if (조건식)
            {
                명령문;
            }
        
        6.2.2 if-else 조건문 형식 :
            if (조건식)
            {
                명령문1;
            }
            else
            {
                명령문2;
            }

        6.2.3 if-else if-else 조건문 형식 :
            if (조건식1)
            {
                명령문1;
            }
            else if (조건식2)
            {
                명령문2;
            }
            else
            {
                명령문3;
            }

    6.3 switch 조건문 :
        조건식의 값에 따라 case문을 실행

        6.3.1 switch 조건문 형식 :
            switch (조건식)
            {
                case 값1:
                    명령문;
                    break;
                case 값2:
                    명령문;
                    break;
                default:
                    명령문;
                    break;
            }

*/

#endregion
#region 6. 제어문 {반복문} (for, while, do-while, foreach) [p182~206]

/*  6.4 for 반복문 :
        조건식이 참일 때 명령문을 반복 실행

        6.4.1 for 반복문 형식 :
            for (초기식; 조건식; 증감식)
            {
                명령문;
            }

        6.4.2 for 반복문 예시 :
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

    6.5 while 반복문 :
        조건식이 참일 때 명령문을 반복 실행

        6.5.1 while 반복문 형식 :
            while (조건식)
            {
                명령문;
            }

        6.5.2 while 반복문 예시 :
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

    6.6 do-while 반복문 :
        명령문을 실행한 후 조건식을 검사

        6.6.1 do-while 반복문 형식 :
            do
            {
                명령문;
            } while (조건식);

        6.6.2 do-while 반복문 예시 :
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 10);

    6.7 foreach 반복문 :
        배열 또는 컬렉션의 요소를 순차적으로 반복

        6.7.1 foreach 반복문 형식 :
            foreach (데이터형식 변수 in 배열 또는 컬렉션)
            {
                명령문;
            }

        6.7.2 foreach 반복문 예시 :
            int[] arr = { 10, 20, 30, 40, 50 };
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

*/

#endregion
#region 6. 제어문 {분기문} (break, continue, return, goto) [p207~213]

/*  6.8 break 분기문 :
        반복문을 종료하고 다음 명령문으로 이동

        6.8.1 break 분기문 예시 :
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i);       // 0, 1, 2, 3, 4
            }

    6.9 continue 분기문 :
        반복문의 나머지 명령문을 건너뛰고 다음 반복으로 이동

        6.9.1 continue 분기문 예시 :
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);       // 0, 1, 2, 3, 4, 6, 7, 8, 9
            }

    6.10 return 분기문 :
        메서드를 종료하고 값을 반환

        6.10.1 return 분기문 예시 :
            int Add(int a, int b)
            {
                return a + b;
            }

    6.11 goto 분기문 :
        지정된 레이블로 이동

        6.11.1 goto 분기문 형식 :
            goto 레이블;

        6.11.2 goto 분기문 예시 :
            int i = 0;
            start:                          // start 레이블
            Console.WriteLine(i);               // 0, 1, 2, 3, 4, 5, 6, 7, 8, 9
            i++;                                // i 증가
            if (i < 10)                         // i가 10보다 작으면
            {
                goto start;                 // start 레이블로 이동
            }

*/

#endregion
#region 7. 배열 (Array) [p214~242]

/*  7.1 배열이란 :
        동일한 데이터 형식의 요소를 여러 개 저장하는 자료구조
        인덱스로 요소에 접근

    7.2 배열 선언 :
        데이터형식[] 배열명 = new 데이터형식[길이];

        7.2.1 배열 선언 예시 :
            int[] arr = new int[5];

    7.3 배열 초기화 :
        데이터형식[] 배열명 = new 데이터형식[] { 요소1, 요소2, 요소3... };

        7.3.1 배열 초기화 예시 :
            int[] arr = new int[] { 10, 20, 30, 40, 50 };

        7.3.2 배열 선언 및 초기화 예시:
            int[] arr = new int[5] { 10, 20, 30, 40, 50 };
            int[] arr = { 10, 20, 30, 40, 50 };

    7.4 배열 요소 접근 :
        배열명[인덱스] = 값;

        7.4.1 배열 요소 접근 예시 :
            int[] arr = new int[5];
            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30;
            arr[3] = 40;
            arr[4] = 50;

    7.5 다차원 배열 :
        데이터형식[,] 배열명 = new 데이터형식[행, 열];

        7.5.1 2차원 배열 선언 예시 :
            int[,] arr = new int[2, 3];
        
        7.5.2 2차원 배열 초기화 예시 :
            int[,] arr = new int[,] { { 10, 20, 30 }, { 40, 50, 60 } };

        7.5.3 3차원 배열 선언 예시 :
            int[,,] arr = new int[2, 3, 4];

        7.5.4 3차원 배열 초기화 예시 :
            int[,,] arr = new int[,,] { { { 10, 20, 30 }, { 40, 50, 60 }, { 70, 80, 90 } }, { { 100, 200, 300 }, { 400, 500, 600 }, { 700, 800, 900 } } };

    7.6 가변 배열 :
        데이터형식[][] 배열명 = new 데이터형식[길이][];
        가변 배열은 3차원 배열까지 가능

        7.6.1 가변 배열 예시 :
            int[][] arr = new int[3][];
            
*/

#endregion
#region 8. 함수 (Function) [p243~271]   ⎛⎝。O ⩊ O。⎛⎝

/*  8.1 함수란 :
        프로그램의 기능을 수행하는 코드 블록. 재사용성을 높이고 코드의 중복을 줄임.
        함수는 메서드(Method)라고도 함.

        8.1.1 함수의 실행 단계 :
            1. 함수 호출, 2. 함수 정의, 3. 함수 실행, 4. 함수 반환

        8.1.2 내장 함수, 사용자 정의 함수 :
            내장 함수 : .NET Framework에 미리 정의된 함수. API(Application Programming Interface) 제공
            사용자 정의 함수 : 사용자가 직접 정의한 함수

    8.2 함수의 사용법 :

        8.2.1 함수의 정의 형식 :
            [접근제한자] [static] 반환형식 함수명(매개변수)
            {
                명령문;
                return 반환값;
            }

        8.2.2 함수의 정의 예시 :
            public int Add(int a, int b)    // 접근제한자 public, 반환형식 int, 함수명 Add, 매개변수 a, b
            {
                return a + b;               // 반환값 a + b
            }
        
        8.2.3 함수의 호출 형식 :
            함수명(매개변수);
        
        8.2.4 함수의 호출 예시 :
            int result = Add(10, 20);      // Add 함수 호출, 매개변수 10, 20 전달

        8.2.5 XML 주석 :
            함수 위에 XML 주석을 작성하여 함수의 설명, 매개변수, 반환값을 기술
            함수를 먼저 작성하고, 함수명 위에 ///을 입력하면 자동으로 XML 주석이 생성
            /// <summary>
            /// 함수의 설명
            /// </summary>
            /// <param name="매개변수">매개변수 설명</param>
            /// <returns>반환값 설명</returns>

    8.3 매개변수(Parameter), 반환값(Return Value) :
            
        8.3.1 매개변수(Parameter) :
            함수를 호출할 때 전달하는 값
            매개변수는 함수의 정의에 선언된 변수

            8.3.1.1 인자, 파라미터 :
                인자(Argument) : 함수를 호출할 때 전달하는 값
                파라미터(Parameter) : 함수를 정의할 때 선언하는 변수

        8.3.2 반환값(Return Value) :
            함수의 실행 결과를 반환
            반환값은 함수의 정의에 선언된 반환형식과 일치해야 함
    
        8.3.3 예시 :
            internal class Program
            {
                static void Main()                  // (1) Main 함수 정의, void는 반환값이 없음
                {
                    int result = Add(10, 20);       // (2) Add 함수 호출, 인자 10, 20 전달
                    Console.WriteLine(result);      // (5) Add 함수 반환값 콘솔에 출력, (6) 종료
                }
                int Add(int a, int b)               // (3) Add 함수 정의, 매개변수 a, b
                {
                    return a + b;                   // (4) a + b 반환
                }
            }

    8.4 매개변수 전달 방식 :
    
        8.4.1 값에 의한 전달(Call by Value) :
            매개변수로 전달된 값을 복사하여 전달
            함수 내에서 매개변수 값을 변경해도 호출자에게 영향을 주지 않음

        8.4.2 참조에 의한 전달(Call by Reference) :
            매개변수로 전달된 값을 참조하여 전달
            함수 내에서 매개변수 값을 변경하면 호출자에게 영향을 줌

            8.4.2.1 ref 키워드 :
                매개변수 앞에 명시적으로 ref 키워드를 사용하여 참조에 의한 전달을 지정
                ref 키워드를 사용하였을 때 함수 내에서 매개변수 값을 변경하면 호출자에게 영향을 줌
                다만 매개변수로 전달할 때 반드시 초기화되어 있어야 함
            
            8.4.2.2 out 키워드 :
                매개변수 앞에 명시적으로 out 키워드를 사용하여 참조에 의한 전달을 지정
                out 키워드를 사용하였을 때 함수 내에서 매개변수 값을 변경하면 호출자에게 영향을 줌
                매개변수로 전달할 때 초기화되어 있지 않아도 되나, 함수 내부에서 반드시 초기화되어야 함

            8.4.2.3 각각 장점 :
                ref : 
                    메서드 내에서 전달하는 변수를 변경하고자 할 때 사용
                    매개변수에 직접 접근하여 값의 복사가 일어나는 것을 방지하기 때문에 성능 향상을 기대할 수 있음
                    즉 시간과 메모리를 절약할 수 있음
                out : 
                    메서드 내에서 전달하는 변수를 초기화하고자 할 때 사용
                    매서드 내에서 반드시 할당해야 하기 때문에 프로그래머의 실수를 방지할 수 있음

        8.4.3 예시 :
            return을 사용하여 값을 반환하는 것이 아닌, ref, out을 사용하여 값에 직접 접근하여 값을 변경하는 것
            
            8.4.3.1 값에 의한 전달(Call by Value) :
                internal class Program
                {
                    static void Main()
                    {
                        int var = 1;                            // (1) 변수 var 선언, 초기화
                        ValueFunction(var);                     // (2) ValueFunction 함수 호출, var 값 전달
                        Console.WriteLine(var);                 // (5) var 값 = 1 출력, (6) 종료
                    }
                    public static void ValueFunction(int i)     // (3) ValueFunction 함수 정의, 매개변수 i 선언
                    {
                        i = 10;                                 // (4) i 값 변경. 호출자에게 영향을 주지 않음
                    }
                }
            
            8.4.3.2 참조(ref)에 의한 전달(Call by Reference) :
                internal class Program
                {
                    static void Main()
                    {
                        int var = 1;                            // (1) 변수 var 선언, 초기화
                        RefFunction(ref var);                   // (2) RefFunction 함수 호출, var 값의 참조 전달
                        Console.WriteLine(var);                 // (5) var 값 = 10 출력, (6) 종료
                    }
                    public static void RefFunction(ref int i)   // (3) RefFunction 함수 정의, 매개변수 i 선언
                    {
                        i = 10;                                 // (4) i 값 변경. 호출자에게 영향을 줌 {참조된 변수의 값이 변경됨} 초기화가 필수는 아님
                    }
                }
            
            8.4.3.3 참조(out)에 의한 전달(Call by Reference) :
                internal class Program
                {
                    static void Main()
                    {
                        int var;                                // (1) 변수 var 선언
                        OutFunction(out var);                   // (2) OutFunction 함수 호출, var 값의 참조 전달
                        Console.WriteLine(var);                 // (5) var 값 = 10 출력, (6) 종료
                    }
                    public static void OutFunction(out int i)   // (3) OutFunction 함수 정의, 매개변수 i 선언
                    {
                        i = 10;                                 // (4) i 값 변경. 호출자에게 영향을 줌 {참조된 변수의 값이 변경됨} 초기화가 필수
                    }
                }
    
    8.5 명명된 매개변수 :
        매개변수의 이름을 명시하여 전달하는 방식
        매개변수의 순서를 지키지 않고 전달 가능

        8.5.1 명명된 매개변수 예시 :
            internal class Program
            {
                static void Main()
                {
                    NamedFunction(b: 10, a: 20);                // (1) NamedFunction 함수 호출, 명명된 매개변수 a, b 전달
                }
                public static void NamedFunction(int a, int b)  // (2) NamedFunction 함수 정의, 매개변수 a, b 선언
                {
                    Console.WriteLine(a);                       // (3) a 값 = 20 출력
                    Console.WriteLine(b);                       // (4) b 값 = 10 출력
                }
            }

    8.6 함수 오버로드 (다중 정의) :
        동일한 이름의 함수를 여러 개 정의하는 것. 매개변수의 개수, 자료형, 순서가 다르면 가능
        
        8.6.1 매개변수가 없거나 있는 함수 오버로드 :
            internal class Program
            {
                static void Main()
                {
                    OverloadFunction();                         // (1) OverloadFunction 함수 호출
                    OverloadFunction(10);                       // (4) OverloadFunction 함수 호출, 매개변수 10 전달
                }
                public static void OverloadFunction()           // (2) OverloadFunction 함수 정의, 매개변수 없음
                {
                    Console.WriteLine("매개변수 없음");          // (3) (매개변수 없음) 출력
                }
                public static void OverloadFunction(int i)      // (5) OverloadFunction 함수 정의, 매개변수 i 선언
                {
                    Console.WriteLine("매개변수 : " + i);       // (6) (매개변수 : 10) 출력
                }
            }

        8.6.2 매개변수의 자료형이 다른 함수 오버로드 :
            internal class Program
            {
                static void Main()
                {
                    OverloadFunction(10);                       // (1) OverloadFunction 함수 호출, 매개변수 10 전달
                    OverloadFunction(10.5);                     // (4) OverloadFunction 함수 호출, 매개변수 10.5 전달
                }
                public static void OverloadFunction(int i)      // (2) OverloadFunction 함수 정의, 매개변수 i 선언
                {
                    Console.WriteLine("정수 : " + i);           // (3) (정수 : 10) 출력
                }
                public static void OverloadFunction(double d)   // (5) OverloadFunction 함수 정의, 매개변수 d 선언
                {
                    Console.WriteLine("실수 : " + d);           // (6) (실수 : 10.5) 출력
                }
            }

        8.6.3 매개변수의 순서가 다른 함수 오버로드 :
            internal class Program
            {
                static void Main()
                {
                    OverloadFunction(10, 20.5);                     // (1) OverloadFunction 함수 호출, 매개변수 10, 20.5 전달
                    OverloadFunction(20.5, 10);                     // (4) OverloadFunction 함수 호출, 매개변수 20.5, 10 전달
                }
                public static void OverloadFunction(int a, float b) // (2) OverloadFunction 함수 정의, 매개변수 a, b 선언
                {
                    Console.WriteLine("a : " + a + ", b : " + b);   // (3) (a : 10, b : 20.5) 출력
                }
                public static void OverloadFunction(float b, int a) // (5) OverloadFunction 함수 정의, 매개변수 b, a 선언
                {
                    Console.WriteLine("b : " + b + ", a : " + a);   // (6) (b : 20.5, a : 10) 출력
                }
            }

    8.7 가변 길이 매개변수 :
        매개변수의 개수가 가변적인 함수 정의
        params 키워드를 사용하여 가변 길이 매개변수를 지정

        8.7.1 가변 길이 매개변수 예시 :
            internal class Program
            {
                static void Main()
                {
                    Console.WriteLine(Sum(1, 2, 3, 4, 5));          // Sum 함수 호출, 매개변수 1, 2, 3, 4, 5 전달
                    Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7));    // Sum 함수 호출, 매개변수 1, 2, 3, 4, 5, 6, 7 전달
                }

                public static int Sum(params int[] numbers)         // 매개변수를 전부 더하여 반환하는 Sum 함수
                {
                    int sum = 0;
                    foreach (int i in numbers)
                    {
                        sum += i;
                    }
                    return sum;
                }
            }

    8.8 재귀 함수 :
        함수 내에서 자기 자신을 호출하는 함수
        재귀 함수는 반드시 종료 조건을 설정해야 함

        8.8.1 재귀 함수 예시 :
            internal class Program
            {
                static void Main()
                {
                    Console.WriteLine(Factorial(5));                // Factorial 함수 호출, 매개변수 5 전달
                }

                public static int Factorial(int i)                  // 팩토리얼을 구하는 Factorial 함수
                {
                    if (i == 1) return 1;                           // 종료 조건. i가 1이면 1 반환하고 재귀함수를 빠져나감
                    return i * Factorial(i - 1);                    // 자기 자신을 계속 호출하여 계속된 반환값을 곱함. ex) 5 * 4 * 3 * 2 * 1
                }
            }
    
    8.9 함수 범위 :
        함수 내에서 선언된 변수는 함수 내에서만 사용 가능
        함수 외부에서 선언된 변수(클래스 내에서 선언된 변수)는 함수 내부에서 사용 가능

        8.9.1 함수 범위 예시 :
            public class Program
            {
                public static int globalvar = 100;      // (1) 전역변수 globalvar 선언, 초기화. [정적 할당]

                public static void Main()               // (2) Main 함수 정의
                {
                    Console.WriteLine(globalvar);       // (3) globalvar 값 = 100 출력
                    Console.WriteLine(localvar);        // (4) ★ 오류 발생
                    Program program = new Program();    // (5) Program 클래스의 program 객체 생성. [동적 할당]
                    program.Function();                 // (6) program 객체의 Function 함수 호출.
                }

                public void Function()                  // (7) Function 함수 정의
                {
                    int localvar = 10;                  // (8) 지역변수 localvar 선언, 초기화
                    Console.WriteLine(localvar);        // (9) localvar 값 = 10 출력
                }
            }

    8.10 로컬 함수 :
        함수 내부에 선언된 함수
        로컬 함수는 함수 내부에서만 사용 가능

        8.10.1 로컬 함수 예시 :
            internal class Program
            {
                static void Main()                          // (1) Main() 메서드 정의
                {
                    LocalFunction();                        // (2) LocalFunction() 함수 호출
                    void LocalFunction()                    // (3) LocalFunction() 함수 정의
                    {
                        Console.WriteLine("로컬 함수");      // (4) "로컬 함수" 출력
                    }
                }
            }
    
    8.11 Main() 메서드의 명령줄 인수 :
        Main() 메서드의 매개변수로 string[] args를 사용하여 명령줄 인수를 전달
        명령줄 인수는 프로그램 실행 시 전달하는 인수

        8.11.1 Main() 메서드의 명령줄 인수 예시 :
            internal class Program
            {
                static void Main(string[] args)              // (1) Main() 메서드 정의, 매개변수 args 선언
                {
                    foreach (string arg in args)             // (2) args 배열의 요소를 반복하여 출력
                    {
                        Console.WriteLine(arg);               // (3) args 배열의 요소 출력
                    }
                }
            }
        
        8.11.2 명령줄 인수 입력 방법 :
            1. 프로젝트 속성 > 디버그 > 명령줄 인수 입력
            2. 프로그램 실행 시 명령줄에 인수 입력

*/

#endregion
#endregion

#region ★ C# 활용 ★   ( • ᴗ - ) ✧
#region 1. .NET API (dotNET Application Programming Interface) [p280~284]

/*  1.1 .NET API란 :
        .NET Framework에서 제공하는 클래스, 인터페이스, 구조체, 델리게이트, 열거형 등의 집합
        .NET API를 사용하여 프로그램 개발

    1.2 .NET API 사용법 :
        1.2.1 using 문 :
            using System; : System 네임스페이스 사용
            using System.Collections.Generic; : System.Collections.Generic 네임스페이스 사용
            using System.Linq; : System.Linq 네임스페이스 사용
            using System.Text; : System.Text 네임스페이스 사용
            using System.Threading.Tasks; : System.Threading.Tasks 네임스페이스 사용

        1.2.2 .NET API 사용 예시 :
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;
            using static System.Console;            // Console 클래스의 정적 멤버를 사용하기 위해 using static 사용

            namespace ConsoleApp1
            {
                class Program
                {
                    static void Main(string[] args)
                    {
                        Console.WriteLine("Hello World!");  // using System; 을 사용하여 Console.WriteLine() 사용
                        WriteLine("Hello World!");          // using static System.Console; 을 사용하여 WriteLine() 사용
                    }
                }
            }

        1.2.3 .NET API 주요 네임스페이스 :
            System : 기본적인 데이터 형식, 예외 처리, 이벤트 처리, 파일 및 데이터 입출력, 문자열 처리 등의 클래스 제공
            System.Collections.Generic : 제네릭 컬렉션 클래스 제공
            System.Linq : LINQ(Language Integrated Query)를 사용하여 데이터 질의 기능 제공
            System.Text : 문자열 처리, 문자 인코딩, 디코딩, 문자 집합 등의 클래스 제공
            System.Threading.Tasks : 비동기 프로그래밍을 위한 클래스 제공

    1.3 nameof 연산자 :
        변수, 형식, 멤버의 이름을 문자열로 반환
        nameof(변수명), nameof(형식명), nameof(멤버명)
        주로 디버깅, 예외 처리, 리플렉션 등에 사용하며, 문자열 리터럴을 사용할 때 오타를 방지함.
        문자열로 반환되기 때문에 리팩토링 시에도 이름이 변경되어도 코드를 수정할 필요가 없음

        1.4.1 nameof 연산자 예시 :
            using System;
            using static System.Console;

            namespace ConsoleApp1
            {
                class Program
                {
                    static void Main(string[] args)
                    {
                        int num = 100;
                        WriteLine(nameof(num));         // num 출력
                        WriteLine(nameof(Console));     // Console 출력
                        WriteLine(nameof(WriteLine));   // WriteLine 출력
                    }
                }
            }

*/

#endregion
#region 2. 구조체 (Struct) [p285~298]

/*  2.1 구조체란 :
        클래스와 유사한 데이터 형식
        클래스와 달리 상속, 인터페이스, 생성자, 소멸자, 인덱서, 이벤트, 대리자, 속성, 메서드, 필드, 프로퍼티 등을 가질 수 없음
        구조체는 값 형식이며, 클래스는 참조 형식 (값 형식은 스택에 저장, 참조 형식은 힙에 저장)
        주로 간단한 데이터 형식을 정의할 때 사용하며, 하나의 구조체로 여러 인스턴스를 생성하여 사용 가능
        여러 인스턴스 생성 시 각 인스턴스는 서로 독립적이며, 하나의 인스턴스를 변경해도 다른 인스턴스에 영향을 주지 않음
        그 이유는 값 형식이기 때문에 각 인스턴스는 서로 다른 메모리 공간에 저장되기 때문
        (클래스는 참조 형식이기 때문에 인스턴스가 생성될 때 힙에 저장되며, 인스턴스는 참조를 공유하기 때문에 하나의 인스턴스를 변경하면 다른 인스턴스에 영향을 줌)

    2.2 구조체 선언 :
        namespace 네임스페이스명
        {
            struct 구조체명
            {
                멤버;
            }
        }

        2.2.1 구조체 선언 예시 :
            namespace ConsoleApp1
            {
                struct Point
                {
                    public int x;
                    public int y;
                }
            }
    
    2.3 구조체 인스턴스 생성 :
        구조체명 변수명 = new 구조체명();

        2.3.1 구조체 인스턴스 생성 예시 :
            Point point = new Point();
            point.x = 10;
            point.y = 20;

    2.4 구조체 배열 :
        구조체명[] 배열명 = new 구조체명[길이];

        2.4.1 구조체 배열 예시 :
            namespace ConsoleApp1
            {
                struct Point
                {
                    public int x;
                    public int y;
                }

                class Program
                {
                    static void Main(string[] args)
                    {
                        Point[] points = new Point[3];
                        points[0].x = 10;
                        points[0].y = 20;
                        points[1].x = 30;
                        points[1].y = 40;
                        points[2].x = 50;
                        points[2].y = 60;
                    }
                }
            }
    
    2.5 구조체 매개변수 :
        구조체를 매개변수로 전달할 때 값 형식이기 때문에 값이 복사되어 전달됨
        값이 복사되어 전달되기 때문에 함수 내에서 구조체의 값을 변경해도 호출자에게 영향을 주지 않음

        2.5.1 예시 :
            namespace ConsoleApp1
            {
                struct Point
                {
                    public int x;
                    public int y;
                }

                class Program
                {
                    static void Main(string[] args)
                    {
                        int x = 100, y = 200;
                        PrintPoint(x, y);       // x, y 값 전달

                        Point point = new Point();
                        point.x = 10;
                        point.y = 20;
                        PrintPoint(point);      // 구조체 변수인 point의 복사본이 전달
                        
                    }

                    static void PrintPoint(int x, int y)    // 오버로드 1
                    {
                        Console.WriteLine($"{x}, {y}");                 // x, y 값 출력
                    }

                    static void PrintPoint(Point point)     // 오버로드 2
                    {
                        Console.WriteLine($"{point.x}, {point.y}");     // point 구조체의 x, y 값 출력
                    }
                }
            }
        
    2.6 내장형 구조체 :
        C#에서 제공하는 내장형 구조체
        System 네임스페이스에 정의되어 있음

        2.6.1 내장형 구조체 종류 :
            DateTime : 날짜와 시간을 나타내는 구조체
            TimeSpan : 시간 간격을 나타내는 구조체
            Guid : 고유 식별자를 나타내는 구조체
            Version : 버전 정보를 나타내는 구조체
            Point : 2차원 좌표를 나타내는 구조체
            Size : 너비와 높이를 나타내는 구조체
            Rectangle : 사각형을 나타내는 구조체
            Color : 색상을 나타내는 구조체
            Font : 글꼴을 나타내는 구조체
            등등...

            2.6.1.1 내장형 구조체 예시 :
                using System;

                namespace ConsoleApp1
                {
                    class Program
                    {
                        static void Main(string[] args)
                        {
                            DateTime dateTime = new DateTime(2021, 1, 1);     // DateTime 구조체 인스턴스 생성
                            Console.WriteLine(dateTime);                      // 2021-01-01 00:00:00 출력
                        }
                    }
                }
            
            2.6.1.2 내장형 구조체 Guid 예시 :
                using System;

                namespace ConsoleApp1
                {
                    class Program
                    {
                        static void Main(string[] args)
                        {
                            Guid guid = Guid.NewGuid();      // Guid 구조체 인스턴스 생성
                            Console.WriteLine(guid);         // 고유 식별자 출력. 실행할 때마다 값이 다름. ex) 1b4e28ba-2fa1-4e28-b185-3a4f5c91db2e
                            Console.WriteLine(guid);         // 고유 식별자 출력. 고유한 값이므로 윗줄과 동일한 값이 출력됨
                        }
                    }
                }

*/

#endregion
#region 3. 열거형 (Enum) [p299~308]

/*  3.1 열거형이란 :
        명명된 상수의 집합을 정의하는 데이터 형식으로, 각 상수는 기본적으로 정수형 값을 가짐
        필요에 따라 정수형 값을 명시적으로 지정할 수 있으며, 기본적으로 0부터 시작하여 1씩 증가하는 값이 할당됨
        
        3.1.1 사용 이유 :
            코드의 가독성을 높이고, 프로그램의 유지보수를 용이하게 하기 위해 사용
            상수를 사용하여 프로그램의 가독성을 높이고, 상수의 값이 변경되어도 프로그램의 수정이 용이함
            또한 열거형을 사용하면 값 리스트 여러 개를 하나의 이름으로 관리할 수 있다는 장점이 있음
        
    3.2 열거형 선언 :
        enum [열거형명]
        {
            상수1,
            상수2,
            상수3,
            ...
        }

        3.2.1 열거형 선언 예시 :
            enum Day
            {
                Sunday,             // 0
                Monday,             // 1
                Tuesday,            // 2
                Wednesday = 10,     // 10
                Thursday,           // 11
                Friday,             // 12
                Saturday            // 13
            }
        
        3.2.2 사용 예시 :
            internal class Program
            {
                enum Day                            // 열거형 Day 선언
                {
                    Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
                }
                static void Main()
                {
                    Day day = Day.Tuesday;                  // 열거형 변수 day 선언, Day.Tuesday값(2)으로 초기화
                    Console.WriteLine(day);                 // Tuesday 출력
                    Console.WriteLine((int)day);            // 0 출력
                    Console.WriteLine(nameof(day));         // day 출력
                    Console.WriteLine(nameof(Day.Tuesday)); // Tuesday 출력
                }
            }

        3.2.3 switch 문과 열거형 :
            switch 문에서 열거형을 사용할 때는 case 문에 열거형 상수를 사용
            열거형 상수는 열거형명.상수명 형식으로 사용

            internal class Program
            {
                enum Animal                                 // 열거형 Animal 선언
                {
                    Dog, Cat, Rabbit, Monkey
                }
                static void Main()
                {
                    Animal animal = Animal.Cat;             // 열거형 변수 animal 선언, Animal.Cat값(1)으로 초기화
                    switch (animal)
                    {
                        case Animal.Dog:
                            Console.WriteLine("강아지");
                            break;
                        case Animal.Cat:
                            Console.WriteLine("고양이");
                            break;
                        case Animal.Rabbit:
                            Console.WriteLine("토끼");
                            break;
                        case Animal.Monkey:
                            Console.WriteLine("원숭이");
                            break;
                    }                                       // 고양이 출력
                }

*/

#endregion
#region 4. 클래스 {1} (정의, 선언, 클래스와 메서드 레벨) [p309~333]

/*  4.1 클래스란 :
        객체 지향 프로그래밍(OOP)의 기본 단위로, 데이터와 메서드를 하나로 묶은 사용자 정의 데이터 형식
        클래스는 필드, 프로퍼티, 메서드, 이벤트, 인덱서, 생성자, 소멸자, 중첩 클래스, 중첩 구조체, 중첩 열거형 등을 가질 수 있음
        클래스는 참조 형식이고, 힙에 저장되며, 인스턴스는 참조를 공유하기 때문에 하나의 인스턴스를 변경하면 다른 인스턴스에 영향을 줌
        클래스는 new 연산자를 사용하여 인스턴스를 생성하고, 인스턴스는 힙에 저장되며, 인스턴스의 참조를 스택에 저장

        4.1.1 객체와 인스턴스 :
            클래스 (Class) : 객체를 만들기 위한 설계도
            객체 (Object) : 클래스로 구현된 모든 대상으로, 클래스 타입으로 선언되었을 때 객체라고 부른다.
            인스턴스 (Instance) : 객체 중 클래스를 바탕으로 실제로 생성된 것으로, 이 때부터 메모리에 할당되어 사용할 수 있는 상태가 된다.

            4.1.1.1 유니티의 경우 :
                Prefab : 게임 오브젝트의 원본 (템플릿)        // Prefab은 클래스는 아니지만 비슷한 역할을 함
                GameObject : 게임 오브젝트의 인스턴스        // GameObject는 객체는 아니지만 비슷한 역할을 함
            
            4.1.1.2 예시 :
                스크립트에서 동적 할당하여 사용하는 경우, 게임 오브젝트의 인스턴스를 생성하여 사용하는 것과 같음
                using UnityEngine;
                public class Example : MonoBehaviour
                {
                    public GameObject prefab;       // Prefab을 참조하기 위한 GameObject 변수 선언

                    void Start()
                    {
                        GameObject instance = Instantiate(prefab);              // Prefab을 복제하여 인스턴스 생성
                        instance.transform.position = new Vector3(0, 0, 0);     // 인스턴스의 위치를 변경
                    }
                }

    4.2 클래스 선언 :
        [접근제한자] [class] 클래스명
        {
            멤버;
        }

        4.2.1 선언과 할당 예시 :
            class Car { }          // 클래스 선언
            class Program
            {
                static void Main()
                {
                    Car car;          // 클래스 타입으로 선언. 인스턴스 생성 X
                    car = new Car();  // 클래스 타입으로 할당. 인스턴스 생성 O
                }
            }
        
    4.3 클래스 레벨, 메서드 레벨의 차이 :
        클래스 레벨의 멤버는 인스턴스 생성 없이 사용 가능
        메서드 레벨의 멤버는 인스턴스 생성 후 사용 가능

        4.3.1 클래스 레벨 :
            클래스 레벨은 클래스 자체의 범위와 접근 제한자에 따라 외부에서 접근 가능 여부가 결정됨
            클래스 레벨에서 정의된 멤버(변수, 메서드 등)는 클래스의 모든 인스턴스에서 공유됨
            또한 클래스 레벨의 멤버는 static 키워드를 사용하여 정적 멤버로 선언할 수 있음
        
        4.3.2 메서드 레벨 :
            메서드 레벨은 메서드 내부의 범위와 접근 제한자에 따라 외부에서 접근 가능 여부가 결정됨
            메서드 레벨에서 정의된 멤버(변수, 메서드 등)는 메서드 내에서만 사용 가능
            메서드 레벨의 멤버는 메서드가 호출될 때마다 새로 생성되며, 메서드가 종료되면 소멸됨

        4.3.3 클래스 레벨, 메서드 레벨의 멤버 호출 :
            public class Example
            {
                public static int classLevelVar = 10;                                   // 클래스 레벨의 정적 변수

                public static void ClassLevelMethod()                                   // 클래스 레벨의 정적 메서드
                {
                    Console.WriteLine("class level method.");
                }

                public void InstanceMethod()                                        // 인스턴스 메서드
                {
                    int methodLevelVar = 20;                                        // 메서드 레벨의 변수
                    Console.WriteLine("method level Var: " + methodLevelVar);
                }
            }

            public class Program
            {
                public static void Main()
                {
                    Example.ClassLevelMethod();                                         // 클래스 레벨의 정적 메서드 호출
                    
                    Console.WriteLine("Class level Var: " + Example.classLevelVar);     // 클래스 레벨의 정적 변수 접근

                    Example example = new Example();                                // 인스턴스 메서드 호출을 위한 인스턴스 생성
                    example.InstanceMethod();                                       // 인스턴스 메서드 호출
                }
            }

*/

#endregion
#region 4. 클래스 {2} (클래스 시그니처) [p309~333]  ( •̀ o •́ )

/*  4.4 클래스 시그니처 (Class Signature) :
        클래스 시그니처는 클래스의 구조를 정의하는 것으로, 클래스의 접근 제한자, 클래스 키워드, 클래스 이름, 상속, 인터페이스 등을 포함

        4.4.1 접근 제한자 :
            public : 어떤 클래스에서도 접근 가능
            protected : 동일 클래스 또는 파생 클래스에서만 접근 가능
            internal : 동일 어셈블리(프로젝트)에서만 접근 가능
            protected internal : 동일 어셈블리 또는 파생 클래스에서만 접근 가능
            private : 동일 클래스 내에서만 접근 가능
        
        4.4.2 클래스 키워드 :
            class :
                클래스를 정의하는 키워드로, 첫 글자는 대문자로 작성하고, 축약형이 아닌 명사로 작성하고, 특정 접두사, 언더스코어(_)를 사용하지 않음
                여러 단어로 구성된 경우 각 단어의 첫 글자는 대문자로 작성하고, 단어 사이에 공백을 사용하지 않음
            abstract :
                추상 클래스를 정의하는 키워드로, 추상 클래스는 인스턴스를 생성할 수 없으며, 추상 메서드를 포함할 수 있음
            sealed :
                클래스를 밀봉하는 키워드로, 상속을 금지하고, sealed 클래스는 더 이상 상속될 수 없음
            static :
                정적 클래스를 정의하는 키워드로, 정적 클래스는 인스턴스를 생성할 수 없으며, 정적 멤버만 포함할 수 있음
            partial :
                부분 클래스를 정의하는 키워드로, 여러 파일에 나누어 정의된 클래스를 하나로 합칠 때 사용
            new :
                메서드를 재정의하는 키워드로, 메서드를 재정의할 때 사용

        4.4.3 클래스 이름 :
            클래스의 이름을 정의하는 부분

        4.4.4 상속, 인터페이스 :
            클래스가 상속받는 클래스 또는 구현하는 인터페이스를 정의하는 부분

        4.4.5 클래스 시그니처 예시 :
            순서 : 접근 제한자, 클래스 키워드, 클래스 이름, 상속, 인터페이스
            public class Example : Parent, IInterface
            {
                ...
            }
        
        4.4.6 클래스의 주요 구성 요소 :
            필드, 프로퍼티, 메서드, 생성자, 소멸자 등이 있음.

            4.4.6.1 필드 (Field) :
                클래스의 부품 역할을 하며, 클래스 내에 선언된 변수나 데이터를 담는 공간.

                변수 (Variable) :
                    클래스의 데이터를 저장하는 공간.
                    변수는 선언 시 또는 생성자에서 초기화할 수 있으며, 초기화 후에 변경할 수 있음.
                상수 (Constant) :
                    클래스의 데이터를 상수로 저장하는 공간.
                    상수 형식의 데이터는 반드시 초기화해야 하며, 초기화 후에는 변경할 수 없음.
                읽기 전용 필드 (Readonly Field) :
                    클래스의 데이터를 읽기 전용으로 저장하는 공간.
                    읽기 전용 필드는 선언 시 또는 생성자에서 초기화할 수 있으며, 초기화 후에는 변경할 수 없음.
                배열 (Array) :
                    클래스의 데이터를 배열로 저장하는 공간으로, 동일한 데이터 형식의 여러 값을 저장할 수 있음.
                기타 : 
                    개체 (Object), 문자열 (String), 구조체 (Struct) 등.

            4.4.6.2 프로퍼티 (Property) :
                클래스의 필드에 접근하기 위한 메서드

            4.4.6.3 메서드 (Method) :
                클래스의 동작을 정의하는 함수
                ★ C# 기초 ★ 8. 함수 (Function) [p243~271] 참조.

            4.4.6.4 생성자 (Constructor) :
                일반적으로 클래스의 필드를 초기화하거나 클래스의 인스턴스를 생성할 때 필요한 작업을 수행하는 함수
                생성자는 클래스의 이름과 동일하며, 기본 생성자, 매개변수가 있는 생성자, 정적 생성자 등이 있음

            4.4.6.5 소멸자 (Destructor) :
                클래스의 인스턴스를 소멸하는 함수

*/

#endregion
#region 4. 클래스 {3} (내장 클래스) [p309~333]

/*  4.5 자주 사용하는 내장 클래스 :
        C#에서 제공하는 자주 사용하는 내장 클래스
        System 네임스페이스에 정의되어 있음

        4.5.1 자주 사용하는 내장 클래스 종류 :
            Console : 콘솔 입출력을 위한 클래스
            Math : 수학 연산을 위한 클래스
            Random : 난수 생성을 위한 클래스
            DateTime : 날짜와 시간을 다루기 위한 클래스
            TimeSpan : 시간 간격을 다루기 위한 클래스
            String : 문자열을 다루기 위한 클래스
            StringBuilder : 문자열을 동적으로 변경하기 위한 클래스
            Array : 배열을 다루기 위한 클래스
            List : 동적 배열을 다루기 위한 클래스
            Dictionary : 키와 값으로 이루어진 데이터를 다루기 위한 클래스
            Queue : 선입선출(FIFO) 방식의 데이터를 다루기 위한 클래스
            Stack : 후입선출(LIFO) 방식의 데이터를 다루기 위한 클래스
            등등...

        4.5.2 자주 사용하는 내장 클래스 예시 :
            간단히 사용하는 방법만 예시로 작성함.
            Console :
                static void Main()
                {
                    Console.WriteLine("Hello World!");      // 콘솔에 Hello World! 출력
                    Console.Write("Hello ");                // 콘솔에 Hello 출력
                    Console.Write("World!");                // 콘솔에 World! 출력
                }
            Math :
                static void Main()
                {
                    int num = 10;
                    double sqrt = Math.Sqrt(num);           // num의 제곱근을 계산하여 sqrt에 저장
                    Console.WriteLine(sqrt);                // 3.16227766016838 출력
                }
            Random :
                static void Main()
                {
                    Random random = new Random();           // Random 클래스 인스턴스 생성
                    int num = random.Next(1, 100);          // 1부터 100 사이의 난수 생성하여 num에 저장
                    Console.WriteLine(num);                 // 42 출력
                }
            DateTime :
                static void Main()
                {
                    DateTime now = DateTime.Now;            // 현재 날짜와 시간을 now에 저장
                    Console.WriteLine(now);                 // 2021-01-01 00:00:00 출력
                }
            TimeSpan :
                static void Main()
                {
                    DateTime now = DateTime.Now;            // 현재 날짜와 시간을 now에 저장
                    DateTime future = now.AddDays(1);       // now에서 1일 후의 날짜를 계산하여 future에 저장
                    TimeSpan span = future - now;           // future와 now의 시간 간격을 계산하여 span에 저장
                    Console.WriteLine(span);                // 1.00:00:00 출력
                }
            String :
                static void Main()
                {
                    string str = "Hello World!";            // 문자열 str 선언
                    Console.WriteLine(str);                 // Hello World! 출력
                }
            StringBuilder :
                static void Main()
                {
                    StringBuilder sb = new StringBuilder(); // StringBuilder 클래스 인스턴스 생성
                    sb.Append("Hello ");                    // 문자열을 추가하여 저장
                    sb.Append("World!");                    // 문자열을 추가하여 저장
                    Console.WriteLine(sb);                  // Hello World! 출력
                }
            Array :
                static void Main()
                {
                    int[] arr = new int[3];                 // 정수형 배열 arr 선언
                    arr[0] = 10;                            // 배열의 첫 번째 요소에 값 할당
                    arr[1] = 20;                            // 배열의 두 번째 요소에 값 할당
                    arr[2] = 30;                            // 배열의 세 번째 요소에 값 할당
                    Console.WriteLine(arr[1]);              // 20 출력
                }
            List :
                static void Main()
                {
                    List<int> list = new List<int>();       // 정수형 리스트 list 선언
                    list.Add(10);                           // 리스트에 값 추가
                    list.Add(20);                           // 리스트에 값 추가
                    list.Add(30);                           // 리스트에 값 추가
                    Console.WriteLine(list[1]);             // 20 출력
                }
            Dictionary :
                static void Main()
                {
                    Dictionary<string, int> dic = new Dictionary<string, int>();  // 문자열과 정수형 데이터를 가지는 딕셔너리 dic 선언
                    dic.Add("One", 1);                      // 딕셔너리에 키와 값 추가
                    dic.Add("Two", 2);                      // 딕셔너리에 키와 값 추가
                    dic.Add("Three", 3);                    // 딕셔너리에 키와 값 추가
                    Console.WriteLine(dic["Two"]);          // 2 출력
                }
            Queue :
                static void Main()
                {
                    Queue<int> queue = new Queue<int>();    // 정수형 큐 queue 선언
                    queue.Enqueue(10);                      // 큐에 값 추가
                    queue.Enqueue(20);                      // 큐에 값 추가
                    queue.Enqueue(30);                      // 큐에 값 추가
                    Console.WriteLine(queue.Dequeue());     // 10 출력. 선입선출(FIFO) 방식
                }
            Stack :
                static void Main()
                {
                    Stack<int> stack = new Stack<int>();    // 정수형 스택 stack 선언
                    stack.Push(10);                         // 스택에 값 추가
                    stack.Push(20);                         // 스택에 값 추가
                    stack.Push(30);                         // 스택에 값 추가
                    Console.WriteLine(stack.Pop());         // 30 출력. 후입선출(LIFO) 방식
                }



*/

#endregion
#region 4. 클래스 {4} (정규식, 값과 참조 형식) [p309~333]

/*  4.6 정규식 :
        정규식(Regular Expression)은 특정 패턴을 기반으로 문자열을 검색, 일치, 추출, 대체하는 데 사용됨.
        주로 문자열 검색 및 일치, 문자열 추출, 문자열 대체, 입력 유효성 검사, 문자열 분할 등에 사용됨
        C#에서는 System.Text.RegularExpressions 네임스페이스의 Regex 클래스를 사용하여 정규식을 사용할 수 있음

        4.6.1 정규식 패턴 :
            ^ : 문자열의 시작
            $ : 문자열의 끝
            . : 임의의 문자
            * : 0회 이상 반복
            + : 1회 이상 반복
            ? : 0회 또는 1회 반복
            [] : 문자 집합
            [^] : 부정 문자 집합
            | : 또는
            () : 그룹화
            \d : 숫자
            \D : 숫자가 아닌 문자
            \s : 공백 문자
            \S : 공백 문자가 아닌 문자
            \w : 단어 문자
            \W : 단어 문자가 아닌 문자

        4.6.2 정규식 사용 방법 :
            using System;
            using System.Text.RegularExpressions;

            class Program
            {
                static void Main()
                {
                    string input = "12345";                         // 입력 문자열
                    string pattern = @"\d+";                        // 숫자 패턴
                    bool isMatch = Regex.IsMatch(input, pattern);   // 정규식 패턴과 입력 문자열 일치 여부
                    Console.WriteLine(isMatch);                     // True 출력
                }
            }

        4.6.3 정규식 사용 예시 (Email 주소 검사) :
            using System;
            using System.Text.RegularExpressions;

            class Program
            {
                static void Main()
                {
                    string email = "qwer123@gmail.com";                 // 이메일 주소
                    string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";  // 이메일 주소 패턴
                    bool isMatch = Regex.IsMatch(email, pattern);       // 정규식 패턴과 이메일 주소 일치 여부
                    Console.WriteLine(isMatch);                         // True 출력
                }
            }

    4.7 값 형식과 참조 형식 :
        클래스나 구조체 같은 데이터 형식을 말할 때 값 형식과 참조 형식으로 구분하기도 함.

        4.7.1 값 형식 :
            값 형식은 스택 메모리에 저장되며, 변수에 값이 직접 저장됨
            값 형식은 System.ValueType 클래스를 상속받음
            값 형식은 int, float, double, char, bool, enum(열거형), struct(구조체) 등이 있음

        4.7.2 참조 형식 :
            참조 형식은 힙 메모리에 저장되며, 변수에는 값이 아닌 참조가 저장됨
            참조 형식은 System.Object 클래스를 상속받음
            참조 형식은 class(클래스), interface(인터페이스), delegate(대리자), string, object, dynamic 등이 있음

        4.7.3 박싱(Boxing)과 언박싱(Unboxing) :
            박싱은 값 형식을 참조 형식으로 변환하는 것
            언박싱은 참조 형식을 값 형식으로 변환하는 것
            박싱과 언박싱은 성능 저하를 일으킬 수 있으므로 필요할 때만 사용하는 것이 좋음

            4.7.3.1 박싱(Boxing) :
                int num = 10;                   // 값 형식 변수 num 선언
                object obj = num;               // 박싱. 값 형식 변수 num을 참조 형식 변수 obj에 대입

            4.7.3.2 언박싱(Unboxing) :
                object obj = 20;                // 참조 형식 변수 obj 선언
                int num = (int)obj;             // 언박싱. 참조 형식 변수 obj를 값 형식 변수 num에 대입

        4.7.4 is 연산자로 형식비교 :
            is 연산자는 참조 형식의 형식을 비교할 때 사용
            is 연산자는 형식이 일치하면 true, 일치하지 않으면 false를 반환

            4.7.4.1 예시 :
                object obj = 10;                // 참조 형식 변수 obj 선언
                if (obj is int)                 // obj가 int 형식인지 확인
                {
                    int num = (int)obj;         // obj를 int 형식으로 언박싱하여 값 형식 변수 num에 대입
                    Console.WriteLine(num);     // num 출력
                }
        4.7.5 as 연산자로 형식변환 :
            as 연산자는 참조 형식을 다른 참조 형식으로 변환할 때 사용
            as 연산자는 형식이 일치하면 형변환을 수행하고, 일치하지 않으면 null을 반환

            4.7.5.1 예시 :
                object obj = 10;                // 참조 형식 변수 obj 선언
                int? num = obj as int?;         // obj를 int? 형식으로 형변환하여 값 형식 변수 num에 대입
                if (num != null)                // num이 null이 아닌지 확인
                {
                    Console.WriteLine(num);     // num 출력
                }

*/

#endregion
#region 5. 문자열 (StringBuilder) [p334~348]

/*  5.1 문자열 다루기 :
        .NET 프레임워크에 내장된 클래스 중 (String, StringBuilder)는 문자열을 다루는 메서드를 제공함
        C#의 문자열은 유니코드(Unicode) 문자열로, System.String 클래스로 표현됨.
        다국어를 지원하며, 문자열 관련 기능들도 다국어를 지원함

        5.1.1 메서드 체이닝 :
            메서드 체이닝은 메서드를 연속적으로 호출하는 방식으로, 메서드가 반환하는 값을 다시 메서드의 인자로 사용하는 방식

        5.1.2 메서드 체이닝 예시 :
            int num = 100;
            string str = num.ToString().PadLeft(5, '0');    // num을 문자열로 변환하고, 5자리로 맞추어 왼쪽에 0을 채움
        
    5.2 문자열 관련 주요 메서드 :
    
        5.2.1 문자열 연결 :
            string.Concat : 문자열을 연결하는 메서드
            string.Join : 문자열 배열을 연결하는 메서드

        5.2.2 문자열 비교 :
            string.Equals : 문자열을 비교하는 메서드
            string.Compare : 문자열을 비교하여 정렬 순서를 반환하는 메서드

        5.2.3 문자열 검색 :
            string.IndexOf : 문자열에서 특정 문자열의 위치를 검색하는 메서드
            string.LastIndexOf : 문자열에서 특정 문자열의 마지막 위치를 검색하는 메서드

        5.2.4 문자열 변환 :
            string.ToUpper : 문자열을 대문자로 변환하는 메서드
            string.ToLower : 문자열을 소문자로 변환하는 메서드
            string.Trim : 문자열의 앞뒤 공백을 제거하는 메서드
            string.Replace : 문자열의 특정 문자열을 다른 문자열로 변경하는 메서드
            string.Substring : 문자열의 일부를 추출하는 메서드
            string.ToCharArray : 문자열을 문자 배열로 변환하는 메서드
            string.ToString : 문자열로 변환하는 메서드
            string.Insert : 문자열에 문자열을 삽입하는 메서드
            string.Remove : 문자열에서 문자열을 제거하는 메서드
            string.PadLeft : 문자열의 왼쪽에 공백을 채우는 메서드
            string.PadRight : 문자열의 오른쪽에 공백을 채우는 메서드

        5.2.5 문자열 분할 :
            string.Split : 문자열을 특정 문자로 분할하는 메서드

        5.2.6 문자열 검사 :
            string.IsNullOrEmpty : 문자열이 null 또는 빈 문자열인지 확인하는 메서드
            string.IsNullOrWhiteSpace : 문자열이 null 또는 공백 문자열인지 확인하는 메서드
        
        5.2.7 문자열 형식 :
            string.Format : 문자열을 형식화하는 메서드
            string.Join : 문자열 배열을 연결하는 메서드
        
    5.3 StringBuilder 클래스 :
        StringBuilder 클래스는 문자열을 동적으로 변경할 때 사용하는 클래스
        문자열을 변경할 때마다 새로운 문자열을 생성하는 String 클래스와 달리, StringBuilder 클래스는 기존 문자열을 변경함
        StringBuilder 클래스는 System.Text 네임스페이스에 정의되어 있음

        5.3.1 StringBuilder 클래스 사용 방법 :
            using System.Text;

            class Program
            {
                static void Main()
                {
                    StringBuilder sb = new StringBuilder();       // StringBuilder 클래스 인스턴스 생성
                    sb.Append("Hello ");                          // 문자열을 추가하여 저장
                    sb.Append("World!");                          // 문자열을 추가하여 저장
                    Console.WriteLine(sb);                        // Hello World! 출력
                }
            }

        5.3.2 StringBuilder 클래스 주요 메서드 :
            Append : 문자열을 추가하여 저장하는 메서드
            Insert : 문자열을 삽입하여 저장하는 메서드
            Remove : 문자열을 제거하여 저장하는 메서드
            Replace : 문자열을 변경하여 저장하는 메서드
            Clear : 문자열을 초기화하는 메서드
            ToString : 문자열로 변환하는 메서드





*/

#endregion





/* 클래스 생성자 소멸자 등 추후 정리
    4.1 기본 생성자 :
        기본 생성자는 매개변수가 없는 생성자를 의미하며, 클래스의 필드를 초기화하는 역할을 함
        클래스에 생성자가 없으면 컴파일러가 자동으로 생성하며,
        클래스에 생성자가 하나라도 있으면 컴파일러가 기본 생성자를 자동으로 생성하지 않음
    
    4.2 매개변수가 있는 생성자 :
        클래스에 하나 이상의 매개변수가 있는 생성자를 정의함.
        클래스의 필드를 초기화할 때 사용하며, 인스턴스 생성 시 매개변수를 전달하여 필드를 초기화할 수 있음

    4.3 정적 생성자 :
        클래스의 정적 멤버를 초기화하는 역할을 하는 생성자
        정적 생성자는 인스턴스 생성자와 무관하게 클래스가 로드될 때 한 번만 호출되며, 정적 멤버를 초기화하는 역할을 함
        따라서 인스턴스가 생성되지 않아도 정적 맴베를 초기화할 수 있음

    4.4 복사 생성자 :
        같은 클래스의 다른 인스턴스를 복사하여 새로운 인스턴스를 생성하는 생성자
        복사 생성자는 반드시 명시적으로 정의해야 함.

    4.5 생성자 체이닝 :
        생성자에서 다른 생성자를 호출하는 방식으로, this 키워드를 사용하여 다른 생성자를 호출함
        생성자 체이닝을 사용하면 중복되는 코드를 줄일 수 있음
    
    4.6 예시 :
        class Car
        {
            public string name;
            public int year;

            public Car() { }                        // 기본 생성자. 생성자가 없다면 컴파일러가 자동으로 생성

            public Car(string name)                 // 매개변수가 있는 생성자. name 필드 초기화
            { this.name = name; }

            static Car() { }                        // 정적 생성자. 정적 멤버 초기화

            public Car(Car car)                     // 복사 생성자. 다른 인스턴스를 복사하여 새로운 인스턴스 생성
            { this.name = car.name; this.year = car.year; }
        }
    
    4.7 생성자 오버로드 :
        생성자 오버로드는 하나의 클래스에 여러 개의 생성자를 정의하는 것
        생성자 오버로드를 사용하면 다양한 매개변수를 전달하여 인스턴스를 생성할 수 있음

    4.8 this() 생성자로 다른 생성자 호출 :
        this() 생성자는 다른 생성자를 호출하는 역할을 함
        this() 생성자를 사용하면 생성자 체이닝을 통해 다른 생성자를 호출할 수 있음. 생성자 포워딩이라고도 함

        4.8.1 예시 (1) :
            class Program
            {
                private string message = "Hello World!";                // 필드 선언

                public Program() => Console.WriteLine(message);         // 생성자. 필드 출력
                public Program(string message) : this() => Console.WriteLine(message);  // this() 생성자로 다른 생성자 호출
                
                static void Main(string[] args)
                {
                    Program program = new Program();                    // 기본 생성자 호출
                    Program program1 = new Program("Hi!");              // this() 생성자 호출
                }
            }
        
        4.8.2 예시 (2) :
            class Money
            {
                public Money() : this(1000) {}                                      // this() 생성자로 다른 생성자 호출
                public Money(int money) => Console.WriteLine("Money: " + money);    // 생성자
            }

            internal class Program
            {
                static void Main(string[] args)
                {
                    Money money = new Money();              // this() 생성자 호출
                    Money money1 = new Money(2000);         // 해당 생성자 호출
                }
            }
    
    4.9 생성자를 사용하여 읽기 전용 필드 초기화 :
        읽기 전용 필드는 선언 시 또는 생성자에서 초기화할 수 있으며, 초기화 후에는 변경할 수 없음
        생성자를 사용하여 읽기 전용 필드를 초기화할 때는 생성자에서 필드를 초기화하고, 읽기 전용으로 선언함

        4.9.1 예시 :
            class Program
            {
                private readonly string message;                    // 읽기 전용 필드 선언

                public Program() => message = "Hello World!";       // 생성자에서 읽기 전용 필드 초기화

                static void Main(string[] args)
                {
                    Program program = new Program();                // 생성자 호출
                    Console.WriteLine(program.message);             // 읽기 전용 필드 출력
                }
            }
    

    5.1 소멸자 :
        
*/


#endregion






/*


1. 기본 문법 및 데이터 타입
    변수 만들기
    숫자 데이터 형식 사용하기
    숫자 이외의 데이터 형식 사용하기
    사용자에게 얻은 정보를 변수에 저장하기
    문자열 다루기
    널 다루기
2. 연산자 및 제어문
    연산자 개요 및 단항 산술 연산자 사용하기
    할당 연산자와 증감 연산자 사용하기
    관계형 연산자와 논리 연산자 사용하기
    비트 연산자와 시프트 연산자로 비트 단위 연산하기
    제어문 소개 및 if else 문
    조건문 switch 문으로 다양한 조건 처리하기
    반복문 for 문으로 다양한 조건 처리하기
    while문과 do문 foreach문으로 반복처리하기
    break continue goto로 반복문 제어하기
3. 함수 및 메서드
    함수 사용하기
    메서드와 매개변수
    확장 메서드 만들기
    함수와 함수형 프로그래밍 소개하기
4. 객체 지향 프로그래밍
    개체와 개체 지향 프로그래밍
    클래스
    구조체
    생성자
    소멸자
    필드 만들기
    속성 사용하기
    인덱서와 반복기
    대리자
    이벤트
    인터페이스
    상속으로 클래스 확장하기
    메서드 오버라이드
    클래스 기타 (인터페이스, 추상 클래스, 봉인 클래스, 정적 클래스, 부분 클래스)
    제네릭 클래스 만들기
5. 고급 프로그래밍
    LINQ 사용하기
    제네릭 사용하기
    동적 형식
    튜플
    특성과 리플렉션
    네임스페이스
6. 예외 처리 및 테스트
    예외 처리하기
    테스트 프로젝트와 단위 테스트
7. 데이터 및 파일 입출력
    컬렉션 사용하기
    인메모리 데이터베이스 프로그래밍 다루기
    스트림과 파일 입출력 맛보기
    XML과 JSON 다루기
8. 네트워크 및 비동기 프로그래밍
    네트워크 프로그래밍 맛보기
    스레드
    비동기 프로그래밍
9. 기타
    닷넷 API
    클래스 라이브러리와 닷넷 스탠다드
    NeGet 패키지
    알고리즘과 절차 지향 프로그래밍















*/