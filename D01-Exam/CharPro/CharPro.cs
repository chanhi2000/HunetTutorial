using System;

namespace CharPro
{
    public class CharPro
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a character: ");
            char c = (char) Console.ReadKey().KeyChar;
            System.Console.WriteLine();
            string type;
            if (char.IsUpper(c))
            {
                type = "대문자";
            }
            else if (char.IsLower(c))
            {
                type = "소문자";
            }
            else if (char.IsNumber(c))
            {
                type = "숫자";
            }
            else  
            {
                type = "기타등등";
            }
            System.Console.WriteLine("입력한 문자는 {0}입니다", type);
        }
    }
}
