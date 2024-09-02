using System;
using System.Collections;
using System.Collections.Generic;

namespace Csharp09_02NETCORE
{
/* 반복기 코드 IEnumerable (1)
    internal class Program
    {
        static IEnumerable MultiData()
        {
            yield return "Hello";
            yield return "World";
            yield return "C#";
        }

        static void Main(string[] args)
        {
            foreach (var item in MultiData())
                Console.WriteLine(item);
        }
    }*/
/* 반복기 코드 IEnumerable (2)
    internal class Program
    {
        static IEnumerable GetNumbers()
        {
            yield return 1;
            yield return 2;
            for (int i = 3; i <= 5; i++)
                yield return i;
        }
        static void Main()
        {
            foreach (int num in GetNumbers())
                Console.Write($"{num}\t");
            Console.WriteLine();
        }
    } */
/* 반복기 코드 IEnumerable (3)
    class Languages
    {
        private string[] languages;
        public Languages(int length)
        {
            languages = new string[length];
        }
        public string this[int index]
        {
            get { return languages[index]; }
            set { languages[index] = value; }
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < languages.Length; i++)
                yield return languages[i];
        }
    }

    internal class Program
    {
        static void Main()
        {
            Languages lang = new(2);
            lang[0] = "C#";
            lang[1] = "Type";
            foreach (var langs in lang)
                Console.WriteLine(langs);
        }
    }*/
/* 반복기 코드 IEnumerable (4)
    internal class Program
    {
        // static List<int> Greater1(int[] numbers, int greater)  << List로 바꿔도 가능 제네릭 클래스
        static IEnumerable<int> Greater1(int[] numbers, int greater)
        {
            List<int> temp = [];
            foreach (var n in numbers)
            {
                if (n > greater)
                    temp.Add(n);
            }
            return temp;
        }

        static IEnumerable<int> Greater2(int[] numbers, int greater)
        {
            foreach (var n in numbers)
            {
                if (n > greater)
                    yield return n;
            }
        }

        static void Main()
        {
            int[] numbers = [1, 2, 3, 4, 5];
            foreach (var n in Greater1(numbers, 3))
                Console.WriteLine(n);
            
            foreach (var n in Greater2(numbers, 3))
                Console.WriteLine(n);
        }
    }*/
/* 반복기 코드 IEnumerable (5) 피보나치 수열
    internal class Program
    {
        static IEnumerable<int> GetFibonacci()
        {
            int current = 1;
            int next = 1;
            yield return current;
            while (true)
            {
                int temp = current + next;
                current = next;
                next = temp;
                yield return current;
            }
        }
        static void Main()
        {
            int count = 7;
            int i = 0;
            foreach (var f in GetFibonacci())
            {
                Console.WriteLine(f);
                if (++i > count)
                    break;
            }
        }
    }*/

    internal class Program
    {
        static void Main()
        {
            
        }
    }


}
