using System;

namespace A_ExtensionMethod
{
    using Test2;

    public class ExtenMethod
    {
        public static void Main(string[] args)
        {
            int a = 100;
            string str = "a클래스입니다.";
            a.Prn(a);
            a.Prn(str);
        }
    }
}

namespace Test2
{
    public static class Exam
    {
        public static void Prn(this object obj, int i)
        {
            System.Console.WriteLine("prn int="+i);
        }

        public static void Prn(this object obj, String s)
        {
            System.Console.WriteLine("prn String ="+s);
        }
    }
}

public class AA {}
public class BB
{
    public void Prn(int i) {}
}
public class CC 
{
    public void Prn(Object obj) {}
}