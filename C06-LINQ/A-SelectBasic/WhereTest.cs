using System;
using System.Linq;
using System.Collections.Generic;

namespace A_SelectBasic
{
    public class WhereTest
    {
        public static void Main()
        {
            var src = new[] {10, 20, 33, 40, 50, 66};
            Print(src);

            var mapped = src.Select(myres => myres * 2);
            Print(mapped);

            var filtered = src.Where(myres => myres % 3 == 1);
            Print(filtered);
        }

        public static void Print(IEnumerable<int> filtered)
        {
            Console.WriteLine("\n============================");
            foreach(int res in filtered)
            {
                Console.Write("{0,4}", res);
            }
        }
    }
}