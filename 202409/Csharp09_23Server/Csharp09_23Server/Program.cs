namespace ServerBase
{
    internal class Program
    {
        // static으로 선언된 변수들은 멀티쓰레드 환경에서 접근이 가능.
        // 일반적으로 각 쓰레드는 자신만의 stack메모리를 가지고 있지만, heap메모리는 모든 쓰레드가 공유함. (stack메모리는 보통 구조체, heap메모리는 클래스)
        // 여러 쓰레드가 동시에 static 변수에 접근하면 데이터 일관성이 깨질수 있음.
        // 이를 방지하기 위해서 lock을 사용하여 동기화를 시켜주는 작업이 필요함.
        // lock을 사용하면 특정 코드 블록에 대한 접근을 한 번에 하나의 쓰레드만 허용하며, 동시 접근으로 인한 데이터 일관성 문제를 해결할 수 있다.
        
        volatile static bool _Stop = false; // volatile은 휘발성이라는 의미로, 컴파일러가 최적화를 하지 않도록 하는 키워드.

        static void ThreadMain()
        {
            Console.WriteLine("쓰레드 시작");
            while (!_Stop)
            {
                Console.WriteLine("쓰레드 동작중");
                Thread.Sleep(200);
            }

            // Release 모드로 빌드하면 위의 코드가 아래 코드로 변경될 수 있음.
            if (!_Stop)
            {
                while (true)
                {
                    Console.WriteLine("쓰레드 동작중");
                    Thread.Sleep(200);
                }
            }


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
    }
}
