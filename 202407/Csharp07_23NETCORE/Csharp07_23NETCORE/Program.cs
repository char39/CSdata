using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp07_23NETCORE
{
    /* class MyList : IEnumerable, IEnumerator
    {
        private int[] array;
        int position = -1;  // 0이 초기값이어서
        public MyList()
        {
            Console.WriteLine($"void 생성자 호출");
            array = new int[5];
            Console.WriteLine($"array.Length : {array.Length}");
        }

        public int this[int index]
        {
            get { return array[index]; }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine($"array.Length : {array.Length}");
                }
                array[index] = value;
            }
        }

        public int Length
        {
            get { return array.Length; }
        }

        public object Current
        {
            get { return array[position]; }
        }

        public IEnumerator GetEnumerator()          // IEnumerable의 멤버
        {
            return this;
        }

        public bool MoveNext()                      // IEnumerator의 멤버 MoveNext 메서드
        {
            if (position == array.Length - 1)
            {
                Reset();
                return false;
            }
            else
            {
                position++;
                return position < array.Length;
            }
        }

        public void Reset()
        {
            position = -1;
        }
    }

    class MyEnumerator
    {
        int[] numbers = { 1, 2, 3, 4 };
        public IEnumerator GetEnumerator()
        {
            yield return numbers[0];
            yield return numbers[1];
            yield return numbers[2];
            yield break;                // 메서드 즉시 종료
            yield return numbers[3];
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();     // 동적 할당으로 인하여 void 생성자 자동으로 호출됨
            for (int i = 1; i < 8; i++)
                list[i] = i;
            for (int i = 0; i < list.Length; i++)
                Console.Write(list[i] + " ");
            // foreach (int i in list)
            //     Console.Write($"{i.ToString()} "); 
            Console.WriteLine();
            
            var obj = new MyEnumerator();
            foreach (int i in obj)
                Console.WriteLine(i);
        }
    }
    */
    /* internal class Program
    {
        static void Main()
        {
            CopyMethod copyMethod = new CopyMethod();
            // 객체가 자료형마다 한 개씩 생성된다. 후에 동일한 자료형을 사용하여 불러와도 추가로 생성하지 않는다.
            // ex) copyMethod.CopyArray<자료형>(매개변수들); 와 같은 것을 의미함

            int[] source = { 1, 2, 3, 4, 5 };
            int[] target = new int[source.Length];
            copyMethod.CopyArray<int>(source, target);
            foreach (int i in target)
                Console.Write(i + " ");
            Console.WriteLine("");

            double[] source_d = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            double[] target_d = new double[source_d.Length];
            copyMethod.CopyArray<double>(source_d, target_d);
            foreach (double i in target_d)
                Console.Write(i + " ");
            Console.WriteLine("");

            string[] source_s = { "a", "b", "c", "d", "e" };
            string[] target_s = new string[source_s.Length];
            copyMethod.CopyArray<string>(source_s, target_s);
            foreach (string i in target_s)
                Console.Write(i + " ");
            Console.WriteLine("");
        }
    } */
    /* class MyList<T>  // T는 자료형을 결정하지 않겠다라는 의미.
    {
        private T[] array;
        //int position = -1;  // 0이 초기값이어서
        public MyList()
        {
            Console.WriteLine($"void 생성자 호출");
            array = new T[5];
            Console.WriteLine($"array.Length : {array.Length}");
        }

        public T this[int index]
        {
            get { return array[index]; }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<T>(ref array, index + 1);
                    Console.WriteLine($"array.Length : {array.Length}");
                }
                array[index] = value;
            }
        }

        public int Length
        {
            get { return array.Length; }
        }

        // public object Current
        // {
        //     get { return array[position]; }
        // }

        // public IEnumerator GetEnumerator()          // IEnumerable의 멤버
        // {
        //     return this;
        // }

        // public bool MoveNext()                      // IEnumerator의 멤버 MoveNext 메서드
        // {
        //     if (position == array.Length - 1)
        //     {
        //         Reset();
        //         return false;
        //     }
        //     else
        //     {
        //         position++;
        //         return position < array.Length;
        //     }
        // }

        // public void Reset()
        // {
        //     position = -1;
        // }
    }

    internal class Program
    {
        static void Main()
        {
            MyList<string> list_str = new MyList<string>();
            list_str[0] = "q";
            list_str[1] = "w";
            list_str[2] = "e";
            for (int i = 0; i < list_str.Length; i++)
                Console.WriteLine(list_str[i]);

            MyList<int> list_int = new();
            for (int i = 0; i < 9; i++)
                list_int[i] = i + 10;
            for (int i = 0; i < list_int.Length; i++)
                Console.WriteLine(list_int[i]);
        }
    } */
    /* class StructArray<T> where T : struct   // 이 클래스는 값 형식 데이터만 받겠다라는 의미
    {
        public T[] Array { get; set; }  // 자동 프로퍼티
        public StructArray(int size)    // 매개변수가 있는 생성자
        {
            Array = new T[size];        // 배열을 생성
        }
    }

    class RefArray<T> where T : class       // 이 클래스는 참조 형식 데이터만 받겠다라는 의미
    {
        public T[] Array { get; set; }  // 자동 프로퍼티
        public RefArray(int size)       // 매개변수가 있는 생성자
        {
            Array = new T[size];        // 배열을 생성
        }
    }

    class Base { }                              // Base 클래스
    class Derived : Base { }                    // Base 클래스를 상속받은 Derived 클래스
    class BaseArray<U> where U : Base       // 이 클래스는 반드시 Base 클래스를 상속받은 타입만 받겠다라는 의미
    {
        public U[] Array { get; set; }  // 자동 프로퍼티
        public BaseArray(int size)      // 매개변수가 있는 생성자
        {
            Array = new U[size];        // 배열을 생성
        }
        public void CopyArray<T>(T[] Source) where T : U    // U로 제약된 타입 T를 매개변수로 받는 CopyArray 메서드
        {
            Source.CopyTo(Array, 0);    // 배열 복사
        }
    }

    internal class Program
    {
        public static T CreateInstance<T>() where T : new() // T는 반드시 기본 생성자를 가진 클래스여야 한다. (매개변수가 없는 생성자)
        {
            return new T();             // T 타입의 인스턴스를 생성하여 반환
        }

        static void Main()
        {
            Console.WriteLine();

            StructArray<int> structArr_int = new StructArray<int>(3);
            for (int i = 0; i < structArr_int.Array.Length; i++)
                structArr_int.Array[i] = i;
            for (int i = 0; i < structArr_int.Array.Length; i++)
                Console.Write(structArr_int.Array[i] + "\n");
            Console.WriteLine();

            RefArray<StructArray<double>> refArr_dou = new RefArray<StructArray<double>>(3);
            refArr_dou.Array[0] = new StructArray<double>(5);
            refArr_dou.Array[1] = new StructArray<double>(10);
            refArr_dou.Array[2] = new StructArray<double>(1005);
            for (int i = 0; i < refArr_dou.Array.Length; i++)
                Console.Write(refArr_dou.Array[i] + "\n");
            Console.WriteLine();
            
            BaseArray<Base> baseArr = new BaseArray<Base>(3);
            baseArr.Array[0] = new Base();
            baseArr.Array[1] = new Derived();
            baseArr.Array[2] = CreateInstance<Base>();
            for (int i = 0; i < baseArr.Array.Length; i++)
                Console.Write(baseArr.Array[i] + "\n");
            Console.WriteLine();

            BaseArray<Derived> baseArr_der = new BaseArray<Derived>(3);
            baseArr_der.Array[0] = new Derived();
            baseArr_der.Array[1] = CreateInstance<Derived>();
            baseArr_der.Array[2] = CreateInstance<Derived>();
            for (int i = 0; i < baseArr_der.Array.Length; i++)
                Console.Write(baseArr_der.Array[i] + "\n");
            Console.WriteLine();
        }
    } */
    /* internal class Program   // List사용 예시
    {
        static void Main()
        {
            Console.WriteLine();

            List<int> list = new();

            for (int i = 0; i < 5; i++)
                list.Add(i);
            foreach (int i in list)
                Console.Write(i.ToString() + " ");

            Console.Write("\n삭제할 Index값을 적어주세요. : ");
            int remove = Int32.Parse(Console.ReadLine());
            list.RemoveAt(remove);
            foreach (int i in list)
                Console.Write(i.ToString() + " ");
            
            Console.Write("\nList Insert(,) \n");
            list.Insert(0, 0);
            foreach (int i in list)
                Console.Write(i.ToString() + " ");

            Console.Write("\nList Clear() \n");
            list.Clear();
            foreach (int i in list)
                Console.Write(i.ToString() + " ");
            
            Console.WriteLine();
        }
    }*/
    /* List에서 T 사용 예시
    class MyList<T> : IEnumerable<T>, IEnumerator<T>
    {
        private T[] array;
        int position = -1;  // 0이 초기값이어서
        public MyList()
        {
            Console.WriteLine($"void 생성자 호출");
            array = new T[5];
            Console.WriteLine($"array.Length : {array.Length}");
        }

        public T this[int index]
        {
            get { return array[index]; }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<T>(ref array, index + 1);
                    Console.WriteLine($"array.Length : {array.Length}");
                }
                array[index] = value;
            }
        }

        public int Length
        {
            get { return array.Length; }
        }

        public T Current
        {
            get { return array[position]; }
        }

        object IEnumerator.Current
        {
            get { return array[position];}
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (position == array.Length - 1)
            {
                Reset();
                return false;
            }
            position++;
            return true;
        }
        public void Reset()
        {
            position = -1;
        }
        public void Dispose()
        {

        }

    }



    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> list_str = new();
            list_str[0] = "abc";
            list_str[1] = "def";
            list_str[2] = "ghi";
            foreach(string str in list_str)
                Console.WriteLine(str);
        }
    } */


    internal class Program
    {
        static void Main()
        {
            
        }
    }


}