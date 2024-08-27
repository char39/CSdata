using System;
using System.Collections;

namespace Csharp08_26NETCORE
{
    /*  0826일 문제
        class MyList : IEnumerable<int>
        {
            private int[] array;
            private int nextIndex;

            public MyList()
            {
                array = new int[3];
                nextIndex = 0;
            }

            public int this[int index]
            {
                get { return array[index]; }
                set
                {
                    if (index >= array.Length)
                    {
                        Console.WriteLine("Array Resized : " + (array.Length + 1));
                        int[] tempArray = new int[array.Length + 1];
                        array.CopyTo(tempArray, 0);
                        array = tempArray;
                    }

                    array[index] = value;
                    nextIndex++;
                }
            }

            public int Length
            {
                get { return nextIndex; }
            }

            public IEnumerator<int> GetEnumerator()     // IEnumerable<T> 인터페이스의 GetEnumerator() 메서드 구현
            {
                for (int i = 0; i < nextIndex; i++)         // nextIndex만큼만 반복
                    yield return array[i];                      // 현재 요소를 반환하고 다음 요소로 이동
            }

            IEnumerator IEnumerable.GetEnumerator()     // IEnumerable 인터페이스의 GetEnumerator() 메서드 구현
            {
                return GetEnumerator();                     // 현재 클래스에 구현된 GetEnumerator() 메서드 반환
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                MyList list = new();

                for (int i = 0; i < 5; i++)
                    list[i] = i;

                for (int i = 0; i < list.Length; i++)
                    Console.WriteLine(list[i]);

                foreach (int e in list)
                    Console.WriteLine(e);
            }
        } */
    /*  0827일 문제 1
        internal class Program
        {
            static void Divide(string first, string second)
            {
                int firstNum;
                int secondNum;
                int result;
                try
                {
                    firstNum = Convert.ToInt32(first);
                    secondNum = Convert.ToInt32(second);
                    Console.WriteLine("Divide() 시작");
                    result = firstNum / secondNum;
                    Console.WriteLine("Divide() 끝");
                    Console.WriteLine($"{firstNum}/{secondNum} = {result}");
                    Console.WriteLine("프로그램을 종료합니다.");
                }

                catch (FormatException ex)
                {
                    Console.WriteLine("에러 : 입력 문자열의 형식이 잘못되었습니다.\n" + ex.Message);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Divide() 예외 발생");
                    Console.WriteLine("Divide() 끝");
                    Console.WriteLine("에러 : 0으로 나누려 했습니댜.\n" + ex.Message);
                }
            }

            static void Main()
            {   
                string? num1;
                string? num2;
                Console.WriteLine("Finally");
                Console.Write("제수를 입력하세요. : ");
                num1 = Console.ReadLine();
                Console.Write("피제수를 입력하세요. : ");
                num2 = Console.ReadLine();
                Divide(num1, num2);
            }
        } */
    /*  0827일 문제 2
    class MyList<T> : IEnumerable, IEnumerator
    {
        private T[] array;
        int position = -1;

        public MyList() { array = new T[3]; }

        public T this[int index]
        {
            get { return array[index]; }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<T>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }
                array[index] = value;
            }
        }

        // IEnumerator 멤버
        public object Current
        {
            get { return array[position]!; }
        }

        // IEnumerator 멤버
        public bool MoveNext()
        {
            if (position == array.Length - 1)
            {
                Reset();
                return false;
            }
            position++;
            return position < array.Length;
        }

        // IEnumerator 멤버
        public void Reset() => position = -1;

        // IEnumerable 멤버
        public IEnumerator GetEnumerator() { return this; }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            MyList<double> list = new MyList<double>();
            for (int i = 0; i < 5; i++)
                list[i] = i;

            foreach (double e in list)
                Console.WriteLine(e);
        }
    }*/

    //  0827일 문제 3

    class Class
    {
        public string Name { get; set; }
        public int[] Score { get; set; }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Class[] arrClass =
            [
                new Class() {Name = "연두반", Score = [99, 80, 70, 24]},
                new Class() {Name = "분홍반", Score = [60, 45, 87, 72]},
                new Class() {Name = "파랑반", Score = [92, 30, 85, 94]},
                new Class() {Name = "노랑반", Score = [90, 88, 0, 17]}
            ];
        }
    }




}