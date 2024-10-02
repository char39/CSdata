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
                Socket socket = new(endPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    socket.Connect(endPoint);
                    Console.WriteLine($"Connected to {socket.RemoteEndPoint}");

                    for (int i = 0; i < 5; i++)
                    {
                        byte[] sendBuffer = Encoding.UTF8.GetBytes("Sended" + i);
                        int sendBytes = socket.Send(sendBuffer);
                    }

                    byte[] recvBuffer = new byte[1024];
                    int recvBytes = socket.Receive(recvBuffer);
                    string recvData = Encoding.UTF8.GetString(recvBuffer, 0, recvBytes);
                    Console.WriteLine($"[From Server] {recvData}");
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
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
