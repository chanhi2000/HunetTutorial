using System;

namespace C_MemMgmt
{
    class Construct_Test01
    {
        public Construct_Test01()
        {
            Console.WriteLine("기본생성자");
        }
    }
    class MTest
    {
        static void Main(string[] args)
        {
            new Construct_Test01();
            new Construct_Test01();
            new Construct_Test01();
            new Construct_Test01();
        }
    }
}
