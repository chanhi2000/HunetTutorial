using System;
using System.Linq;

namespace A_SelectBasic
{
    class SelectTest
    {
        static void Main(string[] args)
        {
            int[] numbers = {10, 20, 30, 40, 50};
            var lowNums = from num in numbers select num;
            foreach(int i in lowNums)
            {
                System.Console.Write(i+ " ");
            }
        }
    }
}
