using System;
using System.Threading;

namespace C_ThreadInterrupt
{
    public class ThreadStop
    {
        public static void Prn()
        {
            for (int i=0; i<5; i++)
            {
                Console.WriteLine("Prn: {0}", i);
                Thread.Sleep(0);
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Main Start");
            Thread t = new Thread(new ThreadStart(ThreadStop.Prn));
            t.Start();
            Thread t1 = new Thread(new ThreadStart(ThreadStop.Prn));
            t1.Start();
            Console.WriteLine("조인메소드를 호출합니다. Prn이 끝날때까지 기다립니다.");
            t.Join();
            Console.WriteLine("조인이 끝나고 메인실행합니다.");
            Console.ReadLine();
            
        }
    }
}
