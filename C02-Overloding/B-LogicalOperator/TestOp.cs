using System;

namespace B_LogicalOperator
{
    public class TestOp
    {
        public static bool operator false(TestOp c)
        {
            Console.WriteLine("TestOp.false");
            return false;
        }
        public static bool operator true(TestOp c)
        {
            Console.WriteLine("TestOp.true");
            return false;
        }
        public static TestOp operator | (TestOp c1, TestOp c2)
        {
            Console.WriteLine("TestOp.|");
            return new TestOp();
        }
        public static TestOp operator & (TestOp c1, TestOp c2)
        {
            Console.WriteLine("TestOp.&");
            return new TestOp();
        }

        

    }

    class MTest
    {
        static void Main(string[] args)
        {
            TestOp c1 = new TestOp();
            TestOp c2 = new TestOp();
            if (c1 && c2)
            {
                Console.WriteLine(c1 && c2);
            }
            if (c1 || c2)
            {
                Console.WriteLine(c1 || c2);
            }

        }
    }
}

