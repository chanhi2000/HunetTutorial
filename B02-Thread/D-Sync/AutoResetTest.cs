using System;
using System.Threading;

namespace D_Sync
{
    public class AutoResetTest 
    {
        public ReaderWriterLock rwl = new ReaderWriterLock();

        public void Read(Int32 threadNum)
        {
            rwl.AcquireReaderLock(Timeout.Infinite);
            try 
            {
                Console.WriteLine("Start Resource Reading (thread={0})", threadNum);
                Thread.Sleep(250);
                Console.WriteLine("End Resource Reading (thread={0})", threadNum);
            }
            finally
            {
                rwl.ReleaseReaderLock();
            }
        }

        public void Write(Int32 threadNum)
        {
            rwl.AcquireWriterLock(Timeout.Infinite);
            try
            {
                Console.WriteLine("Start Resource Writing (thread={0})", threadNum);
                Thread.Sleep(750);
                Console.WriteLine("End Resource Writing (thread={0})", threadNum);
            }
            finally
            {
                rwl.ReleaseWriterLock();
            }
        }
    }
    public class Test
    {
        public static Int32 numAsyncOps = 30;
        public static AutoResetEvent autoEvent = new AutoResetEvent(false);
        public static AutoResetTest res = new AutoResetTest();
        public static void Main(string[] args)
        {
            for (Int32 threadNum=0; threadNum < 20; threadNum++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(UpdateResource), threadNum);
            }
            autoEvent.WaitOne(); // 신호를 받을 때 까지 현재 스레드 차단
            Console.WriteLine("모두 끝 ^.^");
        }
        public static void UpdateResource(Object state)
        {
            Int32 threadNum = (Int32) state;
            if ((threadNum % 2) != 0) 
                res.Read(threadNum);
            else 
                res.Write(threadNum);

            if (Interlocked.Decrement(ref numAsyncOps) == 0)
                autoEvent.Set(); // 대기상태에서 실행
        }
    }
}
