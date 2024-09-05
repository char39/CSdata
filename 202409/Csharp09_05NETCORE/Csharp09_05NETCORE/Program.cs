using System;
using System.Collections;
using System.Collections.Generic;

namespace Csharp09_05NETCORE
{
    /*  강력한 형식의 대리자
        internal class Program
        {
            public delegate double DelegateType(double x, double y);
            static void Main(string[] args)
            {
                DelegateType pow = Math.Pow;
                double actual = pow(2, 10);
                Console.WriteLine(actual);
            }
        }*/
    /*  대리자를 사용하여 메서드 여러 개를 다중 호출하기
        public class CarDriver
        {
            public static void GoForward() => Console.WriteLine("직진");
            public static void GoLeft() => Console.WriteLine("좌회전");
            public static void GoRight() => Console.WriteLine("우회전");
        }

        public class Insa
        {
            public void Bye() => Console.WriteLine("잘가");
        }

        public delegate void GoHome();

        public class Program
        {
            public delegate void Say();
            private static void Hello() => Console.WriteLine("Hello");
            private static void Hi() => Console.WriteLine("Hi");

            static void Main()
            {
                CarDriver.GoLeft();
                CarDriver.GoForward();
                CarDriver.GoRight();
                GoHome go = new GoHome(CarDriver.GoLeft);
                go += new GoHome(CarDriver.GoForward);
                go += new GoHome(CarDriver.GoRight);
                go += new GoHome(CarDriver.GoLeft);
                go -= new GoHome(CarDriver.GoLeft);
                go();

                Console.WriteLine();

                Say say;
                say = new Say(Hi);
                say += new Say(Hello);
                say();

                Insa insa = new();
                Say say2 = new(insa.Bye);
                say2 += new Say(insa.Bye);
                say2();
            }
        } */
    /*  Action, Func 대리자, 무명메서드, 람다식
        internal class Program
        {
            static void Main()
            {
                Action<string> printf = Console.WriteLine;
                printf("메서드 대신 호출");

                Func<int, int> abs = Math.Abs;
                printf(abs(-10).ToString());

                Func<double, double, double> pow = Math.Pow;
                printf(pow(2, 10).ToString());

                Func<string, string> toLower = str => str.ToLower();
                Console.WriteLine(toLower("LambdaExpression"));

                Func<int, int> anonymous = delegate (int x) { return x * x; };
                printf(anonymous(2).ToString());

                Func<int, double> lambda = x => x / (double)2;
                printf(lambda(3).ToString());



                Func<int, int> square = x => x * x;         // 람다식
                Console.WriteLine(square(3));



                Func<int> getNumber1 = delegate () { return 1234; };        // 무명 메서드
                Func<int> getNumber2 = () => 1234;                          // 람다식
                Console.WriteLine(getNumber1() + ", " + getNumber2());

                Func<int, int> addOne1 = delegate (int x) { return x + 1; };
                Func<int, int> addOne2 = x => x + 1;
                Console.WriteLine(addOne1(10) + ", " + addOne2(20));

                Func<string, string, string> plus1 = delegate (string a, string b) { return $"{a} {b}"; };
                Func<string, string, string> plus2 = (a, b) => $"{a} {b}";
                Console.WriteLine(plus1("Hello", "World!") + ", " + plus2("Hello", "World!"));
            }
        } */
    /*  Pridicate 대리자
        internal class Program
        {
            static void Main()
            {
                Predicate<string> isNullOrEmpty = string.IsNullOrEmpty;
                Console.WriteLine(isNullOrEmpty("not null").ToString());

                Predicate<Type> isPrimitive = t => t.IsPrimitive;
                Console.WriteLine(isPrimitive(typeof(int)).ToString());

                var numbers = FindNumbers(f => f % 33 == 0);
                foreach(var num in numbers)
                    Console.Write(num + " ");
                Console.WriteLine();
            }
            static IEnumerable<int> FindNumbers(Predicate<int> predicate)
            {
                for (int i = 1; i <= 100; i++)
                    if (predicate(i))
                        yield return i;
            }
        }*/

