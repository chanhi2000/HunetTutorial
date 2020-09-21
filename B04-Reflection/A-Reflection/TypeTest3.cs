using System;
using System.Reflection;

namespace A_Reflection
{
    public class TypeTest3
    {
        public static void Main(string[] args)
        {
            Assembly a = Assembly.Load("Hello");
            Console.WriteLine(a.GetName());
            Console.WriteLine(a.GetType());
            Console.WriteLine(a.Location);

        }
    }
}