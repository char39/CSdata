using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Major
{
    public class Mathematics
    {
        public int Sum;                 //멤버 변수 O
        public float Average = 0f;      //멤버 변수 O
        public static int Total = 0;    //멤버 변수 X. 차이점 [static]. 쉽게 말해서 전역 변수(global같은 느낌)
        public int SquareFunction(int x)
        {
            int r = x * x;
            return r;
        }

        // static 미리 할당된 메서드(함수)는 멤버 함수가 아님.

        // 함수 오버로드[클래스 하나에 ((매개변수))를 다르게 하여(자료형이 달라도 ok) 이름이 동일한 함수 여러 개를 정의할 수 있는데,  ]
        //              [이를 함수 오버로드라고 한다. 여러 번 정의한다는 의미. (C는 오류남 C++부터 가능)                              ]
        public static float SquareFunction(float x, float y)
        {
            float r = x * y;
            return r;
        }

        public static float SquareFunction(float x)
        {
            float r = x * x;
            return r;
        }
    }
    public class English
    {

    }

}
