using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YonIT;

namespace Csharp06_25NETCORE
{
    internal class MainApp
    {
        static void Recursion(int num)
        {
            //재귀함수
            if (num <= 0) return;
            Console.WriteLine($"재귀함수 호출. {num}");
            Recursion(num - 1);
        }
        static decimal Factorial(int n)
        {
            if (n == 0) return 1;
            else return n * Factorial(n - 1);
        }
        static int MyPower(int num, int power)
        {
            if (power == 0 ) return 1;
            return num * MyPower(num, power - 1);
        }
        public static void Main(string[] args)
        {
            #region 정적 동적 차이
            //Class_Calculator.Average = 0f;
            ////클래스명.정적변수명
            //Class_Calculator cal = new Class_Calculator();      //객체 생성
            //cal.Sum = 0;    //멤버변수. 바로 윗줄에서 동적할당

            //Class_Calculator cal2 = new Class_Calculator();     //객체 생성
            //cal2.Sum = 0;   //멤버변수.
            //// GMS에서 전역변수와는 다르게 지역변수는 각 오브젝트에서 같은 이름으로 사용해도 괜찮듯이
            //// 객체도 이와 비슷한 느낌

            //Console.WriteLine(cal.Add(2, 5));
            //Console.WriteLine(cal2.Add(2, 6));
            //Console.WriteLine(Class_Calculator.Divide(30, 3));
            #endregion
            #region 재귀함수
            //Recursion(5);

            //for (int i = 1; i <= 15; i++)
            //    Console.WriteLine($"{i}! = {Factorial(i)}");
            #endregion
            #region 재귀를 이용한 n의 m승 구하기

            //Console.WriteLine(MyPower(2, 10));

            #endregion


        }
    }
}
