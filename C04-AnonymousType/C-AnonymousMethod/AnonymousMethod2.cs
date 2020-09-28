using System;

namespace C_AnonymousMethod
{
    public delegate void Prn(string str);

    public class AnoynmouseMethod2
    {
        public static void Main(string[] args)
        {
            Prn p = delegate (string j)
            {
                System.Console.WriteLine("이름이 없는 "+j+"입니다.");
            };
            
            p("무명메소드를 호출했습니다 ");
            p = new Prn(AnoynmouseMethod2.Disp);
            p("홍길동");
        }

        public static void Disp(string name)
        {
            System.Console.WriteLine("나의 이름은 명명 메소드 "+name+ "입니다.");
        }
    }
}