    /*  문제 1.
    //  위의 코드를 람다식으로 바꾸어 보세요. 홀수 출력 짝수 출력 되는 부분은 Predicate 대리자를 이용 하세요
    internal class Program
    {
        static void Main()
        {
            int[] arr = new int[10];

            Console.WriteLine("총 10개의 숫자 입력");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("입력: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("홀수 출력 : ");
            ShowNumbs(arr, num => num % 2 == 1);

            Console.Write("짝수 출력 : ");
            ShowNumbs(arr, num => num % 2 == 0);
        }

        static void ShowNumbs(int[] arr, Predicate<int> condition)
        {
            foreach (int num in arr)
            {
                if (condition(num))
                    Console.Write($"{num}, ");
            }
            Console.WriteLine();
        }
    }*/

    /*  메서드의 매개변수로 메서드 전달하기
    internal class Program
    {
        static int StringLength(string data) => data.Length;
        static void StringLengthPrint(Func<string, int> stringLength, string message)
        => Console.WriteLine($"메시지의 크기는 {stringLength(message)}입니다.");
        static void Main()
        {
            StringLengthPrint(StringLength, "안녕하세요.");
            Calc(3, 5, (x, y) => x + y);
        }

        static void Calc(int x, int y, Func<int, int, int> calc) => Console.WriteLine(calc(x, y));
    }*/
    /*  이벤트와 대리자를 사용하여 메서드 등록 및 호출
    public class ButtonClass
    {
        public delegate void EventHandler();                // 대리자 선언
        public event EventHandler Click;                    // 이벤트 선언
        public void OnClick()                               // 이벤트 발생 메서드
        {
            if (Click != null)                                  // 이벤트에 메서드가 등록되어 있으면
                Click();                                            // 이벤트 발생
        }
    }
    internal class Program
    {
        static void Hi1() => Console.WriteLine("C#");       // 이벤트 처리 메서드
        static void Hi2() => Console.WriteLine(".NET");     // 이벤트 처리 메서드
        static void Main()                                  // 메인 메서드
        {
            ButtonClass btn = new();                            // ButtonClass 객체 생성
            btn.Click += Hi1;                                   // 이벤트에 메서드 등록
            btn.Click += Hi2;                                   // 이벤트에 메서드 등록
            btn.OnClick();                                      // 이벤트 발생
        }
    }*/

    /*  문제 2.
    //  아래 내용을 람다식 으로 익명이나 무명 형식으로 바꾸어서 출력 되게 하세요.
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> plus = delegate (int x, int y) { return x + y; };
            Func<int, int, int> minus = delegate (int x, int y) { return x - y; };

            Console.WriteLine(plus(3, 4));
            Console.WriteLine(minus(7, 5));
        }
    }*/
    /*  문제 3.
    //  아래의 코드에서 delegate 대신에 Func를 사용 해서 메서드에 전달하는 방식으로 바꾸세요.
    internal class Program
    {
        static void Bubble(int[] data, Func<int, int, int> condition)
        {
            int temp;
            for (int i = 0; i < data.Length - 1; i++)
            {
                for (int j = 0; j < data.Length - (i + 1); j++)
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

        static void Main(string[] args)
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

            int[] array = [3, 7, 4, 2, 10];

            Console.WriteLine("Sorting ascending...");
            Bubble(array, Ascend);
            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");

            int[] array2 = { 7, 2, 8, 10, 11 };
            Console.WriteLine("\nSorting descending...");
            Bubble(array2, Descend);
            for (int i = 0; i < array2.Length; i++)
                Console.Write($"{array2[i]} ");
            Console.WriteLine();
        }
    }*/

    //  문제 4.
    //  아래의 코드도 delegate 대신에 Func를 이용해서 출력 하세요.
    //  문제 3에서 문제 4를 미리 풀어버림..

}