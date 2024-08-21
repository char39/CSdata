using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Csharp08_20NETCORE
{
    /*  1. 여러 클래스 연습 (별거없음)
    public class ClassOne
    {
        public static void Hi()
        {
            Console.WriteLine("Hi?");
        }
    }

    public class ClassTwo
    {
        public static void Hi()
        {
            Console.WriteLine("Hi!");
        }
        public void Hello()
        {
            Console.WriteLine("Hello");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ClassOne.Hi();
            ClassTwo.Hi();
            ClassTwo classTwo = new();
            classTwo.Hello();
        }
    } */
    /*  2. 필드 초기화
    public class Say
    {
        private string message = "안녕하세요.";
        
        public void Hi()
        {
            this.message = "반갑습니다.";
            Console.WriteLine(this.message);
        }
    }

    public class Program
    {
        static void Main()
        {
            Say say = new();
            say.Hi();

        }
    } */


    class Person
    {
        // 생성자를 이용해서 초기화, 호출
        private string name;
        public Person()
        {
            name = "홍길동";
        }
        public Person(string n)
        {
            name = n;
        }
        public string GetName()
        {
            return name;
        }
    }

    class Human
    {
        // 프로퍼티를 이용
        private string? name = null;
        public string? Name
        {
            get { return name; }
            set { name = value; }
        }

    }

    internal class Program
    {
        static void Main()
        {
            Person person = new();
            Console.WriteLine(person.GetName());

            Person person2 = new("이순신");
            Console.WriteLine(person2.GetName());

            Human human = new();
            human.Name = "유관순";
            Console.WriteLine(human.Name);

            human.Name = "윤봉길";
            Console.WriteLine(human.Name);
        }
    }



}
