using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Csharp08_22NETCORE
{
    /*  ref
        internal class Program
        {
            static void Main()
            {
                DateTime dt;
                if (DateTime.TryParse("2024-01-01", out dt))
                    Console.WriteLine(dt);
                else
                    Console.WriteLine("변환불가");

                if (DateTime.TryParse("2024-01-01", out var mydate))
                    Console.WriteLine(mydate);

                Console.WriteLine(SumAll(3, 5));
                Console.WriteLine(SumAll(3, 5, 7));
                Console.WriteLine(SumAll(3, 5, 7, 9));
            }
            static int SumAll(params int[] numbers)
            {
                int sum = 0;
                foreach (int num in numbers)
                    sum += num;
                return sum;
            }
        } */
    /*  프로퍼티 등
        public class Pro
        {
            private string color;
            public Pro() { this.color = "Black"; }
            public void SetColor(string color) { this.color = color; }
            public string GetColor() { return color; }
            public string Color
            {
                get {return color;}
                set {color = value;}
            }
            public string Make
            {
                get {return "한국자동차";}
            }

            private string _Type;
            public string Type
            {
                set {_Type = value;}
            }
            public string Name{get;set;}
        }

        public class Program
        {
            static void Main()
            {
                Pro pro = new();
                pro.SetColor("Red");
                Console.WriteLine(pro.GetColor());

                Pro pro1 = new();
                pro.Color = "White";
                Console.WriteLine(pro1.Color);

                Pro pro2 = new();
                Console.WriteLine(pro2.Make);

                Pro pro3 = new();
                pro3.Type = "중형";

                Pro pro4 = new();
                pro4.Name = "좋은차";
                Console.WriteLine(pro4.Name);
            }
        } */
    /*  프로퍼티
    // 이름 : ㅁㅁㅁ   나이 : 21 로 출력해보시오
    public class Person
    {
        private int _BirthYear; // 생년월일
        public string Name { get; set; } // 이름 

        public int BirthYear
        {
            set
            {
                if (value >= 1900)
                    _BirthYear = value;
                else
                    _BirthYear = 0;
            }
        }
        public int Age
        {
            get { return DateTime.Now.Year - _BirthYear; }
        }

        public Person(string name) => Name = name; // Name 속성에 넘겨온 name 매개변수 값 저장
    }

    public class Program
    {
        static void Main()
        {
            Person person = new("박박박") { BirthYear = 2003 };

            Console.WriteLine($"이름 : {person.Name}   나이 : {person.Age}");
        }
    } */
    /*  프로퍼티 람다식으로 축약
    class Counter
    {
        private int count = default;
        public int Count
        {
            get => count;
            set => count = value;
        }
        public void IncreaseCount() => Count++;
    }

    class ArrowDemo
    {
        static Counter counter;
        static void Main()
        {
            counter = new();
            counter.IncreaseCount();
            Console.WriteLine($"카운트 : {counter.Count}");
        }
    } */
    /*  개체 이니셜라이저
    class Person
    {
        public string? Name { get; set; }
        public string? City { get; set; }
    }

    class Course
    {
        public int Id { get; set; }
        public string? Title { get; set; }
    }

    internal class Program
    {
        static void Main()
        {
            Person person = new Person { Name = "C#", City = "Seoul" };
            Console.WriteLine($"{person.Name} : {person.City}");

            Course course = new();
            course.Id = 1; course.Title = "C#";
            Console.WriteLine($"{course.Id} - {course.Title}");
        }
    } */
    /*  프로퍼티, 생성자, 개체 이니셜라이저
    public class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public Person(){}
        public Person(string name, int age) { Name = name; Age = age; }
    }

    internal class Program
    {
        static void Main()
        {
            Person pp = new();                  // 프로퍼티 사용
            pp.Name = "이세영";
            pp.Age = 100;

            Person pc = new("백승수", 21);          // 생성자 사용

            Person pi = new() { Name = "권경민", Age = 30 };        // 개체 이니셜라이저 사용
            Console.WriteLine(pi.Name + ", " + pi.Age);
        }
    } */

    internal class Program
    {
        static void Main()
        {
            var duck = new { Id = 1, Name = "Duck 1" };
            Console.WriteLine($"{duck.Id} - {duck.Name}");

            duck = new { Id = 2, Name = "Duck 2" };
            Console.WriteLine($"{duck.Id} - {duck.Name}");

            //duck = new { Id = 3.14f, Name = "Duck 3" };

            //duck = new { Id = 3 };

            //duck = new { Id = 3, Name = "Duck 3", Email = "Email 3" };

            duck = new { Id = 3, Name = "Duck 3"};
            Console.WriteLine($"{duck.Id} - {duck.Name}");
        }
    }
}
