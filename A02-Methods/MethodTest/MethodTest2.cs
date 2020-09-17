using System;

namespace MethodTest
{
    class MethodTest2
    {
        public static void Test(int a, int b)
        {
            Console.WriteLine("{0,5}{1,5}", a, b);            
        }
        public static int Test2(int k)
        {
            return k*k;
        }
        public static int Test3(char k)
        {
            return k;
        }
    }

    class MTest
    {
        public static void Main() 
        {
            MethodTest2.Test(100,200);
            int a = MethodTest2.Test2(300);
            Console.WriteLine("a={0,6}", a);
            Console.WriteLine(MethodTest2.Test3('a'));
        }
    }
}
