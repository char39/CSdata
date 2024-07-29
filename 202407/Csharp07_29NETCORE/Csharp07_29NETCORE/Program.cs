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
    } */
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
            // Func<int> funcInt = () => 10;
            // Console.WriteLine($"funcInt() : {funcInt()}");
            // Func<int, int> funcInts = (x) => x * 2;
            // Console.WriteLine($"funcInts(4) : {funcInts(4)}");
            // Func<double, double, double> funcDoubles = (x, y) => x / y;
            // Console.WriteLine($"funcDoubles(15, 3) : {funcDoubles(15, 3)}");

            // Action act = () => Console.WriteLine("Action()");
            // act();
            
            // int result = 0;
            // Action<int> actionInt = (x) => result = x * x;
            // actionInt(3);
            // Console.WriteLine("Result : " + result);

            // Action<double, double> actionDouble = (x, y) =>
            // {
            //     double pi = x / y;
            //     Console.WriteLine($"Action<T1, T2> : ({x}, {y} : {pi})");
            // };
            // actionDouble(22.0f, 7.0f);

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
    }  */

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

            int[] array = { 11, 22, 33, 44, 55 };
            Calc calc = (arrays) =>
            {
                foreach (int i in arrays)
                    Console.WriteLine(i * i);
            };
            calc(array);
        }
    }
}