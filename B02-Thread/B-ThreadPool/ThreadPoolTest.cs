using System;
using System.Threading;

namespace B_ThreadPool
{
    class ThreadPoolTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("두개의 Thread를 프로세스별로 일정량을 수용할 수 있는 풀을 만들고 스레드 풀 내에서 스래드를 이용함으로서 적절한 스레드 유지를 한답니다.");
            ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadPoolTest.Prn));
            ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadPoolTest.Disp));

            Console.WriteLine("Main에서 스레드를 생성하고 잠시 쉽니다.");
            Thread.Sleep(2000);
            Console.WriteLine("Main 업무수행 끝");
        }

        public static void Prn(Object  a)
        {
            for (int i=0; i<10; i++)
            {
                Console.WriteLine("ThreadPoolTest의 prn 입니다.");
            }
        }

        public static void Disp(Object a)
        {
            for (int i=0; i< 10; i++)
            {
                Console.WriteLine("=================================== ThreadPoolTest 의 disp 입니다.");       
            }
        }
    }
}
