using System;
using System.Collections;

namespace A_Generic
{
    public class GenericTest
    {
        public static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
        
        public static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            float d = 30.4f, e=50.7f;
            string str1 = "여름", str2="겨울";

            System.Console.WriteLine("변경전 : " + a + " " +b);
            Swap<int>(ref a, ref b);
            System.Console.WriteLine(a + " " + b);

            System.Console.WriteLine("==================");
            System.Console.WriteLine("변경전 : " + d + " " +e);
            Swap<float>(ref d, ref e);
            System.Console.WriteLine(d + " " + e);
            
            System.Console.WriteLine("==================");
            System.Console.WriteLine("변경전 : " + str1 + " " +str2);
            Swap<string>(ref str1, ref str2);
            System.Console.WriteLine(str1 + " " + str2);

        }
    }
}
