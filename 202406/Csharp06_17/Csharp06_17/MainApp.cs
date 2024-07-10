//using System;
//using static System.Console;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Net;

//namespace Csharp06_17
//{
//    internal class MainApp
//    {
//        public static void Main(string[] args)
//        {
//            #region 정수 데이터 최대값
//            //WriteLine($"sbyte.Max = {sbyte.MaxValue}\nsbyte.Min = {sbyte.MinValue}\n");
//            //WriteLine($"short.Max = {short.MaxValue}\nshort.Min = {short.MinValue}\n");
//            //WriteLine($"Int.Max = {int.MaxValue}\nInt.Min = {int.MinValue}\n");
//            //WriteLine($"long.Max = {long.MaxValue}\nlong.Min = {long.MinValue}\n");

//            //WriteLine($"byte.Max = {byte.MaxValue}\nbyte.Min = {byte.MinValue}\n");
//            //WriteLine($"ushort.Max = {ushort.MaxValue}\nushort.Min = {ushort.MinValue}\n");
//            //WriteLine($"uInt.Max = {uint.MaxValue}\nuInt.Min = {uint.MinValue}\n");
//            //WriteLine($"ulong.Max = {ulong.MaxValue}\nulong.Min = {ulong.MinValue}\n");
//            #endregion
//            #region 숫자 구분자, char string 차이
//            //int number = 1_000_000; //숫자 구분자를 사용하여 가독성 향상에 도움됨. 다만 출력시 _는 생략. C,C++는 불가
//            //Console.WriteLine(number);

//            //char ch = 'a'; //정수형 데이터 이지만 문자 하나표현 할때 사용, 홑따옴표(작은따옴표)를 쓴다.
//            //WriteLine(ch);
//            //string str = "welcome";
//            //WriteLine(str);

//            #endregion
//            #region Null 가능 형식, string @기호로 여러줄 문자열 저장
//            //null 비어있는

//            //int x = null; //에러가 나는게 맞음.
//            //int? x = null; /*  ?는 int에서 null을 허용한다는 의미.  */ Console.WriteLine(x); //보통 값을 미리 정하지 않을때, 값을 비워둔 상태로 초기화함.
//            //double? y = null; /*  ?는 int에서 null을 허용한다는 의미.  */ Console.WriteLine(y);

//            //string multi = @"
//            //안녕하세요.\n
//            //반갑습니다.
//            //";          // @는 문자열 그대로 저장 ex) 디렉토리 링크같은것을 작성할때 사용. C:\folder 등
//            //Console.WriteLine(multi);



//            #endregion
//            #region 문자열 보간법
//            //string name = "C#";
//            //string version = "8.0";
//            //Console.WriteLine("{0} {1}", name, version);
//            //string result = String.Format("{0} {1}", name, version);
//            //Console.WriteLine(result);
//            //Console.WriteLine($"{name} {version}");
//            #endregion
//            #region 논리 데이터 형식 bool
//            //bool bln = true;
//            //Console.WriteLine(bln);
//            //bool isFalse = false;
//            //Console.WriteLine(isFalse);
//            //bln = !bln; // 토글을 만들때 사용
//            //Console.WriteLine(bln);

//            //int n1 = 20, n2 = 20, n3 = 30, n4 = 50;
//            //bool isCorrect = n1 == n2;
//            //Console.WriteLine(isCorrect);
//            //isCorrect = n3 != n4;
//            //Console.WriteLine(isCorrect);

//            #endregion
//            #region 상수
//            //const double PI = Math.PI; //상수 이름은 대문자가 관례
//            //const string SITE_NAME = ".NET Korea";

//            ////PI = 2; 상수라 변경 불가

//            //Console.WriteLine(PI);
//            //Console.WriteLine(SITE_NAME);
//            #endregion
//            #region .NET 데이터 형식, Wrapper 형식
//            //Char c = 'A';
//            //String s = "Hello";
//            //Boolean b = true;
//            //Console.WriteLine($"{c}, {s}, {b}");

//            //int number1 = 1234;                             //기본 형식
//            //Int32 number2 = 1234;                           //닷넷 형식
//            //Console.WriteLine($"{number1}, {number2}");

//            //string str1 = "Hello";                          //기본 형식 s소문자
//            //String str2 = "Hello";                          //닷넷 형식 S대문자
//            //Console.WriteLine($"{str1}, {str2}");

//            //Console.Write($"{DateTime.Now.Year}.{DateTime.Now.Month}.{DateTime.Now.Day}\t");
//            //Console.WriteLine($"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}:{DateTime.Now.Millisecond}");
//            //for (int i = 0; i < 100000; i++)
//            //{
//            //    Console.Write($"{DateTime.Now.Year}.{DateTime.Now.Month}.{DateTime.Now.Day}\t");
//            //    Console.WriteLine($"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}:{DateTime.Now.Millisecond}");

//            //}
//            #endregion
//            #region Console 입력 관련 메서드
//            //Console.WriteLine(Console.ReadLine());
//            //Console.Write("이름을 입력해주세요. => ");
//            //string name = Console.ReadLine();
//            //Console.WriteLine($"안녕하세요. {name}님. 반갑습니다.");

            

//            #endregion
//        }
//    }
//}
