using System;

namespace D_Abstract
{
    abstract class AbsTest1
    {
        abstract public void kkk();
    }

    class MyClass : AbsTest1
    {
        public override void kkk()
        {
            Console.WriteLine("MyClass KKK");
        }
    }

    class MyClass02: AbsTest1
    {
        public override void kkk()
        {
            Console.WriteLine("Myclass02 KKK");
        }
    }

    public class MTest
    {
        public static void Main()
        {
            AbsTest1[] sm = new AbsTest1[2];
            sm[0] = new MyClass();
            sm[1] = new MyClass02();

            sm[0].kkk();
            sm[1].kkk();
        }
    }

}