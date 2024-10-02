using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ServerCore
{
    public class Listener
    {
        private Socket listenSocket;
        private Func<Session> SessionFactory;
        private SocketAsyncEventArgs recvArgs = new();

        public void Initialize(IPEndPoint endPoint, Func<Session> SessionFactory)
        {
            listenSocket = new(endPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            this.SessionFactory += SessionFactory;

            listenSocket.Bind(endPoint);
            listenSocket.Listen(10);

            recvArgs.Completed += new EventHandler<SocketAsyncEventArgs>(OnAcceptCompleted);
            RegisterAccept(recvArgs);
        }

        private void RegisterAccept(SocketAsyncEventArgs args)
        {
            args.AcceptSocket = null;

            bool pending = listenSocket.AcceptAsync(args);      // 보류 중인가
            if (!pending)
                OnAcceptCompleted(null, args);
        }

        private void OnAcceptCompleted(object sender, SocketAsyncEventArgs args)
        {
            if (args.SocketError == SocketError.Success)
            {
                Session session = SessionFactory.Invoke();
                session.Start(args.AcceptSocket);
                session.OnConnected(args.AcceptSocket.RemoteEndPoint);
                // OnAcceptHandler.Invoke(args.AcceptSocket);
            }
            else
                Console.WriteLine(args.SocketError.ToString());

            RegisterAccept(args);
        }
    }
}