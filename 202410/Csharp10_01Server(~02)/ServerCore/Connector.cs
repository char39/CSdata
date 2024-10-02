using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ServerCore
{
    public class Connector
    {
        private Func<Session>? SessionFactory;

        public void Connect(IPEndPoint endPoint, Func<Session> SessionFactory)
        {
            this.SessionFactory = SessionFactory;

            Socket socket = new(endPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            SocketAsyncEventArgs args = new();
            args.Completed += OnConnectCompleted;
            args.RemoteEndPoint = endPoint;
            args.UserToken = socket;
            RegisterConnect(args);
        }

        private void RegisterConnect(SocketAsyncEventArgs args)
        {
            if (args.UserToken is not Socket socket)
                return;

            bool pending = socket.ConnectAsync(args);
            if (!pending)
                OnConnectCompleted(null, args);
        }

        private void OnConnectCompleted(object? sender, SocketAsyncEventArgs args)
        {
            if (args.SocketError == SocketError.Success && SessionFactory != null && args.ConnectSocket != null)
            {
                Session session = SessionFactory.Invoke();
                session.Start(args.ConnectSocket);
                session.OnConnected(args.ConnectSocket.RemoteEndPoint ?? throw new InvalidOperationException("RemoteEndPoint is null."));
            }
            else
            {
                Console.WriteLine($"OnConnectCompleted failed : {args.SocketError}");
            }
        }
    }
}
