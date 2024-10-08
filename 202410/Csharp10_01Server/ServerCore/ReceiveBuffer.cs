#pragma warning disable IDE0044

namespace ServerCore
{
    public class ReceiveBuffer
    {
        private ArraySegment<byte> _buffer;
        private int _readPos;
        private int _writePos;
        public ReceiveBuffer(int bufferSize)
        {
            _buffer = new ArraySegment<byte>(new byte[bufferSize], 0, bufferSize);
        }

        public int DataSize
        {
            get { return _writePos - _readPos; }
        }

        public int FreeSize
        {
            get { return _buffer.Count - _writePos; }
        }

        public ArraySegment<byte> ReadSegment
        {
            get
            {
                if (_buffer.Array != null)
                    return new ArraySegment<byte>(_buffer.Array, _readPos, DataSize);
                else
                    return ArraySegment<byte>.Empty;
            }
        }

        public ArraySegment<byte> WriteSegment
        {
            get 
            {
                if (_buffer.Array != null)
                    return new ArraySegment<byte>(_buffer.Array, _writePos, FreeSize);
                else
                    return ArraySegment<byte>.Empty;
            }
        }

        public void Clean()
        {
            int dataSize = DataSize;

            if (dataSize == 0)
            {
                _readPos = 0;
                _writePos = 0;
            }
            else
            {
                if (_buffer.Array != null)
                    Array.Copy(_buffer.Array, _buffer.Offset + _readPos, _buffer.Array, _buffer.Offset, dataSize);
                _readPos = 0;
                _writePos = dataSize;
            }
        }

        public bool OnRead(int numOfBytes)
        {
            if (numOfBytes > DataSize)
                return false;

            _readPos += numOfBytes;
            return true;
        }

        public bool OnWrite(int numOfBytes)
        {
            if (numOfBytes > FreeSize)
                return false;

            _writePos += numOfBytes;
            return true;
        }
    }
}