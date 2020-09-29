using System;
using System.Linq;

namespace B_SelectAdvanced
{
    class OrderTest
    {
        static void Main(string[] args)
        {
            string[] Word = {"홍길동","박길동","정길동","김길동","이길동"};
            var sortAscending = from wd in Word orderby wd select wd;

            System.Console.WriteLine(sortAscending.GetType());

            var res = Word.OrderBy(myres => myres);
            System.Console.WriteLine("Ascending:");
            foreach(string s in res)
            {
                System.Console.WriteLine(s);
            }
            Console.ReadKey();

            var sortDescending = from w in Word orderby w descending select w;

            var res02 = Word.OrderByDescending(myres => myres);
            System.Console.WriteLine("Descending:");
            foreach(string s in res02)
            {
                System.Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
