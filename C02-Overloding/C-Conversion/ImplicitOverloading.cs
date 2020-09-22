using System;

namespace C_Conversion
{
    public class Test
    {
        public double val;
        public string v;
        public Test(double d) { val = d; }
        public Test(string v) { this.v = v; }

        public static implicit operator double(Test d)
        {
            return d.val;
        }
        public static implicit operator Test(double d)
        {
            return new Test(d);
        }
        public static implicit operator Test(string v)
        {
            return new Test(v);
        }
        
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Test dig = new Test(7);
            double num = dig;
            Test dig2 = 12;
            System.Console.WriteLine("num = {0} dig2 = {1}", num, dig2.val);
            string str = "ab";
            dig2 = str;
            System.Console.WriteLine("num = {0} dig2 = {1}", str, dig2.v);
        }
    }
}
