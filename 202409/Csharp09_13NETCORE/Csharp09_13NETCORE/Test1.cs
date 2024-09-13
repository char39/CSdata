using System;

namespace Csharp09_13NETCORE
{
    internal class Test1
    {
        static void Main(string[] args)
        {
            int[] arr = [1, 2, 3, 5, 7, 10, 13, 15, 18, 23, 25, 27, 30, 32, 33];
            int target = 30;

            int result = LinearSearch(arr, target);
            if (result != -1 && arr[result] == target)
                Console.WriteLine(true + $"\ttarget : {target}, index : {result}");
            else
                Console.WriteLine(false + $"\ttarget : {target}, index : {result}");
        }

        static int LinearSearch(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] == target)
                    return i;
            return -1;
        }
    }
}
