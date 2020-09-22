using System;

namespace A_Operator
{
    public class MyOp
    {
        private int a;
        private int b;

        public MyOp(): this(0,0) {}
        public MyOp(int r, int i)
        {
            a=r;
            b=i;
        }

        public override string ToString()
        {
            return (string.Format("{0} + {1}", a, b));
        }

        public static MyOp operator + (MyOp a, MyOp b)
        {
            return new MyOp(a.a+b.a, a.b+b.b);
        }
        
        public static MyOp operator - (MyOp a, MyOp b)
        {
            return new MyOp(a.a-b.a, a.b-b.b);
        }
        
        public static MyOp operator * (MyOp a, MyOp b)
        {
            return new MyOp(a.a*b.a, a.b*b.b);
        }

        public static MyOp operator / (MyOp a, MyOp b)
        {
            return new MyOp(a.a/b.a, a.b/b.b);
        }
    }
    class MTest
    {
        public static void Main(string[] args)
        {
            MyOp a = new MyOp(10, 12);
            MyOp b = new MyOp(8, 9);

            System.Console.WriteLine("연산자 Number a = {0}", a.ToString());
            System.Console.WriteLine("연산자 Number b = {0}", b.ToString());
            
            MyOp sum = a+b;
            System.Console.WriteLine("연산자 Number sum = {0}", sum.ToString());

            MyOp diff = a-b;
            System.Console.WriteLine("연산자 Number diff = {0}", diff.ToString());

            MyOp mul = a-b;
            System.Console.WriteLine("연산자 Number mul = {0}", mul.ToString());
        
            MyOp div = a/b;
            System.Console.WriteLine("연산자 Number div = {0}", div.ToString());
        }
    }
}
