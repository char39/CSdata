namespace Csharp07_17NETCORE
{
    /*  무명 형식
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new { Name = "박지성", Age = 44};
            Console.WriteLine($"이름: {a.Name}, 나이: {a.Age}");
            var b = new { Subject = "수학", Scores = new int[] { 90, 80, 70, 60 } };
            Console.WriteLine($"과목: {b.Subject}");
            foreach (var score in b.Scores)
            {
                Console.WriteLine($"점수: {score}");
            }
            Console.WriteLine();
        }
    }
    */
    /*  인터페이스에 프로퍼티
    interface INameValue
    {
        string Name { get; set; }   // 프로퍼티
        string Value { get; set; }  // 프로퍼티
    }
    class NamedValue : INameValue
    {
        public string Name
        {
            get;
            set;
        }
        public string Value
        {
            get;
            set;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            NamedValue name = new NamedValue()
            {
                Name = "Phone", Value = "IPhone 12 Pro"
            };
            NamedValue height = new NamedValue()
            {
                Name = "키", Value = "170cm"
            };
            NamedValue weight = new NamedValue()
            {
                Name = "몸무게", Value = "55kg"
            };

            Console.WriteLine("{0} : {1}", name.Name, name.Value);
            Console.WriteLine("{0} : {1}", height.Name, height.Value);
            Console.WriteLine("{0} : {1}", weight.Name, weight.Value);
            
        }
    }
    */
    /*  추상 클래스, 추상 프로퍼티
    public abstract class Product                   // 추상 클래스
    {
        private static int serial = 0;
        public string? serialID
        {
            get { return string.Format("{0:d5}", serial++); }
        }
        public abstract DateTime ProductDate        // 추상 프로퍼티
        {
            get;
            set;
        }
    }
    class MyProduct : Product
    {
        public override DateTime ProductDate
        {
            get;
            set;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new MyProduct()
            {
                ProductDate = new DateTime(2024, 07, 17)
            };
            Console.WriteLine("Product : {0}, Product Date : {1}", product1.serialID, product1.ProductDate);

            Product product2 = new MyProduct()
            {
                ProductDate = new DateTime(2020, 07, 01)
            };
            Console.WriteLine("Product : {0}, Product Date : {1}", product2.serialID, product2.ProductDate);
        }
    }
    */

    /*  0717_3 문제 1번
    internal class Program
    {
        static void Main()
        {
            var nameCard = new {Name = "박상현", Age = 17};
            Console.WriteLine("이름 : {0}, 나이 : {1}", nameCard.Name, nameCard.Age);

            var complex = new {Real = 3, Imaginary = -12};
            Console.WriteLine("Real : {0}, Imaginary : {1}", complex.Real, complex.Imaginary);
        }
    }
    */
    /*  0717_3 문제 2번
    internal class Program
    {
        static void Main()
        {
            int[] scores = new int[5];
            scores[0] = 80;
            scores[1] = 74;
            scores[2] = 81;
            scores[3] = 90;
            scores[4] = 34;

            // 점수를 각각 출력하고 합계를 구하고 평균을 구하기
            int sum = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine($"{i + 1}번 점수 : {scores[i]}");
                sum += scores[i];
            }
            Console.WriteLine($"점수 합계 : {sum}");
            Console.WriteLine($"점수 평균 : {sum / scores.Length}");
        }
    }
    */
    /*  0717_3 문제 3번
    internal class Program
    {
        static void Main()
        {
            // 2단부터 9단까지 결과값을 2차원 배열에 넣어 출력.
            // [행][열] 행에 8개의 단, 9개의 결과값
            // 0,0은 2단, 1번째
            // 7,8은 9단, 9번째

            int[,] dan = new int[8, 9];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    dan[i, j] = (i + 2) * (j + 1);
                    Console.Write($"{dan[i, j].ToString().PadLeft(2)} ");
                }
                Console.WriteLine();
            }
        }
    }
    */
    /* 배열 Array 관련 함수들 [아주 많음 주의]
    internal class Program
    {
        private static bool CheckPassed(int score)  // 리턴 조건에 충족하면 bool 값은 true.
        {
            return score >= 60;
        }
        private static void Print(int value)        // 출력 함수
        {
            Console.Write($"{value} ");
        }

        static void Main()
        {
            int[] scores = new int[] { 80, 74, 81, 90, 34 };
            List<string> list = new List<string>();
            foreach (int score in scores)
                Console.Write(score + " ");                                                         // 1번째줄 출력
            Console.WriteLine();

            Array.Sort(scores); // 배열을 오름차순으로 정렬
            Array.ForEach<int>(scores, new Action<int>(Print));                                     // 2번째줄 출력
                // 배열 전체를 출력
            Console.WriteLine();
            Console.WriteLine($"Number of dimensions : {scores.Rank}");                             // 3번째줄 출력
                // 배열의 [몇]차원을 반환
            Console.WriteLine($"Binary Search : 81 is at {Array.BinarySearch<int>(scores, 81)}");   // 4번째줄 출력
                // 이진 탐색 알고리즘 메서드로 원하는 값 찾기
                    // ex) 1부터 5까지 있는데 2를 찾는다 하면,
                    //  (1+5)/2 = 3이 나오는데, 3은 2보다 크니 3이상은 버리고
                    //  (1+2)/2 = 1.5가 나오는데, 1.5는 2보다 작으니 1.5 이하는 버림.
                    //  근데 1.5 초과, 2 이하는 2밖에 없으니 2가 원하는 값.
            Console.WriteLine($"Linear Search : 90 is at {Array.IndexOf(scores, 90)}");             // 5번째줄 출력
                // 선형 탐색. 순서대로 찾기
            Console.WriteLine($"Everyone passed ? : {Array.TrueForAll<int>(scores, CheckPassed)}"); // 6번째줄 출력
                // 배열의 모든 요소가 지정된 조건에 부합하는지 여부 반환. CheckPassed의 반환값이 전부 true라면 true.
            int index = Array.FindIndex<int>(scores, (score) => score < 60);
            scores[index] = 61;
            Console.WriteLine($"Everyone passed ? : {Array.TrueForAll<int>(scores, CheckPassed)}"); // 7번째줄 출력
                // scores 배열의 값 중 60 미만의 첫 번째 배열의 값을 61로 바꾸어줌.
                // 해당하는 배열의 값이 없을 경우 -1을 반환
            Console.WriteLine($"Old length of scores : {scores.GetLength(0)}");                     // 8번째줄 출력
                // 배열 요소의 개수를 반환
            Array.Resize<int>(ref scores, 10);
            Console.WriteLine($"New length of scores : {scores.Length}");                           // 9번째줄 출력
                // 배열 요소의 개수를 10개로 변경한 후, 새로운 배열 요소의 개수를 반환
            Array.ForEach<int>(scores, new Action<int>(Print));                                     // 10번째줄 출력
                // 배열 전체를 출력
            Console.WriteLine();
            Array.Clear(scores, 3, 7);
            Array.ForEach<int>(scores, new Action<int>(Print));                                     // 11번째줄 출력
                // 배열의 3번 index 부터 그 뒤의 7개의 요소를 0으로 초기화
            Console.WriteLine();
            int[] sliced = new int[3];
            Array.Copy(scores, 0, sliced, 0, 3);
            Array.ForEach<int>(sliced, new Action<int>(Print));                                     // 12번째줄 출력
                // 1차원 배열 개수 3개인 sliced 변수를 선언하고,
                // scores배열의 0번 index 부터 시작하여 3개의 요소를 sliced 배열의 0번 index 부터 복사함.
                // 그리고 배열 전체를 출력.
            Console.WriteLine();
        }
    }
    */



}
