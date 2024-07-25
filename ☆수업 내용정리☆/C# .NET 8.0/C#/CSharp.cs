using System;
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

#region ★ C# 정리 ★   」(￣▽￣」)

#region 1. Console.WriteLine() [p64~67]

/*  1.1 WriteLine()의 이스케이프 시퀀스(Escape Sequence) :
        \n(줄바꿈), \t(탭), \\(역슬래시), \"(큰따옴표), \'(작은따옴표)
        \u(유니코드), \U(유니코드), \x(16진수), \a(경고음), \b(백스페이스), \r(캐리지 리턴)

    1.2 WriteLine()의 서식 지정자(Format Specifier) :
        {0}, {1}, {2}... : 인덱스 위치에 매개변수를 출력
        {0, 10} : 10자리 확보 후 정렬
        {0, -10} : 10자리 확보 후 정렬(왼쪽 정렬)

    1.3 서식 지정자 예시 :
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

        2.1.1 최대값, 최소값 : 
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

    2.3 논리 데이터 형식 :
        bool(1)
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
            byte var2 = Convert.ToByte(var1);
            string var3 = Convert.ToString(var1);

    3.4 ★ 형식 변환 .NET :
        byte.Parse(), short.Parse(), int.Parse(), long.Parse(), float.Parse()
        double.Parse(), decimal.Parse(), bool.Parse()

        3.4.1 예시 :
            int var1 = 100;
            byte var2 = byte.Parse(var1.ToString());
            string var3 = int.Parse("100").ToString();
*/

#endregion
#region 4. 진수 변환 [p112~115]

/*  4.1 10진수 -> 2진수, 8진수, 16진수 변환 :
        Convert.ToString(10진수, 2)
        Convert.ToString(10진수, 8)
        Convert.ToString(10진수, 16)

        4.1.1 예시 :
            int var1 = 100;
            Console.WriteLine(Convert.ToString(var1, 2));
            Console.WriteLine(Convert.ToString(var1, 8));
            Console.WriteLine(Convert.ToString(var1, 16));

    4.2 2진수, 8진수, 16진수 -> 10진수 변환 :
        Convert.ToInt32(2진수, 2)
        Convert.ToInt32(8진수, 8)
        Convert.ToInt32(16진수, 16)

        4.2.1 예시 :
            string var1 = "1100100";
            Console.WriteLine(Convert.ToInt32(var1, 2));
            Console.WriteLine(Convert.ToInt32(var1, 8));
            Console.WriteLine(Convert.ToInt32(var1, 16));
    
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
            int var2 = ++var1;  // 전위 연산자 : var1 = var1 + 1; var2 = var1;
            int var3 = var1++;  // 후위 연산자 : var3 = var1; var1 = var1 + 1;
        
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
            Console.WriteLine(var1 + var2);
            Console.WriteLine(var1 - var2);
            Console.WriteLine(var1 * var2);
            Console.WriteLine(var1 / var2);
            Console.WriteLine(var1 % var2);
    
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
            Console.WriteLine(var1 == var2);
            Console.WriteLine(var1 != var2);
            Console.WriteLine(var1 > var2);
            Console.WriteLine(var1 < var2);
            Console.WriteLine(var1 >= var2);
            Console.WriteLine(var1 <= var2);
        
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
            Console.WriteLine(var1 && var2);
            Console.WriteLine(var1 || var2);
            Console.WriteLine(!var1);
            Console.WriteLine(!var2);

    5.7 비트 연산자 :
        &, |, ^, ~, <<, >>

        5.7.1 설명 :
            & : 두 비트가 모두 1일 때 1, 나머지 0
            | : 두 비트 중 하나라도 1일 때 1, 모두 0일 때 0
            ^ : 두 비트가 서로 다르면 1, 같으면 0
            ~ : 비트 반전
            << : 비트를 왼쪽으로 이동
            >> : 비트를 오른쪽으로 이동

        5.7.2 예시 :
            int var1 = 100, var2 = 200;
            Console.WriteLine(var1 & var2);
            Console.WriteLine(var1 | var2);
            Console.WriteLine(var1 ^ var2);
            Console.WriteLine(~var1);
            Console.WriteLine(var1 << 2);
            Console.WriteLine(var1 >> 2);

    5.8 조건 연산자 :
        조건식 ? 참일 때 값 : 거짓일 때 값

        5.8.1 예시 :
            int var1 = 100, var2 = 200;
            int var3 = (var1 > var2) ? var1 : var2;  // var1이 var2보다 크면 var1, 아니면 var2
            Console.WriteLine(var3);

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

    5.14 as 연산자 :
        형식 변환 연산자와 유사하나, 변환 실패 시 null 반환

        5.14.1 예시 :
            object var1 = 100;
            int? var2 = var1 as int?;
            Console.WriteLine(var2);            // 100

    5.15 연산자 우선순위 :
        위로 갈수록 우선순위가 높음, 같은 줄에서는 왼쪽으로 갈수록 우선순위가 높음.

        5.15.1 다음 항목별로 우선순위가 높음 :
            괄호(), 증감++, --, 단항+, -, !, ~, 캐스트, new, sizeof, typeof, is, as
            산술*, /, %, 산술+, -
            시프트<<, >>
            관계<, <=, >, >=
            관계==, !=
            비트AND&
            비트XOR^
            비트OR|
            논리AND&&
            논리OR||
            조건?:
            대입=, +=, -=, *=, /=, %=, &=, ^=, |=, <<=, >>=

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
                Console.WriteLine(i);
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
                Console.WriteLine(i);
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
            start:
            Console.WriteLine(i);
            i++;
            if (i < 10)
            {
                goto start;
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
#region 9. 




#endregion



#endregion