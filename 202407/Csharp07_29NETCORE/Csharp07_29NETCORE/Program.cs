using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp07_29NETCORE
{
    /*  델리게이트에 람다식 사용
    delegate int Calculator(int a, int b);
    delegate void DoSomeThing();
    delegate string Concat(string[] str);

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = delegate(int a, int b)
            {
                return a + b;
            };
            Console.WriteLine($"3 + 4 = {calc(3, 4)}");


            Calculator calc2 = (int a, int b) => a - b;
            Console.WriteLine($"{10} - {4} = {calc2(10, 4)}");


            DoSomeThing doIt = () =>
            {
                Console.WriteLine("출력.");
            };
            doIt();


            Concat concat = (arr) =>
            {
                string result = "";
                foreach (string str in arr)
                    result += arr;
                return result;
            };
            Console.WriteLine(concat(args));
        }
    }
    */    
    /*  람다식 Func, Action 
    class FriendList
    {
        private List<string> list = new();
        public void Add(string name) => list.Add(name);
        public void Remove(string name) => list.Remove(name);
        public void PrintAll()
        {
            foreach(var s in list)
                Console.WriteLine(s);
        }

        public FriendList() => Console.WriteLine("FriendList()");   // 생성자
        ~FriendList() => Console.WriteLine("~FriendList()");        // 소멸자

        public int Capacity         // 프로퍼티
        {
            get => list.Capacity;
            set => list.Capacity = value;
        }
        public string this[int index]   // 인덱서
        {
            get => list[index];
            set => list[index] = value;
        }
    }

    internal class Program
    {
        static void Main()
        {
            Func<int> funcInt = () => 10;
            Console.WriteLine($"funcInt() : {funcInt()}");

            Func<int, int> funcInts = (x) => x * 2;
            Console.WriteLine($"funcInts(4) : {funcInts(4)}");

            Func<double, double, double> funcDoubles = (x, y) => x / y;
            Console.WriteLine($"funcDoubles(15, 3) : {funcDoubles(15, 3)}");

            Action act = () => Console.WriteLine("Action()");
            act();
            
            int result = 0;
            Action<int> actionInt = (x) => result = x * x;
            actionInt(3);
            Console.WriteLine("Result : " + result);

            Action<double, double> actionDouble = (x, y) =>
            {
                double pi = x / y;
                Console.WriteLine($"Action<T1, T2> : ({x}, {y} : {pi})");
            };


            Action<dynamic, dynamic> a_sum = (x, y) =>
            {
                Console.WriteLine($"x + y = {x + y}");
            };
            a_sum(5, 3);

            actionDouble(22.0f, 7.0f);

            Console.WriteLine();

            FriendList friendList = new();
            friendList.Add("Anna");
            friendList.Add("Cinnamon");
            friendList.Add("Strawberry");
            friendList.Add("Chocolate");

            friendList.Remove("Strawberry");
            Console.WriteLine($"friendList.Capacity : {friendList.Capacity}");
            friendList.Capacity = 10;
            Console.WriteLine($"friendList.Capacity : {friendList.Capacity}");
            Console.WriteLine($"friendList[2] : {friendList[2]}");
            friendList[2] = "Vanilla";
            friendList.PrintAll();

        }
    } */
    /*  쪽지시험 
    delegate void Calc(int[] x);

    internal class Program
    {
        static void Main()
        {
            // int[] array = { 11, 22, 33, 44, 55 };
            // foreach (int a in array)
            // {
            //     Action action = new Action
            //     (
            //         delegate ()
            //         {
            //             Console.WriteLine(a * a);
            //         }
            //     );
            //     action.Invoke();
            // }

            // int[] array = { 11, 22, 33, 44, 55 };
            // Calc calc = (arrays) =>
            // {
            //     foreach (int i in arrays)
            //         Console.WriteLine(i * i);
            // };
            // calc(array);

            // int[] array = { 11, 22, 33, 44, 55 };
            // foreach (int a in array)
            // {
            //     Action<int> action = (a) => Console.WriteLine(a * a);
            //     action.Invoke(a);
            // }
        }
    } */
    /*  dynamic을 활용한 일반화 메서드
    internal class Program
    {
        static void Main()
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            double[] arr2 = { 2.3, 4.5, 6.6, 7.7, 8.8 };
            float[] arr3 = { 2.3f, 4.5f, 6.6f, 7.7f, 8.8f };

            Console.WriteLine(Sum(arr1));
            Console.WriteLine(Sum(arr2));
            Console.WriteLine(Sum(arr3));
            Console.WriteLine(Aver(arr1));
            Console.WriteLine(Aver(arr2));
            Console.WriteLine(Aver(arr3));
        }
        public static T? Sum<T>(T[] arrs)
        {
            //dynamic sum = 0;
            T sum = default;
            for (int i = 0; i < arrs.Length; i++)
                sum += (dynamic)arrs[i];
            return sum;
        }
        public static T? Aver<T>(T[] arrs)
        {
            T sum = default;
            for (int i = 0; i < arrs.Length; i++)
                sum += (dynamic)arrs[i];
            return sum / (dynamic)arrs.Length;
        }
    } */
    /*  익명 메소드  : 이름이 없는 메소드 익명의 함수 anonymous Method라 부른다.
    delegate int Compare<T>(T a, T b);

    internal class Program
    {
        static void BubbleSort<T>(T[] DataSet, Compare<T> compare) where T : IComparable<T>
        {
            int i, j;
            T temp;
            for (i = 0; i < DataSet.Length - 1; i++)
            {
                for (j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (compare(DataSet[j], DataSet[j + 1]) > 0)    // 비교한 값이 0보다 크면
                    {
                        temp = DataSet[j + 1];                      // 임시변수에 뒤의 값을 저장
                        DataSet[j + 1] = DataSet[j];                // 뒤의 값을 앞의 값으로 변경
                        DataSet[j] = temp;                          // 앞의 값을 임시변수에 저장한 뒤 뒤의 값으로 변경
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] numbers = { 3, 7, 4, 2, 10 };
            string[] words = { "Apple", "Banana", "Cherry" };

            // 람다식을 사용한 예제
            BubbleSort(numbers, (x, y) => x.CompareTo(y));
            PrintArrs(numbers);

            BubbleSort(numbers, (x, y) => -x.CompareTo(y));
            PrintArrs(numbers);

            // 익명 메서드를 사용한 예제
            BubbleSort(numbers, delegate (int x, int y) { return x.CompareTo(y); });
            PrintArrs(numbers);

            BubbleSort(numbers, delegate (int x, int y) { return -x.CompareTo(y); });
            PrintArrs(numbers);

            static void PrintArrs(int[] numbers)
            {
                foreach (var i in numbers)
                    Console.WriteLine(i);
            }

        }
    } */
}