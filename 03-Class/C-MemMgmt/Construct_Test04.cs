using System;
namespace C_MemMgmt
{
    public class Construct_Test04
    {
        int a;
        static int b;
        public Construct_Test04()
        {
            a=200;
            Console.WriteLine("기본생성자 " + a + " " + b++);
        }
        static Construct_Test04()
        {
            b=100;
            Console.WriteLine("스택택 정적 생성자 "+b);
        }

        class ConTest
        {
            public static void Main()
            {
                new Construct_Test04();
                new Construct_Test04(); 
            }
            
        }
    }
}