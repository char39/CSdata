//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////this 생성자

//namespace Csharp07_03NETCORE
//{
//    class YourClass
//    {
//        // this 생성자 없이 생성자를 만듦
//        public int a, b, c;
//        public YourClass()
//        {
//            this.a = 5425;
//        }
//        public YourClass(int b) : this()
//        {
//            this.b = b;
//        }
//        public YourClass(int b, int c) : this(b)
//        {
//            this.c = c;
//        }
//    }
//    class MyClass
//    {
//        // this 생성자를 사용하여 생성자를 만듦
//        public int a, b, c;
//        public MyClass()
//        {
//            this.a = 5425;
//        }
//        public MyClass(int b) : this()
//        {
//            this.b = b;
//        }
//        public MyClass(int b, int c) : this(b)
//        {
//            this.c = c;
//        }
//    }
//    internal class MainApp5
//    {
//        public static void Main(String[] args)
//        {
//            //YourClass yourClass = new YourClass();
//            //YourClass yourClass1 = new YourClass(10);
//            YourClass yourClass = new YourClass(10, 20);
//            Console.WriteLine($"{yourClass.a} {yourClass.b} {yourClass.c}");

//            MyClass myClass = new MyClass(50, 70);
//            Console.WriteLine($"{myClass.a} {myClass.b} {myClass.c}");
//        }
//    }
//}
