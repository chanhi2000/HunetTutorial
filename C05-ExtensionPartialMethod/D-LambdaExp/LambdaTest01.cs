using System;

namespace D_LambdaExp
{
    public class LambdaTest01
    {
        public static void Main(string[] args)
        {

            Action<string> MyLambda1 = (string message) =>
            {
                System.Console.WriteLine(message);
            };

            Func<string, int> MyLambda2 = (message) =>
            {
                System.Console.WriteLine(message);
                return 0;
            };

            Predicate<string> MyLambda3 = (message) =>
            {
                System.Console.WriteLine(message);
                return true;
            };

            MyLambda1("람다 식에 문자열 전달!");

            int result =  MyLambda2("람다 식에 문자열 전달 정수 리턴!");
            System.Console.WriteLine("MyLambda2 반환 값 = "+result);
            
            bool resBool = MyLambda3("람다 식에 문자열 전달 bool 형 리턴!");
            System.Console.WriteLine("MyLambda3 반환 값 = "+resBool);
        }
    }
}