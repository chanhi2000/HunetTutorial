using System;

namespace B_TryCatchFinally
{
    public class TryCatchFinally
    {
        public static void Main(string[] args)
        {
            int i = 123;
            string s = "Some string";
            object o = s;
            try 
            {
                i = (int)o;
            }
            finally 
            {
                Console.WriteLine("i = {0}", i);
            }
        }
    }
}
