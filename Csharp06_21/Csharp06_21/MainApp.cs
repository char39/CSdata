//using System;
//using static System.Console;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Csharp06_21
//{
//    internal class MainApp
//    {
//        static void Function1()                  //함수 이름
//        {
//            Console.WriteLine("어서오세요.");    //함수 실행 내용
//        }
//        static int Add(int n1, int n2)
//        {
//            // 리턴은 2가지 뜻이 있다.
//            // 1. 함수(메서드)를 빠져나간다.
//            // 2. 빠져나가면서 값을 반환한다.
//            return n1 + n2;
//        }
//        static int Minus(int n1, int n2)
//        {
//            return n1 - n2;
//        }
//        static string Method()
//        {
//            string str = Console.ReadLine();
//            return str;
//        }
//        static int Max(int x,int y)
//        {
//            return (x > y) ? x : y;
//        }
//        static int Min(int x,int y)
//        {
//            if (x < y)
//                return x;
//            else
//                return y;
//        }
        



//        public static void Main(string[] args)   // args < 매개변수 : 외부로 부터 값을 전달 받아온다.
//        {
//            #region 매개변수 cmd 활용
//            ////cmd에서 경로를 bin\debug\실행파일 aaa 작성해보자
//            //if (args.Length == 0)
//            //{
//            //    Console.WriteLine("사용법 : Csharp06_21.exe<박성순>");
//            //    return; //함수에서 이 시점에 빠져나감.
//            //}
//            //Console.WriteLine("Hello {0}", args[0]);
//            #endregion
//            #region 함수 [하나의 함수엔 한가지의 기능만 넣는게 중요]

//            //Function1();    // 함수 호출
//            //int result = Add(1, 2); // < 인자 1, 2를 Add 함수에 전달한다.
//            //Console.WriteLine(result);
//            //int result = Minus(1, 2);
//            //Console.WriteLine(result);
//            //Console.Write("이름을 입력하세요. : ");
//            //Console.WriteLine(Method());
            



//            #endregion

//        }
//    }
//}
