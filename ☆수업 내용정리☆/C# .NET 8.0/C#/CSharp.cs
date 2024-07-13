using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

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

#region ★ C# 기본 ★

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

    2.4 형식 변환 :
        Convert.ToByte(), Convert.ToInt16(), Convert.ToInt32(), Convert.ToInt64()
        Convert.ToSingle(), Convert.ToDouble(), Convert.ToDecimal(), Convert.ToString()
    
    2.4.1 형식 변환 예시 :
        int var1 = 100;
        byte var2 = Convert.ToByte(var1);
        string var3 = Convert.ToString(var1);

    2.5 형식 변환 .NET :
        byte.Parse(), short.Parse(), int.Parse(), long.Parse(), float.Parse()
        double.Parse(), decimal.Parse(), bool.Parse()

    2.5.1 형식 변환 .NET 예시 :
        int var1 = 100;
        byte var2 = byte.Parse(var1.ToString());
        string var3 = int.Parse("100").ToString();
*/

#endregion
#region 3. 


#endregion





#endregion