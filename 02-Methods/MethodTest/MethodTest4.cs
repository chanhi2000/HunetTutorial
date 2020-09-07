using System;

namespace MethodTest
{
    public class MethodTest4
    {
        public static void foo(ref int i)
        {
            Console.WriteLine(i);
            i = 100;
            Console.WriteLine(i);
        }

        public static void Main() 
        {
            int n=3;
            foo(ref n);
            Console.WriteLine("n="+n);
        }
    }
}