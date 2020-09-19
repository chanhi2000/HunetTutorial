using System;
using System.Threading;

namespace A_Thread
{
    public class ThreadTest
    {
        public static void PrnName(string name)
        {
            for (int i = 1; i<=5 ; i++)
            {
                Console.WriteLine("그대의 이름은 : {0} ", name);
            }
        }
    }

    public class Program
    {
        public static void Thread1()
        {
            ThreadTest.PrnName("홍길동입니다.");
        }

        public static void Thread2()
        {
            ThreadTest.PrnName("청길동입니다.");
        }

        public static void Main(string[] args)
        {
            Thread T1 = new Thread(new ThreadStart(Thread1));
            Thread T2 = new Thread(new ThreadStart(Thread2));
            T1.Start();
            T2.Start();
        }
    }
}
