using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Csharp06_26NETCORE
//{
//    internal class Global_var
//    {
//        #region 전역변수, 지역변수
//        //static string message = "전역변수";

//        //static void ShowMessage()
//        //{
//        //    string message = "지역변수";
//        //    Console.WriteLine(message);
//        //}
//        //static void ShowMessageGlobal()
//        //{ 
//        //    string message = "지역변수";
//        //    Console.WriteLine(message);
//        //    Console.WriteLine(Global_var.message);
//        //    //함수에 동일한 변수명인 지역변수가 있으면 지역변수가 우선됨.
//        //    //이때 전역변수를 사용하려면 클래스.변수명을 입력해야 사용가능
//        //}
//        //static void Main(string[] args)
//        //{
//        //    ShowMessage();
//        //    ShowMessageGlobal();
//        //}
//        #endregion
//        #region 로컬 함수
//        //로컬 함수 : 메서드(함수)내에서만 사용되는 또 다른 함수
//        //클래스의 멤버가 아니기 때문에 메서드가 아니라 함수라 부른다.
//        //쓰는 이유는 메서드 밖에서 다시 사용 할 일 없는 반복적인 작업을
//        //하나의 이름으로 묶어 놓을때 적합.
//        //static void Main(string[] args)
//        //{

//        //    void Display(string text)
//        //    {
//        //        Console.WriteLine(text);
//        //    }
//        //    Display("로컬 함수");

//        //}
//        #endregion
//        #region 로컬 함수 만들어보기

//        //static void Main(string[] args)
//        //{
//        //    int Add(int a, int b) => a + b;
//        //    decimal Subtract(decimal a, decimal b) => a - b;

//        //    Console.WriteLine($"3 + 5 = {Add(3, 5)}");
//        //    Console.WriteLine($"34.56 - 12.34 = {Subtract(34.56m, 12.34m)}");

//        //}
//        #endregion
//        #region cmd Args문자열 출력
//        //static void Main(string[] args)
//        //{
//        //    //foreach (var arg in args)
//        //    //    Console.WriteLine(arg);
//        //    int first = Int32.Parse(args[0]);
//        //    int second = Convert.ToInt32(args[1]);
//        //    Console.WriteLine(first + second);
//        //}

//        #endregion
//    }
//}
