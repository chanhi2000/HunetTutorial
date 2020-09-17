using System;

namespace C_Throw
{
    public class Throw
    {
        public static void Main(string[] args)
        {
            try
            {
                throw new Exception("테스트용 예외");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
