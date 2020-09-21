using System;
using System.Reflection;

namespace A_Reflection
{
    public class TypeTest2
    {

        public static void Main(string[] args)
        {
            Type t = typeof(System.Type);
            System.Console.WriteLine("이 프로그램은 {0} 타입의 정보를 출력합니다.", t);
            System.Console.WriteLine();

            System.Console.WriteLine("<기본정보>");
            System.Console.WriteLine("\t타입의 이름은?:{0}",t.FullName);
            System.Console.WriteLine("\t기본타입은?:{0}",t.BaseType);
            System.Console.WriteLine("\t클래스인가?:{0}", t.IsClass);
            System.Console.WriteLine("\t추상클래스인가?:{0}", t.IsAbstract);
            System.Console.WriteLine("\tSealed 클래스인가?:{0}", t.IsSealed);
            System.Console.WriteLine("\tCOM 객체인가?:{0}", t.IsCOMObject);
            System.Console.WriteLine();
            System.Console.WriteLine("<상세정보>");

            Type[] ts = t.GetInterfaces();
            System.Console.WriteLine("인터페이스:");
            Prn(ts);
            
            FieldInfo[] fis = t.GetFields();
            System.Console.WriteLine("필드:");
            Prn(fis);

            EventInfo[] eis = t.GetEvents();
            System.Console.WriteLine("이벤트:");
            Prn(eis);

            MethodInfo[] mis = t.GetMethods();
            System.Console.WriteLine("메소드:");
            Prn(mis);   
        }

        public static void Prn(MemberInfo[] mis)
        {
            foreach(MemberInfo mi in mis)
            {
                Console.WriteLine("\t{0}", mi);
            }
            Console.WriteLine();
        }
    }
}