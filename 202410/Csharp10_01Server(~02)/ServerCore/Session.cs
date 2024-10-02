using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ServerCore
{
    public abstract class Session
    {
        protected Socket socket;
        protected SocketAsyncEventArgs recvArgs = new();
        protected SocketAsyncEventArgs sendArgs = new();
        protected int disconnected = 0;
        protected Queue<byte[]> sendQueue = new();
        protected List<ArraySegment<byte>> pendingList = new();
        protected readonly object lockObj = new();

        public abstract void OnConnected(EndPoint endPoint);
        public abstract void OnReceiev(ArraySegment<byte> buffer);
        public abstract void OnSend(int numBytes);
        public abstract void OnDisconnected(EndPoint endpoint);

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
            OnDisconnected(socket.RemoteEndPoint);
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }



        /// <summary> 네트워크 통신 메서드 </summary>
        protected void RegisterSend()
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
        protected void OnSendCompleted(object sender, SocketAsyncEventArgs args)
        {
            if (args.BytesTransferred > 0 && args.SocketError == SocketError.Success)
            {
                try
                {
                    sendArgs.BufferList = null;
                    pendingList.Clear();
                    OnSend(sendArgs.BytesTransferred);
                    
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
        protected void RegisterReceive(SocketAsyncEventArgs args)
        {
            bool pending = socket.ReceiveAsync(args);
            if (!pending)
                OnReceiveCompleted(null, args);

        }
        /// <summary> 네트워크 통신 메서드 </summary>
        protected void OnReceiveCompleted(object sender, SocketAsyncEventArgs args)
        {
            if (args.BytesTransferred > 0 && args.SocketError == SocketError.Success)
            {
                try
                {
                    OnReceiev(new ArraySegment<byte>(args.Buffer, args.Offset, args.BytesTransferred));
                    // // 추상클래스 사용 이전 방법
                    // string recvData = Encoding.UTF8.GetString(args.Buffer, args.Offset, args.BytesTransferred);
                    // Console.WriteLine($"From[Client] : {recvData}");
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
