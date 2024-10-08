using ServerCore;
using System.Net;
using System.Net.Sockets;
using System.Text;

// ServerCore : 핵심 라이브러리만 존재
// Server : Accept Connect를 담당하는 Listener, Connector가 존재
namespace ServerBase
{
    public class Program
    {
        static Listener _listener = new();

        // Session을 추상클래스 추상메서드화 한 것을 상속되지 않았을 때
        static void OnAcceptHandler(Socket clientSocket)
        {
            try
            {
                #region 블로킹 방식의 Receive()와 Send()

                // byte[] recvBuff = new byte[1024];
                // int recvBytes = clientSocket.Receive(recvBuff);
                // string recvData = Encoding.UTF8.GetString(recvBuff, 0, recvBytes);
                // Console.WriteLine($"[From Client] {recvData}");

                // byte[] sendBuff = Encoding.UTF8.GetBytes("Welcome to ServerCore\n");
                // clientSocket.Send(sendBuff);
                // clientSocket.Shutdown(SocketShutdown.Both);
                // clientSocket.Close();

                #endregion//-----------------------------------------
                #region 논블로킹 비동기식 방식의 Receive() Send()

                GameSession session = new();
                session.Start(clientSocket);
                byte[] sendBuff = Encoding.UTF8.GetBytes("Welcome to ServerCore!\n");
                session.Send(sendBuff);
                Thread.Sleep(1000);
                session.Disconnect();

                #endregion//-----------------------------------------
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        static void Main()
        {
            Console.WriteLine("\nHello, ServerCore!\n");

            string host = Dns.GetHostName();
            IPHostEntry ipHost = Dns.GetHostEntry(host);
            IPAddress ipAddress = ipHost.AddressList[0];
            IPEndPoint endPoint = new(ipAddress, 5959);

            _listener.Initialize(endPoint, () => { return new GameSession(); });

            Console.WriteLine("Listening...");

            while (true)
            {

            }
        }
    }

    public class Knight
    {
        public int hp;
        public int attack;
        public List<int> skills = [];
    }

    public class GameSession : Session
    {
        public override void OnConnected(EndPoint endPoint)
        {
            Console.WriteLine($"Connected : {endPoint}");

            Knight knight = new() {hp = 100, attack = 10};

            // byte[] sendBuff = new byte[4096];   // 이전 코드 : Encoding.UTF8.GetBytes("Welcome to ServerCore!\n");
            ArraySegment<byte> openSegment = SendBufferHelper.Open(4096);

            byte[] buffer1 = BitConverter.GetBytes(knight.hp);
            byte[] buffer2 = BitConverter.GetBytes(knight.attack);
            Array.Copy(buffer1, 0, openSegment.ToArray(), openSegment.Offset, buffer1.Length);
            Array.Copy(buffer2, 0, openSegment.ToArray(), openSegment.Offset + buffer1.Length, buffer2.Length);

            ArraySegment<byte> sendBuff = SendBufferHelper.Close(buffer1.Length + buffer2.Length);

            Send(sendBuff.ToArray());
            Thread.Sleep(1000);
            Disconnect();
        }
        public override int OnReceiev(ArraySegment<byte> buffer)
        {
            string recvData = buffer.Array != null ? Encoding.UTF8.GetString(buffer.Array, buffer.Offset, buffer.Count) : string.Empty;
            Console.WriteLine($"From[Client] : {recvData}");
            return buffer.Count;
        }
        public override void OnSend(int numBytes)
        {
            Console.WriteLine("Transferred bytes : " + numBytes);
        }
        public override void OnDisconnected(EndPoint endPoint)
        {
            Console.WriteLine($"Disconnected : {endPoint}");
        }
    }
}
