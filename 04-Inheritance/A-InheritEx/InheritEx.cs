using System;

namespace A_InheritEx
{
    public class Test
    {
        private int a;
        public Test() 
        {
            Console.WriteLine("Test");
        }
        public Test(int a)
        {
            this.a = a;
        }
        public void setA(int a)
        {
            this.a = a;
        }
        public int getA() 
        {
            return a;
        }
    }
    public class Test2 : Test
    {
        private int b;
        public Test2()
        {
            Console.WriteLine("Test2");
        }
        public Test2(int a, int b) : base(a)
        {
            this.b = b;
        }
        public void setB(int b)
        {
            this.b = b;
        }
        public int getB()
        {
            return b;
        }
        public int getHap()
        {
            return getA() + getB();
        }

    }
    class InheritEx1
    {
        public static void Main(string[] args)
        {
            Test2 t = new Test2();
            Test2 t1 = new Test2(100, 100);
            Console.WriteLine(t1.getA());
            Console.WriteLine(t1.getB());
            Console.WriteLine(t1.getHap());
        }
    }
}
