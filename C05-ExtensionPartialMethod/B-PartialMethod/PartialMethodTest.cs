using System;

namespace B_PartialMethod
{
    public partial class PartialMethodTest
    {
        partial void Prn();
    }

    public partial class PartialMethodTest
    {
        partial void Prn()
        {
            Console.WriteLine(" Prn 입니다.");
        }
    }

    public partial class PartialMethodTest
    {
        public static void Main(string[] args)
        {
            PartialMethodTest t1 = new PartialMethodTest();
            t1.Prn();
        }
    }
}