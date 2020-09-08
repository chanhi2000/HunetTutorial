namespace C_Sealed
{
    public class SealedTest2
    {
        class A
        {
            protected virtual void F() { Console.WriteLine("A.F"); }
            protected virtual void F2() { Console.WriteLine("A.F2"); }
        }

        class B : A
        {
            sealed protected override void F() { Console.WriteLine("B.F"); }
            protected override void F2() { Console.WriteLine("B.F2"); }
        }

        class C : B
        {
            
            protected override void F2() { Console.WriteLine("C.F2"); }
        }

        class SealedTest2
        {
            public static void Main(string[] args)
            {

            }
        }
    }
}