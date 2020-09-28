using System;

namespace C_AnonymousMethod
{
    public class AnoynmouseMethod
    {
        public static void Main(string[] args)
        {
            System.Threading.Thread t1 = new System.Threading.Thread
            (
                delegate()
                {
                    System.Console.Write("안녕하세요 ");
                    System.Console.WriteLine("반갑습니다!");
                }
            );
            t1.Start();
        }
    }
}   
