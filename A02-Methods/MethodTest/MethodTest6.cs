using System;

namespace MethodTest
{
    public class MethodTest6
    {
        public static void UseParams(params int[] list)
        {   
            int sum = 0;
            foreach(int i in list)
            {
                sum += i;
            }
            Console.WriteLine("sum={0}", sum);
            Console.WriteLine();
        }

        public static void Main()
        {
            UseParams(1,2,3,4,5);
            int[] myarray = new int[4] {10, 11, 12, 13};
            UseParams(myarray);
        }
    }
}