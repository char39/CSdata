using System.Net.Sockets;
using System.Text;

namespace ServerCore
{
    public class Session
    {
        private Socket socket;
        private SocketAsyncEventArgs recvArgs = new();
        private SocketAsyncEventArgs sendArgs = new();
        private int disconnected = 0;
        private Queue<byte[]> sendQueue = new();
        private List<ArraySegment<byte>> pendingList = new();
        private readonly object lockObj = new();

        public void Start(Socket socket)
        {
            this.socket = socket;

            recvArgs.Completed += OnReceiveCompleted;
            recvArgs.SetBuffer(new byte[1024], 0, 1024);
            sendArgs.Completed += new EventHandler<SocketAsyncEventArgs>(OnSendCompleted);

            RegisterReceive(recvArgs);
        }

        public void Send(byte[] sendBuff)
        {
            lock (lockObj)
            {
                sendQueue.Enqueue(sendBuff);
                if (pendingList.Count == 0)
                    RegisterSend();
            }
        }

        public void Disconnect()
        {
            if (Interlocked.Exchange(ref disconnected, 1) == 1)     // 이미 연결이 끊겼다면 return
                return;
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }



        /// <summary> 네트워크 통신 메서드 </summary>
        private void RegisterSend()
        {
            pendingList.Clear();

            // // 조금씩 보내는 방법
            // byte[] buff = sendQueue.Dequeue();
            // sendArgs.SetBuffer(buff, 0, buff.Length);

            while (sendQueue.Count > 0)
            {
                byte[] buff = sendQueue.Dequeue();
                pendingList.Add(new ArraySegment<byte>(buff, 0, buff.Length));
            }
            sendArgs.BufferList = pendingList;

            bool _pending = socket.SendAsync(sendArgs);
            if (!_pending)
            {
                OnSendCompleted(null, sendArgs);
            }
        }
        /// <summary> 네트워크 통신 메서드 </summary>
        private void OnSendCompleted(object sender, SocketAsyncEventArgs args)
        {
            if (args.BytesTransferred > 0 && args.SocketError == SocketError.Success)
            {
                try
                {
                    sendArgs.BufferList = null;
                    pendingList.Clear();
                    Console.WriteLine("Transferred bytes : " + sendArgs.BytesTransferred);

                    if (sendQueue.Count > 0)
                        RegisterSend();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("OnSendCompleted Failed : " + ex.ToString());
                }
            }
            else
            {
                Disconnect();
            }
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
                Disconnect();
            }
        }
    }
}
