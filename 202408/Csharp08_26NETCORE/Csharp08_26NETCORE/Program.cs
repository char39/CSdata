using System;
using System.Collections;

namespace Csharp08_26NETCORE
{
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
    }
}