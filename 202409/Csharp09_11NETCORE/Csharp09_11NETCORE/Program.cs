using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp09_11NETCORE
{
    /*  public class ParentClass
        {
            public virtual void Hi1() => Console.WriteLine("기본 : 안녕하세요.");
            public void Hi2() => Console.WriteLine("기본 : 반갑습니다.");
            public void Hi3() => Console.WriteLine("기본 : 또 만나요.");
        }
        public class ChildClass : ParentClass
        {
            public override void Hi1() => Console.WriteLine("파생 : 안녕하세요.");
            public new void Hi2() => Console.WriteLine("파생 : 반갑습니다.");
            public new void Hi3() => base.Hi3();
        }

        class Parent
        {
            public void Say() => Console.WriteLine("부모가 말하다.");
            public void Hi() => Console.WriteLine("부모가 인사하다.");
            public virtual void Walk() => Console.WriteLine("부모가 걷다.");
        }

        class Child : Parent
        {
            public void Say() => Console.WriteLine("자식이 말하다.");
            public new void Hi() => Console.WriteLine("자식이 인사하다.");
            public override void Walk() => Console.WriteLine("자식이 걷다.");
        }

        class MethodOverridePracice
        {
            static void Main()
            {
                ChildClass child = new ChildClass();
                child.Hi1();
                child.Hi2();
                child.Hi3();

                Child baby = new Child();
                baby.Say();
                baby.Hi();
                baby.Walk();
            }
        } */
    /*  internal class Program
        {
            // static int BinarySearch(List<int> list, int target)
            // {
            //     int first = 0;
            //     int last = list.Count - 1;
            //     int mid;

            //     while (first <= last)
            //     {
            //         mid = (first + last) / 2;
            //         if (list[mid] == target)
            //             return mid;
            //         else
            //         {
            //             if (list[mid] > target)
            //                 last = mid - 1;
            //             else
            //                 first = mid + 1;
            //         }
            //     }
            //     return -1;
            // }
            static int BinarySearch(List<int> list, int first, int last, int target)
            {
                if (first > last)
                    return -1;
                int mid = (first + last) / 2;
                if (list[mid] == target)
                    return mid;
                else if (target <= list[mid])
                    return BinarySearch(list, first, mid - 1, target);
                else
                    return BinarySearch(list, mid + 1, last, target);
            }

            static void Main()
            {
                List<int> arr = [1, 3, 5, 7, 9, 11, 35, 36, 93];
                int index;
                // index = BinarySearch(arr, 7);
                // if (index == -1)
                //     Console.WriteLine("탐색 실패");
                // else
                //     Console.WriteLine($"타겟 저장 인덱스 : {index}");

                // index = BinarySearch(arr, 35);
                // if (index == -1)
                //     Console.WriteLine("탐색 실패");
                // else
                //     Console.WriteLine($"타겟 저장 인덱스 : {index}");

                index = BinarySearch(arr, 0, arr.Count - 1, 7);
                if (index == -1)
                    Console.WriteLine("탐색 실패");
                else
                    Console.WriteLine($"타겟 저장 인덱스 : {index}");



            }
        } */
    /*  문제 1.     1부터 100 사이의 값을 랜덤하게 불러와서 list나 배열에 저장한다.
    //  버블 정렬로 오름차순으로 만든 후, 이진탐색 알고리즘을 이용하여 특정 값의 인덱스를 반환하여 출력한다.
    internal class Program
    {
        static void Bubble(List<int> data, Func<int, int, int> condition)
        {
            int temp;
            for (int i = 0; i < data.Count - 1; i++)
            {
                for (int j = 0; j < data.Count - (i + 1); j++)
                {
                    if (condition(data[j], data[j + 1]) > 0)
                    {
                        temp = data[j + 1];
                        data[j + 1] = data[j];
                        data[j] = temp;
                    }
                }
            }
        }
        static int BinarySearch(List<int> list, int target)
        {
            int first = 0;
            int last = list.Count - 1;
            int mid;

            while (first <= last)
            {
                mid = (first + last) / 2;
                if (list[mid] == target)
                    return mid;
                else
                {
                    if (list[mid] > target)
                        last = mid - 1;
                    else
                        first = mid + 1;
                }
            }
            return -1;
        }
        static void Main()
        {
            Func<int, int, int> Ascend = delegate (int x, int y)
            {
                if (x > y) return 1;
                else if (x == y) return 0;
                else return -1;
            };
            Func<int, int, int> Descend = delegate (int x, int y)
            {
                if (x < y) return 1;
                else if (x == y) return 0;
                else return -1;
            };

            List<int> arr = [];
            Random rand = new();
            for (int i = 0; i < 50; i++)
                arr.Add(rand.Next(1, 101));
            Console.WriteLine("------------------------랜덤 값 생성");
            foreach (var item in arr)
                Console.Write($"{item} ");
            Console.WriteLine();

            Bubble(arr, Ascend);
            Console.WriteLine("------------------------오름차순 정렬 후");
            foreach (var item in arr)
                Console.Write($"{item} ");
            Console.WriteLine();

            int index = BinarySearch(arr, 7);
            PrintBinaryIndex(index, 7);
            index = BinarySearch(arr, 35);
            PrintBinaryIndex(index, 35);
            index = BinarySearch(arr, 100);
            PrintBinaryIndex(index, 100);

            static void PrintBinaryIndex(int index, int target)
            {
                if (index == -1)
                    Console.WriteLine($"({target}) 탐색 실패");
                else
                    Console.WriteLine($"({target}) 타겟 저장 인덱스 : {index}");
            }
        }
    } */
    /*  문제 2.     인덱서를 채워 넣으시오. 아래는 실행 예시
    // Array Resized : 4
    // Array Resized : 5
    // 0,1,2,3,4
    class MyList
    {
        private int[] array;

        public MyList()
        {
            array = new int[3];
        }

        public int this[int index]
        {
            get
            {
                if (index >= array.Length)
                    throw new IndexOutOfRangeException();
                else
                    return array[index];
            }
            set
            {
                if (index >= array.Length)
                {
                    Console.WriteLine($"Array Resized : {index + 1}");
                    Array.Resize(ref array, index + 1);
                }
                array[index] = value;
            }
        }

        public int Length
        {
            get { return array.Length; }
        }
    }

    internal class Program
    {
        static void Main()
        {
            MyList list = new MyList();
            for (int i = 0; i < 5; i++)
                list[i] = i;

            for (int i = 0; i<list.Length; i++)
                Console.WriteLine(list[i]);
        }
    }*/
    /*  문제 3.     아래의 내용을 foreach가 가능한 객체를 만드세요.
    class MyList : IEnumerable, IEnumerator
    {
        private int[] array;
        int position = -1;

        public MyList()
        {
            array = new int[3];
        }

        public int this[int index]
        {
            get
            {
                if (index >= array.Length)
                    throw new IndexOutOfRangeException();
                else
                    return array[index];
            }
            set
            {
                if (index >= array.Length)
                {
                    Console.WriteLine($"Array Resized : {index + 1}");
                    Array.Resize(ref array, index + 1);
                }
                array[index] = value;
            }
        }

        public object Current
        {
            get
            {
                if (position == -1 || position >= array.Length)
                    throw new InvalidOperationException();
                return array[position];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            position++;
            return position < array.Length;
        }

        public void Reset()
        {
            position = -1;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            for (int i = 0; i < 5; i++)
                list[i] = i;

            foreach (int e in list)
                Console.WriteLine(e);
        }
    }*/

    //  9/12 시작

    /*  재귀함수 1
    internal class Program
    {
        public static void Recursive(int num)
        {
            if (num <= 0)
                return;
            Console.WriteLine($"Recursive Call! {num}");
            Recursive(num - 1);
        }
        static void Main()
        {
            Recursive(3);
        }
    } */
    /*  재귀함수 2 팩토리얼
    internal class Program
    {
        public static int Factorial(int num)
        {
            if (num == 0)
                return 1;
            else
                return num * Factorial(num - 1);
        }
        static void Main()
        {
            Console.WriteLine($"3! = {Factorial(3)}");
            Console.WriteLine($"4! = {Factorial(4)}");
            Console.WriteLine($"5! = {Factorial(5)}");
        }
    } */
    /*  재귀함수 3 피보나치 수열
    internal class Program
    {
        public static int Fibonacci(int num)
        {
            if (num < 2)
            {
                Console.Write($"({num})");
                return num;
            }
            else
            {
                Console.Write($"{num} ");
                return Fibonacci(num - 1) + Fibonacci(num - 2);
            }
        }
        static void Main()
        {
            //for (int i = 1; i <= 10; i++)
            //    Console.WriteLine($"Fibonacci({i}) = {Fibonacci(i)}");
            Console.WriteLine("Result : " + Fibonacci(7));
        }
    }*/

    /*  인터페이스 1
    public interface IRepository
    {
        void Get();
    }
    public class Repository : IRepository
    {
        public void Get() => Console.WriteLine("Get() 메서드를 구현해야 한다.");
    }

    public class Program
    {
        static void Main()
        {
            IRepository repository = new Repository();  // 반대는 안됨. 인터페이스는 객체 생성X, 부모를 new로 생성할 수 없음.
            repository.Get();
        }
    } */
    /*  인터페이스 2
    interface IBattery { string GetName(); }
    class Good : IBattery { public string GetName() => "Good"; }
    class Bad : IBattery { public string GetName() => "Bad"; }
    class Car
    {
        private IBattery battery;
        public Car(IBattery battery) { this.battery = battery; }
        public void Run() => Console.WriteLine($"{this.battery.GetName()}, 배터리를 장착한 자동차가 달립니다.");
    }

    internal class Program
    {
        static void Main()
        {
            var good = new Car(new Good());
            good.Run();
            new Car(new Bad()).Run();
        }
    } */
    /*  인터페이스 3 다중 상속
    interface IAnimal { void Eat(); }
    interface IDog { void Yelp(); }
    class Dog : IAnimal, IDog
    {
        public void Eat() => Console.WriteLine("먹다.");
        public void Yelp() => Console.WriteLine("짖다.");
    }
    class Program
    {
        static void Main()
        {
            Dog dog = new();
            dog.Eat();
            dog.Yelp();
        }
    } */
    /*  인터페이스 4 IEnumerator 인터페이스 사용하기
    internal class Program
    {
        static void Main()
        {
            string[] names = { "a", "b" };
            foreach (string name in names)
                Console.WriteLine(name);
            
            IEnumerator list = names.GetEnumerator();
            while (list.MoveNext())
                Console.WriteLine(list.Current);
        }
    } */
    /*  인터페이스 5 IDisposable 인터페이스 사용하기
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("[1] 열기.");
            using var t = new Toilet();
            Console.WriteLine("[2] 사용.");
        }
    }
    public class Toilet : IDisposable
    {
        public void Dispose() => Console.WriteLine("[3] 닫기.");
    } */
    /*  인터페이스, 추상클래스, 분할클래스, 봉인클래스
    public interface IStandard { void Run(); }
    public abstract class KS
    {
        public abstract void Back();
        public void Left() => Console.WriteLine("좌회전");
    }
    public partial class MyCar : KS { public override void Back() => Console.WriteLine("후진"); }
    public partial class MyCar : KS { public void Right() => Console.WriteLine("우회전"); }
    public sealed class Car : MyCar, IStandard { public void Run() => Console.WriteLine("전진"); }

    internal class Program
    {
        static void Main()
        {
            Car cla = new();
            cla.Run(); cla.Left(); cla.Right(); cla.Back();
        }
    } */

    /*  문제 1.
    interface IRunnable
    {
        void Run();
    }
    interface IFlyable
    {
        void Fly();
    }

    class FlyingCar : IRunnable, IFlyable
    {
        public void Run() => Console.WriteLine("Run");
        public void Fly() => Console.WriteLine("Fly");
    }

    internal class Program
    {
        static void Main()
        {
            FlyingCar car = new FlyingCar();
            car.Run();
            car.Fly();

            IRunnable runnable = car as IRunnable;
            runnable.Run();

            IFlyable flyable = car as IFlyable;
            flyable.Fly();
        }
    } */
    //  문제 4.
    
    
    // Define an abstract class 여기 밑에 추상 클래스를 구현 하세요
    
    public abstract class Shape
    {
        public abstract double CalculateArea();
        public virtual void Display() { }
    }

    // Derived class that implements the abstract class
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(5);
            circle.Display();
            Console.WriteLine("Circle Area: " + circle.CalculateArea());

            Shape rectangle = new Rectangle(4, 6);
            rectangle.Display();
            Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());
        }
    }
}