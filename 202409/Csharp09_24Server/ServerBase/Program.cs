namespace ServerBase
{
    /*  멀티 쓰레드 관리. Lock (Monitor.Enter)
    internal class Program
    {
        static int number = 0;
        static long start;
        static long end;

        private static object lockObj = new();

        // Race Condition : 두 개 이상의 스레드가 동시에 같은 자원에 접근할 때 발생하는 문제
        static void ThreadA()
        {
            for (int i = 0; i < 1000000; i++)
            {
                Monitor.Enter(lockObj);
                number++;    // 실제로 아래와 같은 과정을 거친다.
                Monitor.Exit(lockObj);
                // int temp = number;
                // temp++;
                // number = temp;

                // 즉, 여러 쓰레드가 동시에 위와 같은 작업이 시작되면, 데이터 일관성이 깨질 수 있음.
                // 이러한 문제가 되는 코드들을 크리티컬 섹션이라고 하며, 임계영역이라고도 부른다. 이를 해결하기 위한 방법 중 하나가 Interlocked 이다.
            }
        }

        static void ThreadB()
        {
            for (int i = 0; i < 1000000; i++)
            {
                Monitor.Enter(lockObj);
                number--;
                Monitor.Exit(lockObj);
            }
        }

        static void Main(string[] args)
        {
            start = DateTime.Now.Ticks;

            Task task1 = new(ThreadA);
            Task task2 = new(ThreadB);

            task1.Start();
            task2.Start();

            Task.WaitAll(task1, task2);

            end = DateTime.Now.Ticks;

            Console.WriteLine($"{number}, {end - start}ms");
        }
    } */
    /*  멀티 쓰레드 관리. DeadLock이 발생하는 조건 (1)
    internal class Program
    {
        static int number = 0;

        static object lockObj = new();

        static void ThreadA()
        {
            for (int i = 0; i < 1000000; i++)
            {
                Monitor.Enter(lockObj);
                number++;
                return;
                Monitor.Exit(lockObj);      // DeadLock이 발생.
            }
        }

        static void ThreadB()
        {
            for (int i = 0; i < 1000000; i++)
            {
                Monitor.Enter(lockObj);
                number--;
                return;
                Monitor.Exit(lockObj);
            }
        }
        static void Main()
        {
            Task task1 = new(ThreadA);
            Task task2 = new(ThreadB);

            task1.Start();
            task2.Start();

            Task.WaitAll(task1, task2);

            Console.WriteLine(number);
        }
    } */
    /*  멀티 쓰레드 관리. Lock(lockObj) {}
    internal class Program
    {
        static int number = 0;
        static readonly object lockObj = new();

        static void ThreadA()
        {
            lock(lockObj)
            {
                for (int i = 0; i < 100_000; i++)
                    number++;
            }
        }

        static void ThreadB()
        {
            lock(lockObj)
            {
                for (int i = 0; i < 100_000; i++)
                    number--;
            }
        }

        static void Main()
        {
            Task task1 = new(ThreadA);
            Task task2 = new(ThreadB);
            task1.Start();
            task2.Start();
            Task.WaitAll(task1, task2);

            Console.WriteLine(number);
        }
    } */
    /*  멀티 쓰레드 관리. DeadLock이 발생하는 조건 (2)
    internal class Program
    {
        static readonly object lockObj1 = new();
        static readonly object lockObj2 = new();

        static void ThreadA()
        {
            lock(lockObj1)
            {
                Console.WriteLine("ThreadA acquired lockObj1");
                Thread.Sleep(100);
                lock(lockObj2)
                {
                    Console.WriteLine("ThreadA acquired lockObj2");
                }
            }
        }

        static void ThreadB()
        {
            lock(lockObj2)
            {
                Console.WriteLine("ThreadB acquired lockObj2");
                Thread.Sleep(100);
                lock(lockObj1)
                {
                    Console.WriteLine("ThreadB acquired lockObj1");
                }
            }
        }

        static void Main()
        {
            Thread t1 = new Thread(new ThreadStart(ThreadA));
            Thread t2 = new Thread(new ThreadStart(ThreadB));
            t1.Name = "Thread1";
            t2.Name = "Thread2";
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            Console.WriteLine("End.");
        }
    } */

    public class SessionManager
    {
        private static readonly object lockObj = new();
        public static void TestSession()
        {
            lock (lockObj)
            {

            }
        }

        public static void Test()
        {
            lock (lockObj)
            {
                UserManager.TestUser();
            }
        }
    }

    public class UserManager
    {
        private static readonly object lockObj = new() { };
        
        public static void TestUser()
        {
            lock (lockObj)
            {
                
            }
        }
        
        public static void Test()
        {
            // Monitor.TryEnter(lockObj);
            lock (lockObj)
            {
                SessionManager.TestSession();
            }
        }
    }

    internal class Program
    {
        static void ThreadA()
        {
            for (int i = 0; i < 100_000; i++)
            {
                SessionManager.Test();
            }
        }

        static void ThreadB()
        {
            for (int i = 0; i < 100_000; i++)
            {
                UserManager.Test();
            }
        }

        static void Main()
        {
            Task t1 = new(ThreadA);
            Task t2 = new(ThreadB);
            t1.Start();
            Thread.Sleep(100);
            t2.Start();
            Task.WaitAll(t1, t2);
            // 무책임한 코드 중 하나가 충돌이 날 때까지 데드락을 발생 시키는 코드.
            // 미리 예방하는 차원에서 설계하는게 좋다.
        }
    }



}