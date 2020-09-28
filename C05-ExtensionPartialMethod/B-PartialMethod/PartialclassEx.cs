using System;

namespace B_PartialMethod
{
    interface U_CLass
    {
        int X { get; }
        int Y { get; }
    }

    public partial class MyTest: U_CLass
    {
        public int X {get; set;} = 100;
        public int Y {get; set;} = 200;
    }

    public partial class MyTest
    {
        public int Norm() { return X * X + Y * Y;}
    }

    public class PartialclassEx
    {
        public static void Main(string[] args)
        {
            MyTest m = new MyTest();
            Console.WriteLine(m.Norm());
        }
    }
}
