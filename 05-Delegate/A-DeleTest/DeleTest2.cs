using System;

namespace A_DeleTest
{
    /// <summary>
    ///  명명된 메서드를 사용하여 만든 대리자에서는
    ///  정적 메서드나 인스턴스 메서드를 
    ///  캡슐화 할 수 있습니다.
    /// </summary>
    delegate void Prn();
    public class DeleTest2
    {
        public static void AAA() 
        {
            Console.WriteLine("AAA Method ");
        }
        public static void BBB() 
        {
            Console.WriteLine("BBB Method ");
        }
        public static void DDD() 
        {
            Console.WriteLine("static DDD Method ");
        }

        public static void Main()
        {
            Prn pr = new Prn(AAA);
            pr();
            Prn pr01 = new Prn(BBB);
            pr += pr01;
            pr();

            Console.WriteLine("==================");
            Prn prn02 = new Prn(DDD);
            prn02 += pr;
            prn02();
        }
    }
}