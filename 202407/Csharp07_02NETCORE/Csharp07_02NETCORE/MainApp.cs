//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//// 생성자, 소멸자가 있다. 객체생성은 생성자가 담당, 객체소멸은 소멸자가 담당
//// 클래스명이랑 같다, 반환형이 없다. 생성자는 객체 생성시 자동 호출된다.

//namespace Csharp07_02NETCORE
//{
//    // internal은 같은 프로그램 내에서만 접근 가능
//    // 구조체는 값 형식, 클래스는 참조 형식
//    // object oriented programming (OOP) 객체지향 프로그래밍
//    // : 코드를 이용하여 객체를 만들고, 객체 간의 상호작용을 통해 로직을 구성하는 프로그래밍 방법
//    // 객체 : 속성과 기능(메서드)을 가지는 독립적인 단위, 클래스의 인스턴스
//    // 클래스 : 객체를 만들기 위한 틀


//    public class Cat
//    {
//        public string Name;     // 멤버 필드
//        public string Color;    // 멤버 필드
//        public Cat()            // 매개변수가 없는 생성자. 즉 void Cat()과 같음
//        {
//            Name = "";
//            Color = "";
//        }
//        /*
//        public Cat(string _Name, string _Color) // 매개변수가 있는 생성자
//        {
//            Name = _Name;
//            Color = _Color;
//        }
//        */
//        public Cat(string Name, string Color)
//        {
//            this.Name = Name;       // this는 멤버 필드를 가리킴
//            this.Color = Color;
//        }
//        ~Cat()      // 소멸자. 객체가 소멸될 때 자동 호출. 같은 클래스에서 하나만 존재
//        {           // 소멸자는 매개변수를 가질 수 없다.
//            Console.WriteLine($"{Name} : 잘가");
//        }
//        public void Meow()      // 멤버 메서드
//        {
//            Console.WriteLine($"{Name} : 야옹");
//        }
//        #region 정적, 멤버관련 메서드 오류
//        //  아래의 코드는 오류가 발생하는데,
//        //  이유는 정적 메서드에서는 인스턴스 멤버에 접근할 수 없기 때문
//        //public static void Meow2() // 정적 메서드
//        //{
//        //    Console.WriteLine($"{Name} : 야옹");
//        //}
//        #endregion
//    }
//    internal class MainApp
//    {
//        public static void Main()
//        {
//            //Cat cat = new Cat();    // Cat 클래스의 인스턴스 생성
//            //cat.Color = "하얀색";     // 인스턴스의 멤버 필드에 값 할당
//            //cat.Name = "네로";        // 인스턴스의 멤버 필드에 값 할당
//            //cat.Meow();              // 인스턴스의 메서드 호출
//            //Console.WriteLine($"{cat.Name} : {cat.Color}");
//            //Cat cat2 = new Cat();    // 매개변수가 없는 생성자 호출
//            //cat2.Meow();
//            Cat cat3 = new Cat("망고", "핑크"); // 매개변수가 있는 생성자 호출. 생성과 동시에 초기화
//            cat3.Meow();
//            Console.WriteLine($"{cat3.Name} : {cat3.Color}");
//            Cat nero = new Cat("네로", "검정");
//            nero.Meow();
//            Console.WriteLine($"{nero.Name} : {nero.Color}");
            
//        }
//    }
//}
