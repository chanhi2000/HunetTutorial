using System;

namespace A_WhatIsClass
{
    class Test
    {
        public int a { get; set; }
        public void setA(int a)
        {
            this.a = a;
        }
        public int getA()
        {
            return this.a;
        }

        public static void Main()
        {
            Test t1 = new Test();
            t1.setA(100);
            Console.WriteLine(t1.getA());
        }
    }
}
