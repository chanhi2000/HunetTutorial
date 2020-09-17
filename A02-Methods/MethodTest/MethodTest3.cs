using System;

namespace MethodTest
{
    public class MethodTest3
    {
        public static void Prn(int a)
        {
            Console.WriteLine("a="+a);
        }
        public static void Prn(int a, int b)
        {
            Console.WriteLine("a="+a+" b="+b);
        }

        public static void Prn(float f, float d)
        {
            Console.WriteLine("f="+f+" d="+d);
        }

        public static void Main()
        {
            Prn(10);
            Prn(10, 20);
            Prn(45.3f, 67.5f);
        }
    }
}