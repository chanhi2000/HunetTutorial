using System;

namespace A_Try
{
    public class MultiTry
    {
        public static void Main(string[] args)
        {
            int a = 0;
            int b = 100;
            int res = 0;
            
            try 
            {
                res = b/a;         
            } 
            catch (DivideByZeroException e) 
            {
                a = 100;
                res = b/a;
                Console.WriteLine(e + "divide");
            }
            catch (ArithmeticException ai)
            {
                Console.WriteLine(ai);
            }
            catch (SystemException s)
            {
                Console.WriteLine(s);
            }
            catch (Exception ei)
            {
                Console.WriteLine(ei);
            }
            Console.WriteLine("a = {0,4} b = {1,4} res = {2,4}", a, b, res);
        }
    }
}
