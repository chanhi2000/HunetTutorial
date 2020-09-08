using System;

namespace E_Interface
{
    public class MY : ICloneable
    {
        public string name = "dominica";

        public object Clone()
        {
            MY clone = new MY();
            clone.name = this.name;
            return clone;
        }
        
    }

    public class Class2
    {
        public static void Main()
        {
            MY d1 = new MY();
            MY d2 = d1.Clone() as MY;

            Console.WriteLine(d2.name);
        }
    }
}