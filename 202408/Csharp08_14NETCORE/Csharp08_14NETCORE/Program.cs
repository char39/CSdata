using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp08_14NETCORE
{
    /*  LinQ (1) 메서드 구문과 쿼리 구문 비교
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 2, 1, 4, 5 };

            IEnumerable<int> methodSyntax = numbers.Where(n => n % 2 == 1).OrderBy(n => n);
            foreach (var item in methodSyntax)
                Console.WriteLine(item);
            Console.WriteLine();

            IEnumerable<int> querySyntax = from n in numbers
                                           where n % 2 == 1
                                           orderby n
                                           select n;
            foreach (var item in querySyntax)
                Console.WriteLine(item);
            Console.WriteLine();
        }
    } */
    /*  LinQ (2) 확장 메서드, ForEach() 메서드
    internal class Program
    {
        static void Main()
        {
            // // 1. Select() 메서드 사용하여 확장 메서드 구문으로 변환
            // int[] numbers = { 1, 2, 3, 4, 5 };

            // var nums = numbers.Select(n => n * n);
            // foreach (var item in nums)
            //     Console.WriteLine(item);



            // // 2. ForEach() 메서드로 반복 출력
            // var numbers = new List<int>() { 10, 20, 30, 40, 50 };
            // numbers.Where(n => n <= 20).ToList().ForEach(n => Console.WriteLine(n));

            // var names = new List<string>() { "RedPlus", "Taeyo" };
            // names.ForEach(n => Console.WriteLine(n));
        }
    } */
    /*  알고리즘 (1) 근사값 찾기
    internal class Program
    {
        static void Main()
        {
            int Abs(int number) => number < 0 ? -number : number;

            int min = int.MaxValue;

            int[] numbers = { 0b1010, 0x14, 0b11110, 0x1B, 0b10001 };
            int target = 25;
            int near = default;

            for (int i = 0; i < numbers.Length; i++)
            {
                int abs = Abs(numbers[i] - target);
                if (min > abs)
                {
                    min = abs;
                    near = numbers[i];
                }
            }

            var minimum = numbers.Min(n => Math.Abs(n - target));
            var closest = numbers.First(n => Math.Abs(target - n) == minimum);
            Console.WriteLine($"{target}와/과 가장 가까운 값(식): {closest}(차이 : {minimum})");
            Console.WriteLine($"{target}와/과 가장 가까운 값(문): {near}(차이 : {min})");
        }
    } */
    /*  알고리즘 (2) 가까운값 모두 찾기
    internal class Program
    {
        static void Main()
        {
            int[] data = { 10, 20, 23, 27, 17 };
            int target = 25;
            List<int> nears = [];                       // List 생성
            int min = Int32.MaxValue;                   // 최소값 초기화

            for (int i = 0; i < data.Length; i++)       // 최소값 찾기
            {
                if (Math.Abs(data[i] - target) < min)       // 절대값 비교
                    min = Math.Abs(data[i] - target);           // 최소값 갱신
            }
            Console.WriteLine($"가장 가까운 값 : {min}");  // 최소값 출력

            for (int i = 0; i < data.Length; i++)       // 최소값과 같은 값 찾기
            {
                if (Math.Abs(data[i] - target) == min)      // 절대값 비교
                    nears.Add(data[i]);                         // List에 추가
            }
            foreach (var item in nears)                 // List 출력
                Console.WriteLine(item);
        }
    } */
    /*  알고리즘 (3) 순위 계산 (Rank)
    internal class Program
    {
        static void Main()
        {
            int[] scores = { 90, 87, 100, 95, 80 };             // 점수 배열
            int[] rankings = Enumerable.Repeat(1, 5).ToArray(); // 순위 배열

            for (int i = 0; i < scores.Length; i++)             // 순위 계산
            {
                rankings[i] = 1;                                    // 순위 초기화
                for (int j = 0; j < scores.Length; j++)             // 모든 점수와 비교
                {
                    if (scores[i] < scores[j])                          // 비교
                        rankings[i]++;                                      // 순위 증가
                }
            }

            for (int i = 0; i < scores.Length; i++)             // 결과 출력
                Console.WriteLine($"{scores[i],3}점 : {rankings[i]}등");
        }
    } */
    
    /*  문제 1.
    public class Solution
    {
        public string Solution_0(string originNum)
        {
            string hiddenNum = "";
            for (int i = 0; i < originNum.Length; i++)
            {
                if (i < originNum.Length - 4)
                    hiddenNum += "*";
                else
                    hiddenNum += originNum[i];
            }
            return hiddenNum;
        }
        public string Solution_1(string originNum)
        {
            var array = originNum.Select((e, index) => index >= (originNum.Length - 4) ? e : '*').ToArray();
            return new string(array);
        }
        public string Solution_2(string originNum)
        {
            string answer = originNum.Substring(originNum.Length - 4);
            answer = answer.PadLeft(originNum.Length, '*');
            return new string(answer);
        }
    }

    internal class Program
    {
        static void Main()
        {
            string[] phone_number = ["01033334444", "021112222"];

            Solution sol = new();

            Console.WriteLine($"{nameof(phone_number)}\treturn");
            for (int i = 0; i < phone_number.Length; i++)
                Console.WriteLine($"\"{phone_number[i]}\"\t\"{sol.Solution_0(phone_number[i])}\"");
            Console.WriteLine($"{nameof(phone_number)}\treturn");
            for (int i = 0; i < phone_number.Length; i++)
                Console.WriteLine($"\"{phone_number[i]}\"\t\"{sol.Solution_1(phone_number[i])}\"");
            Console.WriteLine($"{nameof(phone_number)}\treturn");
            for (int i = 0; i < phone_number.Length; i++)
                Console.WriteLine($"\"{phone_number[i]}\"\t\"{sol.Solution_2(phone_number[i])}\"");
        }
    } */
    /*  문제 2.
    public class Solution
    {
        public string Solution_0(string my_string)
        {
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            var result = new string(my_string.Where(c => !vowels.Contains(c)).ToArray());
            return new string(result);
        }
    }

    internal class Program
    {
        static void Main()
        {
            string[] my_string = ["bus", "nice to meet you"];

            Solution sol = new();
            
            Console.WriteLine(sol.Solution_0(my_string[0]));
            Console.WriteLine(sol.Solution_0(my_string[1]));
        }
    } */




}
