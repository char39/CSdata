//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Csharp07_03NETCORE
//{
//    class MyClass
//    {
//        public int a;   // 인스턴스 필드
//        public int b;

//    }
//    class YourClass
//    {
//        public static int a;    // 정적 필드
//        public static int b;
//    }
//    internal class MainApp
//    {
//        public static void Main()
//        {
//            MyClass myclass = new MyClass();
//            myclass.a = 10;
//            myclass.b = 20;
//            YourClass.a = 30;
//            YourClass.b = 40;
//            // 정적 필드를 만들어서 얻는 이득은 무엇?
//            // 정적 필드는 프로그램 전역에서 단 하나만 존재함.
//            // 프로그램 전역에 공유해야 되는 변수가 있다면 정적 필드를 사용하면 된다.
//        }
//    }
//}
