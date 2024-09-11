﻿using System;
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
            List<int> arr = [1, 3, 5, 7, 9, 11, 35, 36, 93];
            int index;
            index = BinarySearch(arr, 7);
            if (index == -1)
                Console.WriteLine("탐색 실패");
            else
                Console.WriteLine($"타겟 저장 인덱스 : {index}");
            
            index = BinarySearch(arr, 35);
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
}