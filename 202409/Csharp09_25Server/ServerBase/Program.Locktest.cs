namespace ServerBase
{
    /*  SpinLock
    public class SpinlockTest
    {
        public volatile int locked = 0;

        public void Acquire()
        {
            while (true)
            {
                // // 범용적으로 많이 쓰이는 방법 중 하나.
                // int origin = Interlocked.Exchange(ref locked, 1);
                // if (origin == 0)
                //     break;          
                int origin = Interlocked.CompareExchange(ref locked, 1, 0);
                if (origin == 0)
                    break;
            }
        }

        public void Release()
        {
            locked = 0;
        }
    }

    public class Program
    {
        static int num = 0;
        static SpinlockTest spinLockTest = new();

        static void ThreadA()
        {
            for (int i = 0; i < 10_000_000; i++)
            {
                spinLockTest.Acquire();
                num++;
                spinLockTest.Release();
            }
        }

        static void ThreadB()
        {
            for (int i = 0; i < 10_000_000; i++)
            {
                spinLockTest.Acquire();
                num--;
                spinLockTest.Release();
            }
        }

        static void Main(string[] args)
        {
            Task t1 = new(ThreadA);
            Task t2 = new(ThreadB);
            t1.Start();
            t2.Start();

            Task.WaitAll(t1, t2);
            Console.WriteLine(num);
        }
    } */
    /*  Context Switching
    public class SpinlockTest
    {
        public volatile int locked = 0;

        public void Acquire()
        {
            while (true)
            {    
                int origin = Interlocked.CompareExchange(ref locked, 1, 0);
                if (origin == 0)
                    break;
                // Thread.Sleep(1);
                // Thread.Sleep(0);
                // Thread.Yield();
            }
        }

        public void Release()
        {
            locked = 0;
        }
    }

    public class Program
    {
        static int num = 0;
        static SpinlockTest spinLockTest = new();

        static void ThreadA()
        {
            for (int i = 0; i < 1_000_000; i++)
            {
                spinLockTest.Acquire();
                num++;
                spinLockTest.Release();
            }
        }

        static void ThreadB()
        {
            for (int i = 0; i < 1_000_000; i++)
            {
                spinLockTest.Acquire();
                num--;
                spinLockTest.Release();
            }
        }

        static void Main(string[] args)
        {
            Task t1 = new(ThreadA);
            Task t2 = new(ThreadB);
            t1.Start();
            t2.Start();

            Task.WaitAll(t1, t2);
            Console.WriteLine(num);
        }
    } */
    //  AutoResetEvent
    // class LockTest
    // {
    //     // // 문을 열어놓고 있으면 true, 닫혀있으면 false 로 초기화
    //     // // AutoResetEvent은 자동으로 문을 닫아준다.
    //     // // 운영체제가 제공하는 기능을 사용하는 것이기 때문에 volatile 키워드를 사용하지 않아도 된다.
    //     // private AutoResetEvent available = new(true);

    //     // MaualResetEvent은 자동으로 문을 닫아주지 않는다.
    //     private ManualResetEvent available = new(true);

    //     public void Acquire()
    //     {
    //         available.WaitOne();    // 문이 닫혀있으면 대기. 문이 열리면 통과 (입장을 시도)
    //         available.Reset();      // 문을 닫아준다. (입장)
    //     }

    //     public void Release()
    //     {
    //         available.Set();        // 문을 열어준다. (퇴장)
    //     }
    // }

    // internal class Program
    // {
    //     static int num = 0;
    //     static Mutex mutexTest = new();
    //     // Mutex는 처리 속도가 느리다. (AutoResetEvent, SpinLock, Semaphore)

    //     static void ThreadA()
    //     {
    //         for (int i = 0; i < 1_000_000; i++)
    //         {
    //             mutexTest.WaitOne();
    //             num++;
    //             mutexTest.ReleaseMutex();
    //         }
    //     }

    //     static void ThreadB()
    //     {
    //         for (int i = 0; i < 1_000_000; i++)
    //         {
    //             mutexTest.WaitOne();
    //             num--;
    //             mutexTest.ReleaseMutex();
    //         }
    //     }

    //     static void Main()
    //     {
    //         Task t1 = new(ThreadA);
    //         Task t2 = new(ThreadB);
    //         t1.Start();
    //         t2.Start();

    //         Task.WaitAll(t1, t2);
    //         Console.WriteLine(num);
    //     }
    // }

}