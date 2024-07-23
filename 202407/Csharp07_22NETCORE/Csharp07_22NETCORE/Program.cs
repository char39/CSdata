using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp07_22NETCORE
{
    /*  1. 가변 길이 배열
    internal class Program
    {
        static void Main(string[] args)
        {
            // 가변 길이 배열
            int[][] jagged = new int[3][];
            jagged[0] = new int[5] { 1, 2, 3, 4, 5 };
            jagged[1] = new int[] { 10, 20, 30 };
            jagged[2] = new int[] { 100, 200 };

            foreach (int[] arr in jagged)
            {
                Console.Write($"Length {arr.Length} > ");
                foreach (int e in arr)
                {
                    Console.Write($"{e} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("");



            int[][] jagged2 = new int[2][]
            {
                new int[] { 100, 200 },
                new int[] { 6, 7, 8, 9 }
            };
            foreach (int[] arr in jagged2)
            {
                Console.Write($"Length {arr.Length} > ");
                foreach (int e in arr)
                {
                    Console.Write($"{e} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("");

        }
    }
    */
    /*  2. ArrayList
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < 5; i++)
                list.Add(i);
            foreach (object obj in list)
                Console.WriteLine(obj);
            Console.WriteLine("");

            list.RemoveAt(2);

            foreach (object obj in list)
                Console.WriteLine(obj);
            Console.WriteLine("");

            list.Insert(2, 2);

            foreach (object obj in list)
                Console.WriteLine(obj);
            Console.WriteLine("");

            list.Add("abc");    list.Add("def");

            foreach (object obj in list)
                Console.WriteLine(obj);
            Console.WriteLine("");
        }
    }
    */
    /*  3. Queue, Stack
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue que = new Queue();
            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);
            que.Enqueue(5);
            while (que.Count > 0)
            {
                Console.WriteLine(que.Dequeue());
            }

            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
    */
    /*  4. HashTable
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            // hashtable["Key"] = "Value";
            hashtable["Book"] = "책";
            hashtable["Cook"] = "요리";
            hashtable["Snack"] = "과자";
            Console.WriteLine(hashtable["Book"]);
            Console.WriteLine(hashtable["Cook"]);
            Console.WriteLine(hashtable["Snack"]);
        }
    }
    */
    /*  5. ArrayList ~ HashTable 출력 예제
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 123, 456, 789 };

            ArrayList list = new ArrayList(arr);
            foreach (object item in list)
                Console.WriteLine($"ArrayList : {item}");
            Console.WriteLine("");

            Stack stack = new Stack(arr);
            foreach (object item in stack)
                Console.WriteLine($"Stack : {item}");
            Console.WriteLine("");
            
            Queue queue = new Queue(arr);
            foreach (object item in queue)
                Console.WriteLine($"Queue : {item}");
            Console.WriteLine("");

            Hashtable hashtable = new Hashtable()
            {
                ["(1)"] = "One",
                ["(2)"] = "Two",
                ["(3)"] = "Three"
            };
            foreach (object item in hashtable)
                Console.WriteLine($"HashTable : {item}");
            Console.WriteLine("");
        }
    }
    */
    /*  6. Indexer
    class MyList
    {
        private int[]? array;
        public MyList()
        {
            array = new int[3];
        }
        public int this[int index]  // 인덱서 프로퍼티
        {
            get { return array[index]; }
            set
            {
                if (index >= array.Length)  // 배열의 경계를 넘어선다면
                {
                    Array.Resize(ref array, index + 1); // 배열의 길이를 늘림
                    Console.WriteLine($"Array Resized : {array.Length}");
                }
                array[index] = value;
            }
        }
        public int Length // 길이값을 반환하는 프로퍼티
        {
            get { return array.Length; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            for (int i = 0; i < 5; i++)
                list[i] = i + 1;
            for (int i = 0; i < list.Length; i++)
                Console.WriteLine($"{list[i]}");
        }
    }
    */
    /*  7. Dictionary
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dic = [];
            dic["하나"] = "One";
            dic["둘"] = "Two";
            dic["셋"] = "Three";
            Console.WriteLine(dic["하나"]);
            Console.WriteLine(dic["둘"]);
            Console.WriteLine(dic["셋"]);

            Dictionary<string, string> dic2 = [];
            dic2["하나"] = "1";
            dic2["둘"] = "2";
            dic2["셋"] = "3";
            Console.WriteLine(dic2["하나"]);
            Console.WriteLine(dic2["둘"]);
            Console.WriteLine(dic2["셋"]);
        }
    } */

    
    internal class Program
    {
        static void Main()
        {

        }
    }


}