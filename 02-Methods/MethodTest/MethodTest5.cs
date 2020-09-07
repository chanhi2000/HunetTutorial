using System;

namespace MethodTest
{    public class MethodTest5
    {
        public static int TestOut(out char c)
        {
            c='b';
            return -1;
        }

        public static void TestOut02(out char a, out int k)
        {
            a='d';
            k = 100;
        }
        public static void Main()
        {
            char c; int y;
            Console.WriteLine(TestOut(out c));
            Console.WriteLine(c);
            TestOut02(out c, out y);
            Console.WriteLine(c);
            Console.WriteLine(y);
        }
    }
}