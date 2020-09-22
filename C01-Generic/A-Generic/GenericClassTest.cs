using System;
using System.Collections;

namespace A_Generic
{
    public interface MyIEnumerator<out T>
    {
        T Current {get;}
    }
    public class GenericList<T>
    {
        void Add(T input){}
    }

    public class GenericClassTest
    {
        private class ExampleClass{}
        public static void Main()
        {
            GenericList<int> list1 =new GenericList<int>();
            GenericList<string> list2 =new GenericList<string>();
            GenericList<ExampleClass> list3 =new GenericList<ExampleClass>();
        }
    }
}