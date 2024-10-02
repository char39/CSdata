﻿using ServerCore;
using System;
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
                try
                {
                    Connector connect = new();
                    connect.Connect(endPoint, () => { return new GameSession(); });
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                Thread.Sleep(100);
            }
        }
    }
    
    public class GameSession : Session
    {
        public override void OnConnected(EndPoint endPoint)
        {
            Console.WriteLine($"Connected : {endPoint}");

            for (int i = 0; i < 5; i++)
            {
                byte[] sendBuffer = Encoding.UTF8.GetBytes("Sended" + i);
                Send(sendBuffer);
            }
        }
        public override void OnReceiev(ArraySegment<byte> buffer)
        {
            string recvData = buffer.Array != null ? Encoding.UTF8.GetString(buffer.Array, buffer.Offset, buffer.Count) : string.Empty;
            Console.WriteLine($"From[Server] : {recvData}");
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
