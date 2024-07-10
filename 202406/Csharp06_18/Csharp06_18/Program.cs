using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Eventing.Reader;
using System.Linq.Expressions;
using System.Threading;

namespace Csharp06_18
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            #region 명시적형 변환시 일어나는 일
            //int num1 = 1234;
            //long num2 = num1;
            //Console.WriteLine(num2);

            //long num3 = 1234;
            //int num4 = (int)num3;
            //Console.WriteLine(num4);

            //long l = long.MaxValue;
            //long m = long.MinValue;
            //WriteLine($"l의 값 = {l}, m의 값 = {m}");
            //int i=(int)l;
            //WriteLine($"i의 값 = {i}");
            //double dnum1 = 33.75678d;
            //int num1 = (int)dnum1;
            //WriteLine($"num1의 값 = {num1}");

            //int x = 255;
            //byte y = (byte)x; //0부터 255까지 표현가능
            //Console.WriteLine($"{x}->{y}");
            //byte b = 128;
            //sbyte c = (sbyte)b;
            //Console.WriteLine($"{c}");

            #endregion
            #region Convert 클래스로 형식 변환, 여러가지 형식으로 변환하기
            //double d = 12.34;
            //int i = 1234;

            //d = i; //d가 더 담는 그릇이 큼
            //Console.WriteLine($"암시적 형식 변환 = {d}");

            //d = 12.34;
            //i = (int)d; // (int) < 정수형 데이터만 저장됨
            //Console.WriteLine($"명시적 형식 변환 = {i}");

            //string s = "";
            //s = Convert.ToString(d); //숫자를 문자열로 변환
            //Console.WriteLine($"형식 변환 = {s}");

            //Console.Write("실수를 입력하세요 : ");
            //string input = Console.ReadLine();
            //double PI = Convert.ToDouble(input);
            //double PI2 = double.Parse(input);
            //Console.WriteLine(PI);
            //Console.WriteLine(PI2);

            //Console.Write("문자를 입력하세요 : ");
            //string input = Console.ReadLine();
            //char c = Convert.ToChar(input);
            //Console.WriteLine(c);

            //char a = 'a';
            //char b = 'b';
            //char c = '가', d = '나';
            //Console.WriteLine($"{a}, {b}, {c}, {d}");
            //int num = 256;
            //char f = (char)num;
            //Console.WriteLine(f); //오버플로우

            #endregion
            #region 진수 다루기

            //byte a = 240; //10진수 리터럴
            //WriteLine($"a = {a}");
            //byte b = 0b1111_0000; //2진수 리터럴
            //WriteLine($"b = {b}");
            //byte c = 0XF0; //16진수 리터럴
            //WriteLine($"c = {c}");
            //uint d = 0x1234_abcd; //16진수 리터럴
            //WriteLine($"d = {d}");


            //int a = 10;
            //Console.WriteLine("2진수  " + a + " = " + Convert.ToString(a, 2).PadLeft(8, '0')); //a를 2진수로 표현하되, 8자리로 하고 앞은 모두 0으로 채움
            //Console.WriteLine("8진수  " + a + " = " + Convert.ToString(a, 8));
            //Console.WriteLine("16진수 " + a + " = " + Convert.ToString(a, 16));

            //Console.WriteLine($"10진수 10을 2진수로 변경 : {Convert.ToString(10, 2).PadLeft(8,'0')}");
            //Console.WriteLine($"2진수 1010을 10진수로 변경 : {Convert.ToInt32("1010",2)}");

            //int intnum = 10;
            //string intnum_2 = Convert.ToString(intnum); // < 문자열이 됨. 고로 계산 불가하므로 ToInt32 등으로 변환해주고 계산해야됨

            //int num = 0b0000_0101; //2진수 리터럴   b B, _는 ,처럼 구분자
            //int num2 = 0x0000_010f; //16진수 리터럴 x X
            //int num3 = num + num2; //2, 16진수 서로 계산 가능
            //Console.WriteLine("num2  = "+num);
            //Console.WriteLine("num16 = "+num2);
            //Console.WriteLine("sum   = "+num3);
            #endregion
            #region 변수 var 키워드

            //var num1 = 2;
            //var str = "hello";
            //var pi = Math.PI;
            //var ch = '나';
            //WriteLine("{0}\n{1}\n{2}\n{3}",num1,str,pi,ch);

            //var s = Console.ReadLine();     // ex) int num = int.Parse(Console.ReadLine());  var s는 readline이 string 리턴값이기에 parse할필요 x
            //var c = Convert.ToChar(Console.Read());
            //Console.WriteLine($"{s} : {s.GetType()}, {c} : {c.GetType()}");
            
            //Console.WriteLine("Press Any Key.");
            //ConsoleKeyInfo ConKeyInfo = Console.ReadKey(true); //키보드 키 값 입력 ConsoleKeyInfo는 구조체. 다음에 배움
            //Console.WriteLine("{0}", ConKeyInfo.Key); //키
            //Console.WriteLine("{0}", ConKeyInfo.KeyChar); //유니코드
            //Console.WriteLine("{0}", ConKeyInfo.Modifiers); //Ctrl, Shift, Alt 조합 확인
            //if (ConKeyInfo.Key == ConsoleKey.Q)
            //{
            //    Console.WriteLine("Q를 입력하셨네요.");
            //}
            //else if (ConKeyInfo.Key == ConsoleKey.A)
            //{
            //    Console.WriteLine("A를 입력하셨네요.");
            //}
            #endregion
            #region var, object

            //object a, b, c, d;
            //a = 123;
            //b = 3.1423124124132312412324m;
            //c = true;
            //d = "안녕";
            //WriteLine(a + "\n" + b + "\n" + c + "\n" + d);
            //// var은 값 형식으로 받지만
            //// object는 참조 형식으로 받고, 기본데이터방식, 복합데이터방식(클래스, 배열)으로도 받는다.
            //// 모든 데이터형의 조상 또는 부모로 불림.

            //int a = 123;
            //object b = (object)a;   //a에 담긴 값을 박싱(포장?)해서 힙에 저장
            //int c = (int)b;         //b에 담긴 값을 언박싱해서 스택에 저장
            //Console.WriteLine($"{a}\n{b}\n{c}");
            //object d = b;
            //Console.WriteLine($"{d}");
            ////object는 박싱 언박싱이 일어나기 때문에 var보다 느리다
            ////대규모 프로젝트에서는 object보다 var 선언하고
            ////var은 클래스 생성자에서는 쓸 수가 없기때문에
            ////메소드 안에 지역변수로 사용이 많이 된다.

            #endregion
            #region default

            //int i = default;    //숫자는 0
            //double d = default;
            //char c = default;   //char은 \0
            //string s = default; //string은 null
            //Console.WriteLine("[{0}], [{1}], [{2}], [{3}]", i, d, c, s);
            //Console.WriteLine("[{0}], [{1}], [{2}], [{3}]", i, d, c == char.MinValue, s == null);

            //int intDefault = default(int);
            //bool boolDefault = default(bool);
            //string strDefault = default(string);
            //StringBuilder sbDefault = default(StringBuilder);
            //Console.WriteLine(intDefault + "]\n" + boolDefault + "]\n" + strDefault + "]\n" + sbDefault + "]\n");

            //var t = (100, 200);
            //Console.WriteLine(t.Item1);
            //Console.WriteLine(t.Item2);
            //var (x, y) = (300, 400);
            //Console.WriteLine($"{x}, {y}");
            #endregion
            #region 연산자

            //int i = 0;
            //Console.WriteLine(i);
            //i++;                    //단항 연산자 p121
            //Console.WriteLine(i);
            //i--;                    //단항 연산자
            //Console.WriteLine(i);
            //Console.WriteLine(++i); //전위. 변수 값을 미리 증감한 후 연산 수행 ★중요★
            //Console.WriteLine(i--); //후위. 연산식을 실행한 후 변수값을 증감 ★중요★
            //Console.WriteLine(i);

            //int num1 = 10;
            //int num2 = (num1--) + 12;
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);

            //bool isCorrect = (1 > 2) ? true : false; //여기서 ?는 if문과 비슷
            //WriteLine($"{isCorrect}");

            //int a = 5, b = 3;
            //Console.WriteLine($"{a} + {b} = {a + b}");
            //Console.WriteLine($"{a} - {b} = {a - b}");
            //Console.WriteLine($"{a} * {b} = {a * b}");
            //Console.WriteLine($"{a} / {b} = {a / b}");
            //Console.WriteLine($"{a} % {b} = {a % b}");

            //int days = 28;                                      //아래에 숫자+문자 보다 문자+문자가 연산속도가 더 빠름
            //Console.WriteLine($"2월달은 {days}일입니다.");                     //숫자
            //Console.WriteLine($"2월달은 {days.ToString()}일입니다.");          //문자
            //Console.WriteLine($"2월달은 {Convert.ToString(days)}일입니다.");   //문자


            #endregion
            #region 할당 연산자, 논리 연산자

            //int a, b, result;
            //a = 20; b = 30;

            //result = a = b; Console.WriteLine(result); // b값이 a, result에 대입됨
            //result += b;    Console.WriteLine(result); // result = result + b;
            //result -= b;    Console.WriteLine(result); // result = result - b;
            //result *= b;    Console.WriteLine(result); // result = result * b;
            //result /= b;    Console.WriteLine(result); // result = result / b;
            //result %= b;    Console.WriteLine(result); // result = result % b;

            //Console.WriteLine($"True  && True  = {true && true}");
            //Console.WriteLine($"True  && False = {true && false}");
            //Console.WriteLine($"False && True  = {false && true}");
            //Console.WriteLine($"False && False = {false && false}\n");
            //Console.WriteLine($"True  || True  = {true || true}");
            //Console.WriteLine($"True  || False = {true || false}");
            //Console.WriteLine($"False || True  = {false || true}");
            //Console.WriteLine($"False || False = {false || false}\n");

            //int n1 = 10, n2 = 20;
            //Console.WriteLine($"{n1 < 11 && n2 == 20}");
            //Console.WriteLine($"{n1 > 11 && n2 == 20}");

            //double dnum1 = (double)Math.PI;
            //string result = dnum1.ToString("0.000000000000000000");
            //Console.WriteLine("결과 double  : " + result);
            //decimal dcnum1 = (decimal)Math.PI;
            //result = dcnum1.ToString("0.000000000000000000");
            //Console.WriteLine("결과 decimal : " + result);
            //float fnum1 = (float)Math.PI;
            //result = fnum1.ToString("0.000000000000000000");
            //Console.WriteLine("결과 float   : " + result);

            //Console.WriteLine("소수점 포함 실수를 2개 입력해주세요."); //공유폴더 문제3
            //Console.Write("1번째 실수 입력 : ");  double input1 = double.Parse(Console.ReadLine());
            //Console.Write("2번째 실수 입력 : ");  double input2 = double.Parse(Console.ReadLine());
            //Console.WriteLine(input1.ToString("0.0000"));
            //Console.WriteLine(input2.ToString("0.000000"));

            //float fn1 = (float)Math.PI - 0.1f;
            //float fn2 = (float)Math.PI;

            //if (fn1 >= fn2)
            //{
            //    Console.WriteLine("fn1이 fn2보다 크거나 같다.");
            //}
            //else
            //{
            //    Console.WriteLine("fn1이 fn2보다 작다.");
            //}

            //if (fn1 == (float)Math.PI - 0.1f || fn2 > (float)Math.PI)
            //{
            //    Console.WriteLine("OR 실행");
            //}

            #endregion
            #region 실수 문자열 출력 소수점 개수

            //double pi = Math.PI;
            //string result = pi.ToString("n3");      //소수점 n뒤의 숫자만큼 나타낼수있음. 대소문자 구분안함
            //WriteLine($"결과 : {pi}, {result}");
            //result = String.Format("{0:n2}", pi);   //소수점 n뒤의 숫자만큼 나타낼수있음. 대소문자 구분안함
            //WriteLine($"결과 : {pi}, {result}");



            #endregion

            
            
        }
    }
}
