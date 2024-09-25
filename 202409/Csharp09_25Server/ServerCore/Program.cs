namespace ServerCore
{
/*  ReadLock, WriteLock 구현
    internal class Program
    {
        // 1. 근성(SpinLock)   2. 양보(Thread.Yield())   3. 갑질(Thread.Sleep(0) ~ Thread.Sleep(1))

        private static object _lock = new();
        private static SpinLock _spinLock = new();
        private static Mutex _mutexLock = new();
        private static ReaderWriterLockSlim _Lock4 = new();

        public class Reward
        {

        }

        private static Reward GetRewardByID(int id)
        {
            _Lock4.EnterReadLock();
            _Lock4.ExitReadLock();
            lock (_lock)
            {

            }
            return null;
        }

        private static void AddReward(Reward reward)
        {
            _Lock4.EnterReadLock();
            _Lock4.ExitReadLock();
        }

        static void Main()
        {
            lock (_lock)
            {
                
            }

            bool lockTaken = false;

            try
            {
                _spinLock.Enter(ref lockTaken);
            }
            finally
            {
                if (lockTaken)
                    _spinLock.Exit(lockTaken);
            }
        }
    } */

    internal class Program
    {
        static void Main()
        {
            
        }
    }





}
