using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YonIT
{
    public class Class_Calculator
    {
        public int Sum;             //동적변수, 멤버변수
        public static float Average;//정적변수
        public int Add(int x, int y)//동적함수, 멤버함수
        {
            return x + y;
        }
        public static int Divide(int x, int y)//정적함수
        {
            return x / y;
        }
    }
}
