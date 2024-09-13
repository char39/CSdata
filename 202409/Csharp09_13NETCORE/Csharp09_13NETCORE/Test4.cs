using System;

namespace Csharp09_13NETCORE
{
    internal class Test4
    {
        static void Main(string[] args)
        {
            int[] arr = [1, 2, 3, 5, 7, 10, 13, 15, 18, 23, 25, 27, 30, 32, 33];
            int target = 30;

            int result = BinarySearch(arr, target, 0, arr.Length - 1);
            if (result != -1 && arr[result] == target)
                Console.WriteLine(true + $"\ttarget : {target}, index : {result}");
            else
                Console.WriteLine(false + $"\ttarget : {target}, index : {result}");
        }

        static int BinarySearch(int[] array, int target, int FirstIndex, int LastIndex)
        {
            int mid;
            if (FirstIndex <= LastIndex)
            {
                mid = (FirstIndex + LastIndex) / 2;
                if (array[mid] == target)
                    return mid;
                else
                {
                    if (array[mid] > target)
                        return BinarySearch(array, target, FirstIndex, mid - 1);
                    else
                        return BinarySearch(array, target, mid + 1, LastIndex);
                }
            }
            return -1;
        }
    }
}
