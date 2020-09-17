using System;

namespace C_Throw
{
    public class ThrowTest
    {
        public static void Prn()
        {
            try 
            {
                throw new DivideByZeroException("테스트용 예외");
            }
            catch (DivideByZeroException d)
            {
                Console.WriteLine(d.Message);
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void Main(string[] args)
        {
           try
           {
               Prn();
           } 
           catch (DivideByZeroException d)
           {
               Console.WriteLine(d);
           }
        }
    }
}