using System;

namespace A_ExtensionMethod
{
    using Test;
    class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
            int res = i.getValue();
            Console.WriteLine(res);
        }
    }
}

namespace Test
{
    public static class IntExtension
    {
        public static int getValue(this int a)
        {
            return a * 100;
        }
    }
}
