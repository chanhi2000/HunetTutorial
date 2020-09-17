using System;

namespace MethodTest
{
    class MethodTest1
    {
        public static void Main(string[] args)
        {
            Prn();  // Test Method
            int a = getA();     // 100
            Console.WriteLine(a);
            double d = getD();
            Console.WriteLine(d);
        }

        public static void Prn()
        {
            Console.WriteLine("Test Method");
        }

        public static int getA()
        {
            return 100;
        }

        public static double getD()
        {
            return 92.7;
            Console.WriteLine("0000000000");
        }
    }
}
