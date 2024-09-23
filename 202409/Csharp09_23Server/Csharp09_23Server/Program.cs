namespace ServerBase
{
    /*  volatile 키워드와 lock 키워드. (멀티쓰레드 환경에서의 데이터 일관성 문제 해결)

        internal class Program
        {
            // static으로 선언된 변수들은 멀티쓰레드 환경에서 접근이 가능.
            // 일반적으로 각 쓰레드는 자신만의 stack메모리를 가지고 있지만, heap메모리는 모든 쓰레드가 공유함. (stack메모리는 보통 구조체, heap메모리는 클래스)
            // 여러 쓰레드가 동시에 static 변수에 접근하면 데이터 일관성이 깨질수 있음.
            // 이를 방지하기 위해서 lock을 사용하여 동기화를 시켜주는 작업이 필요함.
            // lock을 사용하면 특정 코드 블록에 대한 접근을 한 번에 하나의 쓰레드만 허용하며, 동시 접근으로 인한 데이터 일관성 문제를 해결할 수 있다.

            // volatile은 휘발성이라는 의미로, 컴파일러가 최적화를 하지 않도록 하는 키워드.
            // 캐시 메모리를 무시하고 메인 메모리에서 데이터를 읽어오도록 함.
            // 임시방편으로 사용하는 것이 좋음. (lock을 사용하는 것이 더 좋음)
            volatile static bool _Stop = false;

            static void ThreadMain()
            {
                Console.WriteLine("쓰레드 시작");
                while (!_Stop)
                {
                    Console.WriteLine("쓰레드 동작중");
                    Thread.Sleep(200);
                }

                // Release 모드로 빌드하면 위의 코드가 아래 코드로 변경될 수도 있음.
                // if (!_Stop)
                // {
                //     while (true)
                //     {
                //         Console.WriteLine("쓰레드 동작중");
                //         Thread.Sleep(200);
                //     }
                // }

                Console.WriteLine("쓰레드 종료");
            }

            static void Main(string[] args)
            {
                Task task = new Task(ThreadMain);
                task.Start();
                Thread.Sleep(1000);
                _Stop = true;
                Console.WriteLine("Stop 호출");
                Console.WriteLine("종료 대기중");
                task.Wait();
                Console.WriteLine("종료 완료");
            }   
        } */
    /*  쓰레드의 동작 방식 설명을 위한 실행시간 측정 코드
        internal class Program
        {
            static void Main()
            {
                int[,] arr = new int[10_000, 10_000];
                {
                    long now = DateTime.Now.Ticks;          // 현재 시간을 나노초로 반환

                    for (int y = 0; y < 10_000; y++)
                        for (int x = 0; x < 10_000; x++)
                            arr[y, x] = 1;

                    long end = DateTime.Now.Ticks;
                    Console.WriteLine("종료 시간 : " + (end - now) + "ns --- (arr[y, x])");
                }
                {
                    long now = DateTime.Now.Ticks;

                    for (int y = 0; y < 10_000; y++)
                        for (int x = 0; x < 10_000; x++)
                            arr[x, y] = 1;

                    long end = DateTime.Now.Ticks;
                    Console.WriteLine("종료 시간 : " + (end - now) + "ns --- (arr[x, y])");
                }
            }
        } */
    /*  MemoryBarrier(), volatile 키워드와 lock 키워드. (멀티쓰레드 환경에서의 데이터 일관성 문제 해결), 경쟁 조건
    internal class Program
    {
        static volatile int x = 0;
        static volatile int y = 0;
        static volatile int r1 = 0;
        static volatile int r2 = 0;

        //     lock을 사용하여 동기화를 시켜주는 작업이 필요함.
        //     lock을 사용하면 특정 코드 블록에 대한 접근을 한 번에 하나의 쓰레드만 허용하며, 동시 접근으로 인한 데이터 일관성 문제를 해결할 수 있음.
        //     lockObj와 lock (lockObj)를 사용하지 않으면 경쟁 조건이 발생하여 r1, r2가 0이 아닌 값이 나올 수 있음.

        //     또한, Thread.MemoryBarrier()를 사용하여 코드 재배치 방지를 할 수도 있음.

        //     MemoryBarrier() : 메모리 액세스의 재배치를 방지하는 메서드
        //     1.  코드 재배치 방지
        //     2.  메모리 가시성 보장
        //     3.  메모리 액세스의 재배치를 방지
        //         (1) Full Memory Barrier : 모든 메모리 액세스가 완료되었음을 보장
        //         (2) Store Memory Barrier : 모든 메모리 쓰기가 완료되었음을 보장
        //         (3) Load Memory Barrier : 모든 메모리 읽기가 완료되었음을 보장
       

        // private static readonly object lockObj = new();

        static void Thread1()
        {
            //lock (lockObj)
            {
                y = 1;      // y 갱신
                Thread.MemoryBarrier();     // 코드 재배치 방지
                r1 = x;     // r1에 x값 저장
            }
        }

        static void Thread2()
        {
            //lock (lockObj)
            {
                x = 1;      // x 갱신
                Thread.MemoryBarrier();     // 코드 재배치 방지
                r2 = y;     // r2에 y값 저장
            }
        }

        static void Main()
        {
            int count = 0;
            while (true)
            {
                count++;
                x = y = r1 = r2 = 0;

                Task t1 = new Task(Thread1);
                Task t2 = new Task(Thread2);
                t1.Start();
                t2.Start();

                Task.WaitAll(t1, t2);
                if (r1 == 0 && r2 == 0)
                    break;
            }
            Console.WriteLine($"count = {count}번");
        }
    } */

    /*  
    internal class Program
    {
        private int answer = default;
        private bool complete = false;

        private void A()
        {
            answer = 123;
            Thread.MemoryBarrier();     // Barrier 1
            complete = true;
            Thread.MemoryBarrier();     // Barrier 2
        }   

        private void B()
        {
            Thread.MemoryBarrier();     // Barrier 3
            if (complete)
            {
                Thread.MemoryBarrier();     // Barrier 4
                Console.WriteLine(answer);
            }
        }

        static void Main()
        {

        }
    } */
    
    /*  lock 키워드와 Interlocked 클래스
    internal class Program
    {
        //  lock : 동기화를 위한 키워드
        //      1.  lock을 사용하면 특정 코드 블록에 대한 접근을 한 번에 하나의 쓰레드만 허용하며, 동시 접근으로 인한 데이터 일관성 문제를 해결할 수 있음.
        //      2.  lock을 사용하면 코드 블록을 잠그기 때문에 성능이 저하될 수 있고, 데드락이 발생할 수 있음. 또한, 다른 쓰레드가 대기할 수 있음.
        //  Interlocked : 원자성을 보장하는 메서드
        //      1.  Interlocked.Increment(ref number) : number를 1 증가시킴
        //      2.  Interlocked.Decrement(ref number) : number를 1 감소시킴
        //      3.  Interlocked.Add(ref number, 5) : number에 5를 더함
        //      4.  Interlocked.Exchange(ref number, 5) : number를 5로 설정
        //      5.  Interlocked.CompareExchange(ref number, 5, 0) : number가 0이면 5로 설정하고, 아니면 number를 반환
        //      6.  Interlocked.MemoryBarrier() : 메모리 액세스의 재배치를 방지하는 메서드

        static readonly object lockObj = new();
        static int number = 0;
        static long start = DateTime.Now.Ticks;
        static long end1;
        static long end2;
        static long end3;

        static void Thread1()
        {
            lock (lockObj)
            {
                for (int i = 0; i < 100000; i++)
                {
                    number += 1;
                }
                end1 = DateTime.Now.Ticks;
                Console.WriteLine("Thread1 : " + (end1 - start) + "ns");
            }

            // for (int i = 0; i < 100000; i++)
            // {
            //     Interlocked.Increment(ref number);
            //     Interlocked.Add(ref number, 1);
            // }
        }

        static void Thread2()
        {
            lock (lockObj)
            {
                for (int i = 0; i < 100000; i++)
                {
                    number -= 1;
                }
                end2 = DateTime.Now.Ticks;
                Console.WriteLine("Thread2 : " + (end2 - start) + "ns");
            }

            // for (int i = 0; i < 100000; i++)
            // {
            //     Interlocked.Decrement(ref number);
            //     Interlocked.Add(ref number, -1);
            // }
        }

        static void Main()
        {
            Task t1 = new(Thread1);
            Task t2 = new(Thread2);
            t1.Start();
            t2.Start();
            Task.WaitAll(t1, t2);
            Console.WriteLine(number);
            end3 = DateTime.Now.Ticks;
            Console.WriteLine("Main : " + (end3 - start) + "ns");
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