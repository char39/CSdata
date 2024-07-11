using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Csharp07_11NETCORE
{
    interface ILogger                   // 인터페이스. 선언만 가능. 함수 구현 불가능
    {
        void WriteLog(string message);
    }
    class ConsoleLogger : ILogger       // 인터페이스를 상속받는 클래스
    {
        public void WriteLog(string message)    // 인터페이스에 있는 함수를 구현
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()}, {message}");
        }
    }
    class FileLogger : ILogger          // 인터페이스를 상속받는 클래스
    {
        private StreamWriter writer;    // StreamWriter : 파일에 쓰기 위한 클래스
        public FileLogger(string path)  // 생성자
        {
            this.writer = File.CreateText(path);    // 파일 생성
            this.writer.AutoFlush = true;           // 버퍼가 가득 차지 않아도 자동으로 내용을 출력
        }
        public void WriteLog(string message)    // 인터페이스에 있는 함수를 구현
        {
            writer.WriteLine("{0} {1}", DateTime.Now.ToShortTimeString(), message);  // 파일에 쓰기
        }
    }
    class ClimateMonitor                // ClimateMonitor 클래스
    {
        private ILogger logger;                 // 인터페이스를 멤버로 가짐
        public ClimateMonitor(ILogger logger)   // 생성자
        {
            this.logger = logger;           // 인터페이스를 매개변수로 받아 멤버로 저장
        }
        public void start()                 // 함수
        {
            while (true)
            {
                Console.Write("온도를 입력해주세요.: ");
                string temperature = Console.ReadLine();
                if (temperature == "")
                    break;
                logger.WriteLog("현재 온도 : " + temperature);   // 인터페이스의 함수를 호출
            }
        }
    }
    internal class MainApp
    {
        static void Main()
        {
            ClimateMonitor monitor = new ClimateMonitor(new FileLogger("MyLog.log"));   // ClimateMonitor 객체 생성
            monitor.start();
        }
    }
}
