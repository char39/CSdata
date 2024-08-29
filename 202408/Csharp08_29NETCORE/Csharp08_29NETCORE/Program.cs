using System;
using System.Collections.Generic;

namespace Csharp08_29NETCORE
{
    /*  생성자로 속성에 대한 유효성 검사
        class Car
        {
            public string Name { get; private set; }
            public Car(string name)
            {
                if (string.IsNullOrEmpty(name))
                    throw new ArgumentException();
                Name = name;
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Car car = new Car("Cars");
                Console.WriteLine(car.Name);
                Car car1 = new Car("");
                Console.WriteLine(car1.Name);
            }
        } */
    /*  메서드로 속성 값 초기화
        /// <summary> 애완동물 </summary>
        class Pet
        {
            /// <summary> 몸무게 </summary>
            public int Weight { get; set; }
            /// <summary> 먹이를 주면 몸무게 증가 </summary>
            /// <param name="weight"></param>
            public void Feed(int weight)
            {
                Weight += weight;
            }
        }

        internal class Program
        {
            static void Main()
            {
                Pet pet = new();
                pet.Weight = 50;
                pet.Feed(10);
                Console.WriteLine(pet.Weight);
            }
        }*/
    /*  메서드로 속성 값 초기화 간략하게
        public class Fish
        {
            public int Weight { get; set; } = 50;
            public void Feed(int weight) => Weight += weight;
        }

        internal class Program
        {
            static void Main()
            {
                var fish = new Fish();
                fish.Weight = 10;
                fish.Feed(15);
                Console.WriteLine(fish.Weight);
            }
        } */
    /*  속성에서 ?.와 ?? 연산자를 함께 사용하기
        public class Person
        {
            public string? Name { get; set; }
            public Address? Address { get; set; }
        }

        public class Address
        {
            public string Street { get; set; } = "알 수 없음";
        }

        internal class Program
        {
            static void Main()
            {
                var people = new Person[] { new Person { Name = "RedPlus" }, null };

                void ProcessPeople(IEnumerable<Person> peopleArray)
                {
                    foreach (var person in peopleArray)
                        Console.WriteLine($"{person?.Name ?? "아무개"}은(는) {person?.Address?.Street}에 삽니다.");
                }
                ProcessPeople(people);

                var otherPeople = null as Person[];
                Console.WriteLine($"첫 번째 사람 : {otherPeople?[0]?.Name ?? "없음"}");
            }
        } */
    /*  정수형 인덱서 만들기
        public class Catalog
        {
            public string this[int index]
            {
                get { return (index % 2 == 0) ? $"{index} : 짝수 반환" : $"{index} : 홀수 반환"; }
            }
        }

        internal class Program
        {
            static void Main()
            {
                Catalog catalog = new();

                Console.WriteLine(catalog[0]);
                Console.WriteLine(catalog[1]);
                Console.WriteLine(catalog[2]);
            }
        } */
    /*  
        public class Developer
        {
            private string? name;
            public string? this[int index]
            {
                get { return name; }
                set { name = value; }
            }
        }

        internal class Program
        {
            static void Main()
            {
                var developer = new Developer();
                developer[0] = "백승수";
                Console.WriteLine(developer[0]);
                developer[1] = "이세영";
                Console.WriteLine(developer[1]);
            }
        } */

    /*  문제 1번 델리게이트
    delegate int MyDelegate(int a, int b);

    public class Calculator
    {
        public int Plus(int a, int b) => a + b;
        public static int Minus(int a, int b) => a - b;
    }
    internal class Program
    {
        static void Main()
        {
            Calculator cal = new();
            MyDelegate del = new(cal.Plus);
            Console.WriteLine(del(3, 4));
            del = new(Calculator.Minus);
            Console.WriteLine(del(4, 2));
        }
    }*/
    /*  문제 2번 델리게이트 메서드
    delegate int Compare(int a, int b);
    internal class Program
    {
        static int AscendCompare(int a, int b)
        {
            if (a > b) return 1;
            else if (a == b) return 0;
            else return -1;
        }
        static int DescendCompare(int a, int b)
        {
            if (a < b) return 1;
            else if (a == b) return 0;
            else return -1;
        }

        static void BubbleSort(int[] DataSet, Compare Comparer)
        {
            int i, j, temp;
            for (i = 0; i < DataSet.Length - 1; i++)
            {
                for (j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (Comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] array = [ 3, 7, 4, 2, 10, 1, 5, 15, 8 ];

            Console.WriteLine("Sorting ascending");
            BubbleSort(array, AscendCompare);
            foreach (int a in array)
                Console.Write(a + " ");
            Console.WriteLine();

            Console.WriteLine("Sorting descending");
            BubbleSort(array, DescendCompare);
            foreach (int a in array)
                Console.Write(a + " ");
            Console.WriteLine();
        }
    }*/
    /*  문제 3번 델리게이트 메서드 일반화
    delegate int Compare<T>(T a, T b);
    internal class Program
    {
        static int AscendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b);
        }
        static int DescendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b);
        }

        static void BubbleSort<T>(T[] DataSet, Compare<T> Comparer)
        {
            int i, j;
            T temp;
            for (i = 0; i < DataSet.Length - 1; i++)
            {
                for (j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (Comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }

        static void Main()
        {
            int[] array = [3, 7, 4, 2, 10];
            Console.WriteLine("Sorting ascending...");
            BubbleSort(array, AscendCompare);
            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");

            string[] array2 = ["abc", "def", "ghi", "jkl", "mno"];
            Console.WriteLine("\nSorting descending...");
            BubbleSort(array2, DescendCompare);
            for (int i = 0; i < array2.Length; i++)
                Console.Write($"{array2[i]} ");
            Console.WriteLine();
        }
    }*/
}
