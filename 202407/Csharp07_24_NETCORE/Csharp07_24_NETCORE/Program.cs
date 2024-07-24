using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Csharp07_24_NETCORE
{

    class MyList : IEnumerable, IEnumerator
    {
        private int[] array;
        int position = -1;

        public MyList()
        {
            Console.WriteLine("void 생성자 호출.");
            array = new int[5];
            Console.WriteLine($"array.Length :  {array.Length}");
        }

        public int this[int index]
        {
            get { return array[index]; }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine($"array.Length : {array.Length}");
                }
                array[index] = value;
            }
        }

        public int Length
        {
            get { return array.Length; }
        }

        public object Current
        {
            get { return array[position]; }
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if ( position == array.Length - 1 )
            {
                Reset();
                return false;
            }
            else
            {
                position++;
                return position < array.Length;
            }
        }

        public void Reset()
        {
            position = -1;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyList list = new();
            for (int i = 0; i < 9; i++)
                list[i] = i;
            foreach (int arr in list)
                Console.WriteLine(arr + " ");
        }
    }
}
