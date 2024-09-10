using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp09_09NETCORE
{
    /*  함수형 프로그래밍 방식 : 메서드 체이닝
    internal class Program
    {
        public readonly int x;
        public readonly int y;

        public Program(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Program MoveBy(int dx, int dy) => new(x + dx, y + dy);

        static void Main()
        {
            var p = new Program(0, 0).MoveBy(10, 10).MoveBy(20, 20).MoveBy(30, 30);
            Console.WriteLine(p.x);
            Console.WriteLine(p.y);
        }
    }*/
    /*  불변 형식
    public class Circle
    {
        public int Radius { get; private set; } = 0;
        public Circle(int radius) => Radius = radius;              // 생성자
        public Circle MakeNew(int radius) => new Circle(radius);   // 새로운 객체 생성
    }

    internal class Program
    {
        static void Main()
        {
            Circle circle = new(10);
            Circle newCircle = circle.MakeNew(20);
            Console.WriteLine(circle.Radius + " - " + circle.GetHashCode());
            Console.WriteLine(newCircle.Radius + " - " + newCircle.GetHashCode());
        }
    }*/
    /*  부모클래스 형식 변수에 자식클래스 개체 할당
    public class Developer
    {
        public override string ToString()
        {
            return "개발자";
        }
    }

    public class WebDeveloper : Developer
    {
        public override string ToString()
        {
            return "웹 개발자";
        }
    }

    public class MobileDeveloper : Developer
    {
        public override string ToString()
        {
            return "모바일 개발자";
        }
    }

    internal class Program
    {
        static void Main()
        {
            Developer dev = new WebDeveloper();
            Console.WriteLine(dev);
            Developer mobDev = new MobileDeveloper();
            Console.WriteLine(mobDev);
        }
    }*/
    /*  상속관계에서 부모클래스 형식 변수에 자식클래스 개체 할당
    class Vehicle{}
    class Car : Vehicle{}
    class Airplane : Vehicle{}

    internal class Program
    {
        static void Main()
        {
            Vehicle vehicle = new();
            Vehicle car = new Car();
            Vehicle airplane = new Airplane();
            Console.WriteLine();
            Console.WriteLine($"{vehicle}, {car}, {airplane}");
            Console.WriteLine();
        }
    }*/
    /*  상속관계에서 부모클래스의 메서드 호출
    public class ParentClass : Object
    {
        protected void Print1() => Console.WriteLine("부모 클래스의 Print1() 메서드");
    }
    public class ChildClass : ParentClass
    {
        public void Print2() => base.Print1();
    }

    internal class Program : Object
    {
        static void Main()
        {
            ParentClass p = new();
            Console.WriteLine(p.ToString());
            ChildClass c = new();
            c.Print2();
        }
    }*/
    /*  상속관계에서 부모클래스의 생성자 호출
    public class Car
    {
        private string name;
        public Car(string name) => this.name = name;
        public void Run() => Console.WriteLine($"{this.name}이(가) 달립니다.");
    }
    public class My : Car
    {
        public My() : this("나의 자동차") { }
        public My(string name) : base(name) { }
    }
    public class Your : Car
    {
        public Your() : base("너의 자동차") { }
    }

    internal class Program
    {
        static void Main()
        {
            new My().Run();
            new My("나의 끝내주는 자동차").Run();
            new Your().Run();
        }
    }*/
    /*  상속관계에서 부모클래스의 메서드 오버라이딩
    class Animal
    {
        public void Eat() => Console.WriteLine("밥을 먹습니다.");
    }
    sealed class Cat : Animal { }
    //class Tiger : Cat { } // 에러

    internal class Program
    {
        static void Main()
        {
            Cat cat = new();
            cat.Eat();
        }
    }*/


    public interface IPlus { int Plus(int a, int b); }
    public interface IMinus { int Minus(int a, int b); }
    public interface IMultiply { int Multiply(int a, int b); }
    public interface IDivide { int Divide(int a, int b); }
    public class Calculator : IPlus, IMinus, IMultiply, IDivide
    {
        public int Plus(int a, int b) => a + b;
        public int Minus(int a, int b) => a - b;
        public int Multiply(int a, int b) => a * b;
        public int Divide(int a, int b) => a / b;
    }

    public class Program
    {
        static void Main()
        {
            Calculator calc = new();
            Console.WriteLine(calc.Plus(10, 5));
            Console.WriteLine(calc.Minus(10, 5));
            Console.WriteLine(calc.Multiply(10, 5));
            Console.WriteLine(calc.Divide(10, 5));
        }
    }




}