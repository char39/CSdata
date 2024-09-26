using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Dummy
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("\nDummy\n");
            string host = Dns.GetHostName();                    // 호스트 이름.                     현재 컴퓨터의 이름
            IPHostEntry iPHost = Dns.GetHostEntry(host);        // 호스트 이름에 대한 IP 주소 정보.     호스트 이름에 대한 IP 주소 목록을 반환
            IPAddress iPAddress = iPHost.AddressList[0];        // IP 주소.                       IP 주소 목록 중 첫 번째 주소
            IPEndPoint iPEndPoint = new(iPAddress, 5959);       // IP 주소와 포트 번호.              IP 주소와 포트 번호를 지정하여 IPEndPoint 클래스의 새 인스턴스를 초기화

            Socket socket = new(iPEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);         // 소켓 생성

            try
            {
                socket.Connect(iPEndPoint);                                                                 // 서버에 연결
                Console.WriteLine($"Connected to {socket.RemoteEndPoint}");

                // 서버에 데이터 전송. 송신
                byte[] sendBuffer = Encoding.UTF8.GetBytes("Hello World!");
                int sendBytes = socket.Send(sendBuffer);

                // 서버로부터 데이터 수신. 수신
                byte[] recvBuffer = new byte[1024];
                int recvBytes = socket.Receive(recvBuffer);
                string recvData = Encoding.UTF8.GetString(recvBuffer, 0, recvBytes);
                Console.WriteLine($"[From Server] {recvData}");
                socket.Shutdown(SocketShutdown.Both);               // 소켓의 보내기 및 받기 작업을 중단
                socket.Close();                                     // 소켓을 닫음
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}
