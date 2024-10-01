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
                byte[] recvBuff = new byte[1024];
                int recvBytes = clientSocket.Receive(recvBuff);
                string recvData = Encoding.UTF8.GetString(recvBuff, 0, recvBytes);
                Console.WriteLine($"[From Client] {recvData}");

                byte[] sendBuff = Encoding.UTF8.GetBytes("Welcome to ServerCore\n");
                clientSocket.Send(sendBuff);
                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
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
