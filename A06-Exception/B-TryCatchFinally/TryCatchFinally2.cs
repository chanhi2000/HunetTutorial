using System;


namespace B_TryCatchFinally
{
    public class TryCatchFinally2
    {
        public static void Main(string[] args)
        {
            int[] array = {1,2,3,4,5,6};
            foreach (int n in array)
            {
                try 
                {
                    if(n == 3) break;
                    Console.WriteLine(n);
                }
                finally
                {
                    Console.WriteLine(n + "의 종료를 호출했습니다 (1)");
                }
            }
            foreach (int n in array)
            {
                try 
                {
                    if (n==3) return;
                    Console.WriteLine(n);
                }
                finally
                {
                    Console.WriteLine(n + "의 종료를 호출했습니다 (2)");
                }
            }

        }
    }
}