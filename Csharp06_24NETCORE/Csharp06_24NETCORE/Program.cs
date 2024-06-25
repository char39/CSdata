//using Major;
//using MaxMin;

namespace Csharp06_24NETCORE
{
    internal class Program
    {
        //  XML 문서 주석을 사용하여 함수 설명 작성하기 [아래]

        /// <summary>
        /// 두 수를 더하여 그 결과값을 반환시켜 주는 함수
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a+b</returns>
        static int AddNumbers(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// 절대값을 반환
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static int Abs(int num)
        {
            return (num < 0) ? num * (-1) : num;
        }

        static void Main(string[] args)
        {
            #region math
            //Mathematics.Total = 0;

            //Mathematics math = new Mathematics(); //멤버 함수를 동적 할당하여 호출하기 위함.
            //math.Sum = 0;       //멤버 변수
            //math.Average = 0f;  //멤버 변수
            //math.Sum = 1 + 10;

            //Console.WriteLine(Mathematics.SquareFunction(20.0f)); //정적 할당된 전역 함수는 어디서든 클래스.메소드로 불러올 수 있다.
            //Console.WriteLine(math.SquareFunction(10));
            #endregion
            #region MaxMinFunction
            //MaxMinFunc M_Func = new MaxMinFunc();
            //int mainMax = M_Func.Max(3, -5);
            //int mainMin = M_Func.Min(3, -5);
            //Console.WriteLine($"Max = {mainMax}\nMin = {mainMin}");


            #endregion
            #region

            int a = 3, b = 5, c = AddNumbers(3, 5);
            Abs(5);


            #endregion


        }
    }
}
