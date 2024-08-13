using System;
using System.Collections;
using System.Linq;

namespace Csharp08_13NETCORE
{
    /*  LinQ
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
    } */
    /*  LinQ 2 
    internal class Program
    {
        static void Main()
        {
            Func<int, bool> isEven = x => x % 2 == 0;       // 짝수인지 판별하는 Func 람다식
            Console.WriteLine(isEven(3) + ", " + isEven(4));

            Action<string> greet = name =>                  // 이름을 출력하는 Action 람다식
            {
                var message = $"Hello {name}";
                Console.WriteLine(message);
            };
            greet("Cinnamon");



            int[] numbers = { 1, 2, 3, 4, 5 };
            IEnumerable<int> newNumbers = numbers.Where(number => number > 3);  // 조건에 부합하는 범위의 데이터를 가져옴
            foreach (var n in newNumbers)
                Console.WriteLine(n);

            List<int> newNumbers_L = numbers.Where(number => number > 3).ToList();  // 위와 같으나 List에 담음
            foreach (var n in newNumbers_L)
                Console.WriteLine(n);
            
        }
    } */
    /*  LinQ 3 (람다식, .Take(), .Skip, .Distinct())
    internal class Program
    {
        static void Main()
        {
            bool[] blns = { true, false, true, false, true };
            Console.WriteLine(blns.Count());                        // 5개
            Console.WriteLine(blns.Count(bln => bln));              // 3개
            Console.WriteLine(blns.Count(bln => !bln));             // 2개

            bool[] completes = { true, true, true };
            Console.WriteLine(completes.All(c => c));           // 모든 배열값이 true인가? = true 출력

            bool[] completes_ = { true, false, true };
            Console.WriteLine(completes_.Any(c => !c));         // 어느 하나라도 배열값이 false인가? = true 출력


            // .Take()와 .Skip은 정말 자주 사용한다
            var data = Enumerable.Range(0, 100);                // 0 ~ 99

            var take = data.Take(5);                                // 앞에서 5개
            foreach (var t in take)
                Console.Write(t + " ");
            Console.WriteLine();

            var takeWhere = data.Where(n => n % 2 == 0).Take(5);    // 앞에서 짝수 5개
            foreach (var t in takeWhere)
                Console.Write(t + " ");
            Console.WriteLine();

            var next = data.Skip(10).Take(5);
            foreach (var t in next)
                Console.Write(t + " ");
            Console.WriteLine();


            // .Distinct() : 중복을 제거한다.
            var data_ = Enumerable.Repeat(3, 5);    // 3을 5개 저장
            var result = data_.Distinct();          // 중복 제거
            foreach (var t in result)
                Console.Write(t + " ");
            Console.WriteLine();

            int[] arr = { 2, 2, 3, 3, 3 };          // 2를 2개, 3을 3개 저장
            var result_a = arr.Distinct();          // 중복 제거
            foreach (var t in result_a)
                Console.Write(t + " ");
            Console.WriteLine();


        }
    } */
    /*  LinQ 4 (.OrderBy(), .OrderByDescending())
    internal class Program
    {
        static void Main()
        {
            string[] colors = { "Red", "Green", "Blue" };
            IEnumerable<string> sortedColors = colors.OrderBy(name => name);    // 오름차순 정렬
            foreach (var color in sortedColors)
                Console.WriteLine(color);
            Console.WriteLine();

            var sortedColors_d = colors.OrderByDescending(name => name);        // 내림차순 정렬
            foreach (var color in sortedColors_d)
                Console.WriteLine(color);
            Console.WriteLine();

            List<string> names = new List<string> { ".NET", "C#", "TypeScript" };   // 확장 메서드 체이닝 (Where, OrderBy 같이 씀)
            var results = names.Where(name => name.Length > 2).OrderBy(n => n);
            foreach (var name in results)
                Console.WriteLine(name);
            Console.WriteLine();



            var numbers = Enumerable.Range(1, 10);                      // 1 ~ 10 까지

            foreach (var n in numbers)
                Console.Write(n + " ");
            Console.WriteLine();

            var sort = numbers.Where(n => n % 2 == 0).OrderBy(n => n);  // numbers 중 짝수만 저장
            foreach (var n in sort)
                Console.Write(n + " ");
            Console.WriteLine();

            var decSort = numbers.Where(n => n % 2 == 0).OrderByDescending(n => n); // 위와 같으나 내림차순이다
            foreach (var n in decSort)
                Console.Write(n + " ");
            Console.WriteLine();
        }
    }*/
    /*  LinQ 5 (특정 문자열을 포함하는 컬렉션 가져오기)
    internal class Program
    {
        static void Main()
        {
            var colors = new List<string> { "Red", "Green", "Blue" };
            var newColors = colors.Where(c => c.Contains("e"));
            foreach (var color in newColors)
                Console.Write(color + " ");
            Console.WriteLine();

            var newColors_ = colors.Where(c => c.Contains("ee"));
            foreach (var color in newColors_)
                Console.Write(color + " ");
            Console.WriteLine();

            List<string> names = new List<string> { "ASP.NET", "Blazor", "C#" };
            var nameA = names.Where(n => n.Contains("a"));
            var nameB = names.Where(n => n.Contains("A"));
            var nameC = names.Where(n => n.ToUpper().Contains("A"));

            foreach (var n in nameA)
                Console.Write(n + " ");
            Console.WriteLine();


        }
    }*/
    /*  LinQ 6 (.Single(), .SingleOrDefault())
    internal class Program
    {
        static void Main()
        {
            List<string> colors = new List<string> { "Red", "Green", "Blue" };
            string red = colors.Single(c => c == "Red");
            Console.WriteLine(red);         // Red 반환
            //string black = colors.Single(c => c == "Black");
            //Console.WriteLine(black);       // 없는 데이터를 요청하여 예외 발생
            string? black_ = colors.SingleOrDefault(c => c == "Black");
            Console.WriteLine(black_ + " : Null");      // 없는 데이터를 요청하여 null값 반환


            var first = colors.First(c => c == "Red");
            Console.WriteLine(first);
            //var first_ = colors.First(c => c == "Black");
            //Console.WriteLine(first_);          // 첫 번째 요소가 Black이 아니라서 예외 발생
        }
    } */

    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
