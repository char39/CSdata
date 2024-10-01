using System.Net.Sockets;
using System.Text;

namespace ServerCore
{
    public class Session
    {
        Socket socket;
        public void Initialize(Socket socket)
        {
            this.socket = socket;
            SocketAsyncEventArgs recvArgs = new();
            recvArgs.Completed += new EventHandler<SocketAsyncEventArgs>(OnReceiveCompleted);
            recvArgs.SetBuffer(new byte[1024], 0, 1024);
            RegisterReceive(recvArgs);
        }

        public void Send(byte[] sendBuff)
        {
            socket.Send(sendBuff);
        }

        public void Disconnect()
        {
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }


        /// <summary> 네트워크 통신 메서드 </summary>
        private void RegisterReceive(SocketAsyncEventArgs args)
        {
            bool pending = socket.ReceiveAsync(args);
            if (!pending)
                OnReceiveCompleted(null, args);

        }
        /// <summary> 네트워크 통신 메서드 </summary>
        private void OnReceiveCompleted(object sender, SocketAsyncEventArgs args)
        {
            if (args.BytesTransferred > 0 && args.SocketError == SocketError.Success)
            {
                try
                {
                    string recvData = Encoding.UTF8.GetString(args.Buffer, args.Offset, args.BytesTransferred);
                    Console.WriteLine($"From[Client] : {recvData}");
                    RegisterReceive(args);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("OnReceievCompleted Failed : " + ex.ToString());
                }
            }
            else
            {

            }
        }




    }
}
