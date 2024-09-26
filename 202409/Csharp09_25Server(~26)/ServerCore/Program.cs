using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ServerCore
{
    //  0925
    /*  ReadLock, WriteLock 구현
        internal class Program
        {
            // 1. 근성(SpinLock)   2. 양보(Thread.Yield())   3. 갑질(Thread.Sleep(0) ~ Thread.Sleep(1))

            private static object _lock = new();
            private static SpinLock _spinLock = new();
            private static Mutex _mutexLock = new();
            private static ReaderWriterLockSlim _Lock4 = new();

            public class Reward
            {

            }

            private static Reward GetRewardByID(int id)
            {
                _Lock4.EnterReadLock();
                _Lock4.ExitReadLock();
                lock (_lock)
                {

                }
                return null;
            }

            private static void AddReward(Reward reward)
            {
                _Lock4.EnterReadLock();
                _Lock4.ExitReadLock();
            }

            static void Main()
            {
                lock (_lock)
                {

                }

                bool lockTaken = false;

                try
                {
                    _spinLock.Enter(ref lockTaken);
                }
                finally
                {
                    if (lockTaken)
                        _spinLock.Exit(lockTaken);
                }
            }
        } */

    //  0926

    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("\nServerCore\n");

            string host = Dns.GetHostName();                    // 호스트 이름.                     현재 컴퓨터의 이름
            IPHostEntry iPHost = Dns.GetHostEntry(host);        // 호스트 이름에 대한 IP 주소 정보.     호스트 이름에 대한 IP 주소 목록을 반환
            IPAddress iPAddress = iPHost.AddressList[0];        // IP 주소.                       IP 주소 목록 중 첫 번째 주소
            IPEndPoint iPEndPoint = new(iPAddress, 5959);       // IP 주소와 포트 번호.              IP 주소와 포트 번호를 지정하여 IPEndPoint 클래스의 새 인스턴스를 초기화

            Socket listenSocket = new(iPEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);       // 소켓 생성

            try
            {
                listenSocket.Bind(iPEndPoint);                      // 소켓을 특정 IP 주소와 포트 번호에 연결
                listenSocket.Listen(10);                            // 소켓을 수신 대기 상태로 전환. 최대 대기 수 10
                while (true)
                {
                    Console.WriteLine("Listening...");
                    Socket clientSocket = listenSocket.Accept();                // 클라이언트의 연결 요청을 수락하고 새 소켓을 반환

                    // 데이터 받기. 수신
                    byte[] recvBuff = new byte[1024];                           // 수신 버퍼. 1 KB
                    int recvBytes = clientSocket.Receive(recvBuff);             // 클라이언트로부터 데이터를 받아서 수신 버퍼에 저장
                    string recvData = Encoding.UTF8.GetString(recvBuff, 0, recvBytes);      // 수신 버퍼의 데이터를 문자열로 변환
                    Console.WriteLine($"[From Client] {recvData}");

                    // 데이터 보내기. 송신
                    byte[] sendBuff = Encoding.UTF8.GetBytes($"Welcome to ServerCore");       // 송신할 데이터를 바이트 배열로 변환
                    clientSocket.Send(sendBuff);                                // 송신할 데이터를 클라이언트에게 보냄
                    clientSocket.Shutdown(SocketShutdown.Both);                 // 소켓의 보내기 및 받기 작업을 중단
                    clientSocket.Close();                                       // 소켓을 닫음
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
