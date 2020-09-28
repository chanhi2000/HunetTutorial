using System;

namespace A_Var
{
    class Var
    {
        public static void Main(string[] args)
        {
            var a = 100.4;      // 선언 동시에 초기화 필수
            int b = (int)a;
            System.Console.WriteLine("a={0} b={1}", a, b);
            
            var s = "안녕하세요.";
            string str = "반값습니다.";
            System.Console.WriteLine("s={0} str={1}", s, str);
            Prn(a,b);


            var ch ='h';
            System.Console.WriteLine("==============================");
            System.Console.WriteLine("Type: {0}, Value: {1}", a.GetType(), a);
            System.Console.WriteLine("Type: {0}, Value: {1}", ch.GetType(), ch);
            System.Console.WriteLine("Type: {0}, Value: {1}", s.GetType(), s);

        }
        public static void Prn(double a, int b)
        {
            System.Console.WriteLine("a={0} b={1}", a, b);
        }
    }
}
