using System;

namespace D_UserDefined
{
    class MyException : Exception
    {
        public override string ToString() 
        {
            return "나만의 예외처리";
        }
        public override string Message
        {
            get 
            {
                return "문자잖아 숫자를 원해";
            }
        }
    }
    public class UserDefined
    {
        public static void Main(string[] args)
        {
            try 
            {
                char ch = (char) Console.Read();
                if (char.IsLetter(ch)) throw new MyException();
            }
            catch (MyException m)
            {
                Console.WriteLine("myException" + m.ToString());
                Console.WriteLine("myExcetpion" + m.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
