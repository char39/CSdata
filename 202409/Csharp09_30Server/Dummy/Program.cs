using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Dummy
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("\nHello, Dummy Client!\n");

            string host = Dns.GetHostName();
            IPHostEntry ipHost = Dns.GetHostEntry(host);
            IPAddress ipAddress = ipHost.AddressList[0];
            IPEndPoint endPoint = new(ipAddress, 5959);

            while (true)
            {
                Socket listenSocket = new(endPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    listenSocket.Connect(endPoint);
                    Console.WriteLine($"Connected to {listenSocket.RemoteEndPoint}");

                    byte[] sendBuffer = Encoding.UTF8.GetBytes("Hello World!");
                    int sendBytes = listenSocket.Send(sendBuffer);

                    byte[] recvBuffer = new byte[1024];
                    int recvBytes = listenSocket.Receive(recvBuffer);
                    string recvData = Encoding.UTF8.GetString(recvBuffer, 0, recvBytes);
                    Console.WriteLine($"[From Server] {recvData}");
                    listenSocket.Shutdown(SocketShutdown.Both);
                    listenSocket.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                Thread.Sleep(100);
            }
        }
    }
}
