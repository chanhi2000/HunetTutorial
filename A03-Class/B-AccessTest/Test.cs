using System;

namespace B_AccessTest
{
    class AccessTest
    {
        private int a;  // AccessTest 내의 멤버변수
        public int getA()
        {
            return a;
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            AccessTest a1 = new AccessTest();
            Console.WriteLine(a1.getA());
        }
    }
}
