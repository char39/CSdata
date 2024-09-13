using System;

namespace Csharp09_13NETCORE
{
    internal class Test2
    {
        static void Main(string[] args)
        {
            int[] arr = [1, 2, 3, 5, 7, 10, 13, 15, 18, 23, 25, 27, 30, 32, 33];
            int target = 30;

            int result = BinarySearch(arr, target);
            if (result != -1 && arr[result] == target)
                Console.WriteLine(true + $"\ttarget : {target}, index : {result}");
            else
                Console.WriteLine(false + $"\ttarget : {target}, index : {result}");
        }

        static int BinarySearch(int[] array, int target)
        {
            int first = 0;
            int last = array.Length - 1;
            int mid;
            while (first <= last)
            {
                mid = (first + last) / 2;
                if (array[mid] == target)
                    return mid;
                else
                {
                    if (array[mid] > target)
                        last = mid - 1;
                    else
                        first = mid + 1;
                }
            }
            return -1;
        }
    }
}
