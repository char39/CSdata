using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp07_25NETCORE
{
    /*  델리게이트 기초 예제
    delegate int MyDelegate(int a, int b);  // 반환형이 int이고 매개변수가 int형인 메서드를 참조할 수 있는 대리자 선언.

    class Calculator
    {
        public int Plus(int x, int y)   // 더하기 함수
        {
            return x + y;
        }
        public int Minus(int x, int y)  // 빼기 함수
        {
            return x - y;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new();                             // Calculator 객체 생성
            MyDelegate callback;                                // 대리자 객체 생성
            callback = new MyDelegate(cal.Plus);                // Plus 메서드 참조
            Console.WriteLine(callback(3, 4));                  // Plus 메서드 호출
            callback = new MyDelegate(cal.Minus);               // Minus 메서드 참조
            Console.WriteLine(callback(15, 4));                  // Minus 메서드 호출
        }
    }*/
    /*  델리게이트 오름, 내림차순 정렬 예제 [자료형 int only]
    delegate int Compare(int a, int b);

    internal class Program
    {
        static int AscendCompare(int x, int y)  // 오름차순으로 정렬하는 메서드
        {
            if (x > y) return 1;
            else if (x == y) return 0;
            else return -1;
        }
        static int DecendCompare(int x, int y)  // 내림차순으로 정렬하는 메서드
        {
            if (x < y) return 1;
            else if (x == y) return 0;
            else return -1;
        }
        static void BubbleSort(int[] DataSet, Compare compare)  // 오름, 내림차순으로 정렬하는 메서드를 참조하여 모든 배열값을 정렬함. 
        {
            int i, j, temp;                                         // 배열 index값을 사용하는 i, j를 선언, 임시변수 선언.
            for (i = 0; i < DataSet.Length - 1; i++)                // 배열길이의 1을 빼는 이유는 (index 0)의 값이 (index max)까지 이동을 하려면 마지막 배열 값은 사용할 필요가 없기 때문.
            {
                for (j = 0; j < DataSet.Length - (i + 1); j++)      // 위와 같은 내용이나, 하나의 값이 정렬된 회 수마다 앞의 값은 비교할 필요가 없기 때문.
                {
                    if (compare(DataSet[j], DataSet[j + 1]) > 0)    // 비교한 값이 0보다 크면
                    {
                        temp = DataSet[j + 1];                      // 임시변수에 뒤의 값을 저장
                        DataSet[j + 1] = DataSet[j];                // 뒤의 값을 앞의 값으로 변경
                        DataSet[j] = temp;                          // 앞의 값을 임시변수에 저장한 뒤 뒤의 값으로 변경
                    }
                }
            }
        }

        static void Main()
        {
            int[] numbers = { 2, 8, 5, 7, 3, 9, 1 };

            foreach(int num in numbers)         // 모든 배열값 출력
                Console.Write($"{num} ");       //
            Console.WriteLine();                //

            BubbleSort(numbers, AscendCompare); // 오름차순으로 모든 배열값 정렬
            
            foreach(int num in numbers)         // 모든 배열값 출력
                Console.Write($"{num} ");       //
            Console.WriteLine();                //

            BubbleSort(numbers, DecendCompare); // 내림차순으로 모든 배열값 정렬
            
            foreach(int num in numbers)         // 모든 배열값 출력
                Console.Write($"{num} ");       //
            Console.WriteLine();                //
        }
    } */
    /*  델리게이트 오름, 내림차순 정렬 예제 [모든 자료형, 로컬함수]
    delegate int Compare<T>(T a, T b);

    internal class Program
    {
        static int AscendCompare<T>(T x, T y) where T : IComparable<T> // 오름차순으로 정렬하는 메서드
        {
            return x.CompareTo(y);              // IComparable 인터페이스를 상속받은 클래스만 사용가능하도록 제약을 걸어줌.
        }
        static int DecendCompare<T>(T x, T y) where T : IComparable<T> // 내림차순으로 정렬하는 메서드
        {
            return x.CompareTo(y) * (-1);       // IComparable 인터페이스를 상속받은 클래스만 사용가능하도록 제약을 걸어줌.
        }
        static void BubbleSort<T>(T[] DataSet, Compare<T> compare)  // 오름, 내림차순으로 정렬하는 메서드를 참조하여 모든 배열값을 정렬함. 
        {
            int i, j;                           // 배열 index값을 사용하는 i, j를 선언,
            T temp;                             // 모든 자료형의 임시변수 선언.
            for (i = 0; i < DataSet.Length - 1; i++)                // 배열길이의 1을 빼는 이유는 (index 0)의 값이 (index max)까지 이동을 하려면 마지막 배열 값은 사용할 필요가 없기 때문.
            {
                for (j = 0; j < DataSet.Length - (i + 1); j++)      // 위와 같은 내용이나, 하나의 값이 정렬된 회 수마다 앞의 값은 비교할 필요가 없기 때문.
                {
                    if (compare(DataSet[j], DataSet[j + 1]) > 0)    // 비교한 값이 0보다 크면
                    {
                        temp = DataSet[j + 1];                      // 임시변수에 뒤의 값을 저장
                        DataSet[j + 1] = DataSet[j];                // 뒤의 값을 앞의 값으로 변경
                        DataSet[j] = temp;                          // 앞의 값을 임시변수에 저장한 뒤 뒤의 값으로 변경
                    }
                }
            }
        }

        static void Main()
        {
            string[] array_str = { "y", "i", "b", "s", "J", "X", "S" };
            
            WriteAll(ref array_str);
            BubbleSort(array_str, AscendCompare);
            WriteAll(ref array_str);            

            static void WriteAll<T>(ref T[] array)      // 모든 배열 값들을 출력하는 로컬 함수
            {
                foreach (var arr in array)
                    Console.Write($"{arr} ");
                Console.WriteLine();
            }
        }
    }*/
    /*  델리게이트 체인 : 대리자 하나가 여러 개의 메서드를 동시에 참조할 수 있다.
    delegate void Notify(string message);

    class Notifier
    {
        public Notify EventOccured;
    }

    class EventListener
    {
        private string name;
        public EventListener(string name)
        {
            this.name = name;
        }
        public void SomeThingHappened(string message)
        {
            Console.WriteLine($"{name}.SomeThingHappened : {message}");
        }
    }

    internal class Program
    {
        static void Main()
        {
            Notifier notifier = new();
            EventListener listener1 = new EventListener("Listener1");
            EventListener listener2 = new EventListener("Listener2");
            EventListener listener3 = new EventListener("Listener3");
            Console.WriteLine();
            notifier.EventOccured += listener1.SomeThingHappened;
            notifier.EventOccured += listener2.SomeThingHappened;
            notifier.EventOccured += listener3.SomeThingHappened;
            notifier.EventOccured("You've got mail");
            Console.WriteLine();

            notifier.EventOccured -= listener2.SomeThingHappened;
            notifier.EventOccured("-= Listener2");
            Console.WriteLine();

            notifier.EventOccured = new Notify(listener1.SomeThingHappened) + new Notify(listener2.SomeThingHappened) + new Notify(listener3.SomeThingHappened);
            notifier.EventOccured("Nuclear launch detected.");
            Console.WriteLine();
            
            Notify notify1 = new Notify(listener1.SomeThingHappened);
            Notify notify2 = new Notify(listener2.SomeThingHappened);
            notifier.EventOccured = (Notify)Delegate.Combine(notify1, notify2);
            notifier.EventOccured("Fire!");
            Console.WriteLine();
            
            notifier.EventOccured = (Notify)Delegate.Remove(notifier.EventOccured, notify2);
            notifier.EventOccured("RPG");
        }
    }*/
    /*  델리게이트 익명 예제
    delegate int Compare(int a, int b);

    internal class Program
    {
        static void BubbleSort(int[] DataSet, Compare compare)  // 오름, 내림차순으로 정렬하는 메서드를 참조하여 모든 배열값을 정렬함. 
        {
            int i, j, temp;                                         // 배열 index값을 사용하는 i, j를 선언, 임시변수 선언.
            for (i = 0; i < DataSet.Length - 1; i++)                // 배열길이의 1을 빼는 이유는 (index 0)의 값이 (index max)까지 이동을 하려면 마지막 배열 값은 사용할 필요가 없기 때문.
            {
                for (j = 0; j < DataSet.Length - (i + 1); j++)      // 위와 같은 내용이나, 하나의 값이 정렬된 회 수마다 앞의 값은 비교할 필요가 없기 때문.
                {
                    if (compare(DataSet[j], DataSet[j + 1]) > 0)    // 비교한 값이 0보다 크면
                    {
                        temp = DataSet[j + 1];                      // 임시변수에 뒤의 값을 저장
                        DataSet[j + 1] = DataSet[j];                // 뒤의 값을 앞의 값으로 변경
                        DataSet[j] = temp;                          // 앞의 값을 임시변수에 저장한 뒤 뒤의 값으로 변경
                    }
                }
            }
        }

        static void Main()
        {
            int[] array_int = { 3, 7, 4, 2, 10 };
            WriteAll(ref array_int);

            Console.WriteLine("익명의 함수로 오름차순 정렬 실행.");
            BubbleSort(array_int, delegate (int a, int b)
            {
                if (a > b) return 1;
                else if (a == b) return 0;
                else return -1;
            });
            WriteAll(ref array_int);

            Console.WriteLine("익명의 함수로 내림차순 정렬 실행.");
            BubbleSort(array_int, delegate (int a, int b)
            {
                if (a < b) return 1;
                else if (a == b) return 0;
                else return -1;
            });
            WriteAll(ref array_int);

            static void WriteAll<T>(ref T[] array)      // 모든 배열 값들을 출력하는 로컬 함수
            {
                foreach (var arr in array)
                    Console.Write($"{arr} ");
                Console.WriteLine();
            }
        }
    }*/
    /*  델리게이트 익명 예제2
    delegate int Calculator(int a, int b);  // 반환형이 int이고 매개변수가 int형인 메서드를 참조할 수 있는 대리자 선언.

    internal class Program
    {
        static void Main()
        {
            Calculator cal;                 // 대리자 객체 생성
            cal = delegate (int a, int b)   // 대리자 객체에 익명 메서드를 대입
            {
                return a + b;                  
            };
            Console.WriteLine(cal(3, 6));   // 대리자 객체 호출

            cal = delegate (int a, int b)   // 대리자 객체에 익명 메서드를 대입
            {
                return a - b;               
            };
            Console.WriteLine(cal(3, 6));   // 대리자 객체 호출
        }
    }*/
    /*  델리게이트 이벤트 예제
    delegate void EventHandler(string message);     // 대리자 선언

    class MyNotifier
    {
        public event EventHandler SomeThingHappened;    // 이벤트 선언
        public void DoSomeThingHappened(int number)     // 이벤트 발생 메서드
        {
            int temp = number % 10;
            if (temp != 0 && temp % 3 == 0)
            {
                SomeThingHappened(string.Format($"{number} : 짝"));
            }
        }
    }

    internal class Program
    {
        static public void MyHandler(string message)        // 이벤트 핸들러 메서드
        {
            Console.WriteLine(message);                // 이벤트 메시지 출력
        }

        static void Main()
        {
            MyNotifier myNotifier = new();              // 이벤트 객체 생성
            myNotifier.SomeThingHappened += new EventHandler(MyHandler);    // 이벤트 핸들러 등록
            for (int i = 0; i < 30; i++)
                myNotifier.DoSomeThingHappened(i);
        }
    } */
    /*  델리게이트 이벤트 문제
    delegate void MyDelegate(int a);

    class Market
    {
        public event MyDelegate CustomerEvent;
        public void BuySomeThing(int CustomerNo)
        {
            if (CustomerNo == 30)
                CustomerEvent(CustomerNo);
        }
    }

    internal class Program
    {
        static public void MyHandler(int message)
        {
            Console.WriteLine("축하합니다! " + message + "번째 고객 이벤트에 당첨되셨습니다.");
        }

        static void Main()
        {
            Market market = new();
            market.CustomerEvent += new MyDelegate(MyHandler);
            for (int customerNo = 0; customerNo < 100; customerNo += 10)
                market.BuySomeThing(customerNo);
        }
    }*/

    internal class Program
    {
        static void Main()
        {
            
        }
    }
}
