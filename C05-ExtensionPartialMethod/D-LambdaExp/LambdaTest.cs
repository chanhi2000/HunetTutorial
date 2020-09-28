using System;

namespace D_LambdaExp
{
    class LambdaTest
    {
        static void Main(string[] args)
        {
            Action action = () => System.Console.WriteLine("Hello, World!");
            action();
        }
    }
}
