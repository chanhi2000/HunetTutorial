using System;
using System.Collections.Generic;
using System.Linq;

namespace B_SelectAdvanced
{
    public class IntoTest
    {
        public static void Main()
        {
            string[] Empno = {"a1111", "b2222", "a1112", "b11111", "c1111"};
            var nq = 
                from no in Empno 
                group no by no[0] into tmpno 
                where tmpno.Count() >= 2 
                select new { Firstno = tmpno.Key, Empno = tmpno.Count()};

            foreach(var item in nq)
            {
                System.Console.WriteLine(" {0} has {1} .", item.Firstno, item.Empno);
            }
            System.Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}