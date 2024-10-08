#pragma warning disable IDE0044

namespace ServerCore
{
    public class SendBufferHelper
    {
        public static ThreadLocal<SendBuffer> CurrentBuffer = new(() => new SendBuffer());
        public static int ChunkSize { get; set; } = 4096;
        public static ArraySegment<byte> Open(int reserveSize)
        {
            if (CurrentBuffer.Value == null || CurrentBuffer.Value.FreeSize < reserveSize)
                CurrentBuffer.Value = new SendBuffer(ChunkSize);
            return CurrentBuffer.Value.Open(reserveSize);
        }
        public static ArraySegment<byte> Close(int usedSize)
        {
            if (CurrentBuffer.Value == null)
                throw new NullReferenceException("CurrentBuffer is null.");
            return CurrentBuffer.Value.Close(usedSize);
        }
    }

    public class SendBuffer
    {
        public SendBuffer(int chunkSize = 4096)
        {
            _buffer = new byte[chunkSize];
        }

        private byte[]? _buffer;
        private int _usedSize = 0;

        public int FreeSize
        {
            get
            {
                if (_buffer == null)
                    return 0;
                return _buffer.Length - _usedSize;
            }
        }

        public ArraySegment<byte> Open(int reserveSize)
        {
            if (_buffer != null)
                return new ArraySegment<byte>(_buffer, _usedSize, reserveSize);
            else
                return new ArraySegment<byte>(new byte[1024], 0, reserveSize);
        }

        public ArraySegment<byte> Close(int usedSize)
        {
            if (_buffer == null)
                throw new NullReferenceException("SendBuffer is null.");

            ArraySegment<byte> segment = new(_buffer, _usedSize, usedSize);
            _usedSize += usedSize;
            return segment;
        }
    }
}