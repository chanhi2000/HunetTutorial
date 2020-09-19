using System;
using System.Threading;
using System.Threading.Tasks;

namespace C_ThreadInterrupt
{
    public class ParallelTest
    {
        public static void Main(string[] args)
        {
            Parallel.For(0,3, Prn);
            // 병행하여 운영하고 있는 처리가 모두 끝날 때까지 자동으로 기다린다.
        }

        public static void Prn(int obj)
        {
            Random rnd = new Random();
            for (int i=0; i < 4; i++)
            {
                Thread.Sleep(rnd.Next(50, 100)); // 임의의 간격으로 처리를 일시 중단.
                Console.Write("{0,4},: {1} \n", i, obj);
            }
        }
    }   
}