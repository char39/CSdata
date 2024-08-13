using System;
using System.Linq;

namespace Csharp08_13NETCORE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers_Sum = { 1, 2, 3 };
            int sum = numbers_Sum.Sum();
            Console.WriteLine(nameof(numbers_Sum) + " 배열 요소의 합 : " + sum);

            int[] numbers_Count = { 1, 2, 3 };
            int count = numbers_Count.Count();
            Console.WriteLine(nameof(numbers_Count) + " 배열 개수 : " + count);

            int[] numbers_Average = { 1, 3, 4 };
            double average = numbers_Average.Average();
            Console.WriteLine(nameof(numbers_Average) + " 배열 요소의 평균 : " + average);
        }
    }
}
