using System;
using System.Threading.Tasks;

namespace ServerBasic
{
    internal class Program
    {
        static void MainThread(object state)
        {
            for (int i = 0; i < 10; i++)
            {
                // Visual Studio에서 디버깅할 때 출력되는 정보로 프로세스, 스레드, 스택 프레임을 알 수 있음. 스레드를 선택하여 디버깅할 수 있음.
                // 프로세스 : ServerBasic.exe
                // 스레드 : <이름 없음>
                // 스택 프레임 : ServerBasic.Program.MainThread
                Console.WriteLine("MainThread()" + i);
                Thread.Sleep(100);
            }
        }

        static void Main(string[] args)
        {
            ThreadPool.SetMinThreads(1, 1);
            ThreadPool.SetMaxThreads(5, 5);

            for (int i = 0; i < 5; i++)
            {
                Task task = new(() => { while (true) { } }, TaskCreationOptions.LongRunning);   // LongRunning : 새로운 스레드를 만들어서 실행
                task.Start();
            }

            // for (int i = 0; i < 5; i++)
            //     ThreadPool.QueueUserWorkItem((obj) => { while (true) { } });  // 무한 루프

            ThreadPool.QueueUserWorkItem(MainThread);

            #region ThreadPool을 쓰지 않고 직접 생성한 경우.
            // Thread thread = new(MainThread);
            // thread.IsBackground = true;
            // thread.Start();     // Start는 새로운 스레드를 만들어서 MainThread()를 실행
            // Console.WriteLine("Waiting for MainThread to finish");
            // thread.Join();      // Join은 MainThread()가 끝날 때까지 기다림
            // Console.WriteLine("Hello, Server Basic!");
            #endregion
            #region ThreadPool을 쓰지 않고 1000개의 스레드를 생성한 경우.
            // for (int i = 0; i < 10; i++)
            // {
            //     Thread thread = new Thread(MainThread);
            //     thread.IsBackground = true;
            //     thread.Start();
            // }
            #endregion





            while (true)
            {

            }
        }
    }
}
