using System;

namespace Csharp09_13NETCORE
{
    internal class Test3
    {
        static void Main(string[] args)
        {
            Random ran = new();
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

            int[] arr = new int[50];

            for (int i = 0; i < arr.Length; i++)
                arr[i] = ran.Next(0, 101);

            foreach (int i in arr)
                Console.Write(i + " ");
            Console.WriteLine();

            BubbleSort(arr, Ascend);
            foreach (int i in arr)
                Console.Write(i + " ");
            Console.WriteLine();

        }

        static void BubbleSort(int[] array, Func<int, int, int> condition)
        {
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - (i + 1); j++)
                {
                    if (condition(array[j], array[j + 1]) > 0)
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}
