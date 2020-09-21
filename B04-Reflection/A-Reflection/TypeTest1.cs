using System;
using System.Reflection;

namespace A_Reflection
{
    public class TypeTest1
    {
        public static void Main(string[] args)
        {
            Type t = typeof(string);
            MethodInfo substr = t.GetMethod("Substring", new Type[] { typeof(int), typeof(int) });

            Object result = substr.Invoke("Hello  World!", new Object[] {7, 5});
            System.Console.WriteLine("{0} returned \"{1}\"", substr, result);
        }
    }
}
