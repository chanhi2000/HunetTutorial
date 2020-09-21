using System;
using System.Diagnostics;

namespace B_Attribute
{
    public class AttributeTest2
    {
        [Conditional("Debugging")]
        public static void DebugPrint()
        {
            Console.WriteLine("Debugging Now");
        }

        public static void Main(string[] args)
        {
            DebugPrint();
        }
    }
}