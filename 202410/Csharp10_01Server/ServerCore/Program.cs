using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ServerCore
{
    public class Program
    {
        static Listener _listener = new();

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

                Session session = new();
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

            _listener.Initialize(endPoint, OnAcceptHandler);

            Console.WriteLine("Listening...");

            while (true)
            {

            }
        }
    }
}
